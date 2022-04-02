using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_SoftwareII
{
    public partial class AddAppt : Form
    {
        public string dataString = DBHelper.getDataString();
        public AddAppt()
        {
            InitializeComponent();
            fillCust();
            endDTP.Value = endDTP.Value.AddMinutes(30);

        }

        public void fillCust()
        {
            MySqlConnection conn = new MySqlConnection(dataString);

            try
            {
                string query = "SELECT customerId, concat(customerName, ' -- ID: ', customerId) as Display FROM customer;";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Cust");
                custComboBox.DisplayMember = "Display";
                custComboBox.ValueMember = "customerId";
                custComboBox.DataSource = ds.Tables["Cust"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured! " + ex);
            }
        }

        public int appointmentValid(DateTime start, DateTime end)
        {
            DateTime localStart = start.ToLocalTime();
            DateTime localEnd = end.ToLocalTime();

            DateTime businessStart = DateTime.Today.AddHours(8);
            DateTime businessEnd = DateTime.Today.AddHours(17);

            // Return 1 for outside business hours (8am - 5pm local)
            if (localStart.TimeOfDay < businessStart.TimeOfDay || localEnd.TimeOfDay > businessEnd.TimeOfDay)
            {
                return 1;
            }
            if (DBHelper.overlap(start, end) != 0)
            {
                return 2;
            }
            // Return 2 for failed overlap
            // DB? Or can we look at Dashboard table
            // Return 3 for end before start
            if (localStart.TimeOfDay > localEnd.TimeOfDay)
            {
                return 3;
            }
            // Return 4 for appoinment not same day
            if (localStart.ToShortDateString() != localEnd.ToShortDateString())
            {
                return 4;
            }
            // Return 0 pass 
            return 0;
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private bool validator()
        {

            if (emptyCheck() == false)
            {
                MessageBox.Show("Please complete all Appointment Information fields.");
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(titleTextbox.Text, "[^a-zA-Z]+$"))
            {
                showError(titleLabel.Text);
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(descriptionTextbox.Text, "[^a-zA-Z]+$"))
            {
                showError(descriptionLabel.Text);
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(locationTextbox.Text, "[^a-zA-Z]+$"))
            {
                showError(locationLabel.Text);
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(contactTextbox.Text, "[^a-zA-Z]+$"))
            {
                showError(contactLabel.Text);
                return false;
            }
            if (typeCombobox.SelectedIndex == -1)
            {
                showError(typeLabel.Text);
                return false;
            }

            return true;
        }

        private void showError(string item)
        {
            MessageBox.Show("Please enter a valid information for " + item);

        }
        private bool emptyCheck()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        return false;
                    }
                }
                if (c is ComboBox)
                {
                    ComboBox combo = c as ComboBox;
                    if (combo.SelectedIndex == -1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void AddAppt_Load_1(object sender, EventArgs e)
        {

        }

        private void CreateCusButton_Click(object sender, EventArgs e)
        {
            bool pass = validator();

            if (pass)
            {
                if (custComboBox.SelectedItem != null)
                {
                    // Have a customer selected solets add the appointment
                    // customer ID
                    int custID = Convert.ToInt32(custComboBox.SelectedValue);

                    DateTime start = startDTP.Value.ToUniversalTime();
                    DateTime end = endDTP.Value.ToUniversalTime();

                    // Validations 
                    // Appointment is not being set outside business hours
                    // Appointment will not overlap with another appointment
                    int validated = appointmentValid(start, end);

                    switch (validated)
                    {
                        case 1:
                            MessageBox.Show("This appointment does not fall within business hours.");
                            break;
                        case 2:
                            MessageBox.Show("This appointment overlaps with another appointment.");
                            break;
                        case 3:
                            MessageBox.Show("This appointment starts after the end time.");
                            break;
                        case 4:
                            MessageBox.Show("This appointment start and end date are not on the same date.");
                            break;
                        default:
                            DBHelper.createAppointment(custID, titleTextbox.Text, descriptionTextbox.Text, locationTextbox.Text, contactTextbox.Text, typeCombobox.SelectedItem.ToString(), start, end);
                            this.Owner.Show();
                            this.Close();
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show("A customer must be selected!");
            }
        }
    }
}
