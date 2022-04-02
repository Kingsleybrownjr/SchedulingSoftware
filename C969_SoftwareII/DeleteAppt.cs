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
    public partial class DeleteAppt : Form
    {
        public static List<KeyValuePair<string, object>> AppointList;
        public DeleteAppt()
        {
            InitializeComponent();
            fillAppoint();
        }
        public void setAppointList(List<KeyValuePair<string, object>> list)
        {

            AppointList = list;

        }

        public static List<KeyValuePair<string, object>> getAppointList()
        {

            return AppointList;
        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            //Grabs ID
            DataRowView drv = appointComboBox.SelectedItem as DataRowView;
            int id = Convert.ToInt32(appointComboBox.SelectedValue);

            var appointList = DBHelper.searchAppointment(id);
            setAppointList(appointList);


            if (appointList != null)
            {
                //Enable fields
                enabling(true);
                //Input data into text fields
                fillFields(appointList);
                //Grabs customer assoicated with appointment
                fillCust(Convert.ToInt32(appointList.First(kvp => kvp.Key == "customerId").Value.ToString()));
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult youSure = MessageBox.Show("Are you sure you want to delete this Appointment?", "", MessageBoxButtons.YesNo);
            if (youSure == DialogResult.Yes)
            {
                // Delete the things
                try
                {
                    // Grab List & convert
                    var list = getAppointList();
                    IDictionary<string, object> dictionary = list.ToDictionary(pair => pair.Key, pair => pair.Value);
                    DBHelper.deleteAppointment(dictionary);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    ClearButton_Click(null, new EventArgs());
                    MessageBox.Show("Appointment Deleted");

                    this.Owner.Show();
                    this.Close();
                }
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Locks fields
            enabling(false);
            // Lamba used for function to clear fields 
            Action<Control.ControlCollection> clearIT = null;

            clearIT = (controls) =>
            {
                foreach (Control option in controls)
                    if (option is TextBox)
                        (option as TextBox).Clear();
                    else if (option is RadioButton)
                        (option as RadioButton).Checked = false;
                    else if (option is DateTimePicker)
                        (option as DateTimePicker).Value = DateTime.Now;
                    else if (option is ComboBox)
                        (option as ComboBox).SelectedIndex = -1;
                    else
                        clearIT(option.Controls);
            };

            clearIT(Controls);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }
        public void fillAppoint()
        {
            MySqlConnection conn = new MySqlConnection(DBHelper.getDataString());

            try
            {
                string query = "select appointmentId, concat(appointmentId, (select  concat(' -- Customer: ', customerName) from customer where appointment.customerId = customer.customerId))  as Display from appointment;";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Appoint");
                appointComboBox.DisplayMember = "Display";
                appointComboBox.ValueMember = "appointmentId";
                appointComboBox.DataSource = ds.Tables["Appoint"];
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                Console.WriteLine("Error occured! " + ex);
            }
        }
        public void fillCust(int custID)
        {
            MySqlConnection conn = new MySqlConnection(DBHelper.getDataString());

            try
            {
                string query = $"SELECT customerId, concat(customerName, ' -- ID: ', customerId) as Display FROM customer;";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Cust");
                customerComboBox.DisplayMember = "Display";
                customerComboBox.ValueMember = "customerID";
                customerComboBox.DataSource = ds.Tables["Cust"];
                DataRowView drv = customerComboBox.SelectedItem as DataRowView;
                customerComboBox.SelectedValue = custID;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured! " + ex);
            }
        }

        private void fillFields(List<KeyValuePair<string, object>> AppointList)
        {
            // Lambda used to set text values from kvp
            titleTextbox.Text = AppointList.First(kvp => kvp.Key == "title").Value.ToString();
            descriptionTextbox.Text = AppointList.First(kvp => kvp.Key == "description").Value.ToString();
            locationTextbox.Text = AppointList.First(kvp => kvp.Key == "location").Value.ToString();
            contactTextbox.Text = AppointList.First(kvp => kvp.Key == "contact").Value.ToString();
            typeCombobox.SelectedIndex = typeCombobox.FindStringExact(AppointList.First(kvp => kvp.Key == "type").Value.ToString());
            string start = AppointList.First(kvp => kvp.Key == "start").Value.ToString();
            string end = AppointList.First(kvp => kvp.Key == "end").Value.ToString();
            //startDTP.Value = Convert.ToDateTime(start).ToLocalTime();
            //endDTP.Value = Convert.ToDateTime(end).ToLocalTime();

            var list = getAppointList();
            IDictionary<string, object> dictionary = list.ToDictionary(pair => pair.Key, pair => pair.Value);
            startDTP.Value = TimeZone.CurrentTimeZone.ToLocalTime((DateTime)dictionary["start"]);
            endDTP.Value = TimeZone.CurrentTimeZone.ToLocalTime((DateTime)dictionary["end"]);
        }

        private void enabling(bool status)
        {
            deleteButton.Enabled = status;
        }

        private void DeleteAppoint_Load(object sender, EventArgs e)
        {

        }
    }
}
