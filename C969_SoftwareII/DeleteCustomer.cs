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
    public partial class DeleteCustomer : Form
    {
        public static List<KeyValuePair<string, object>> CustList;
        public DeleteCustomer()
        {
            InitializeComponent();
            fillCust();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
        }

        public void setCustList(List<KeyValuePair<string, object>> list)
        {

            CustList = list;

        }

        public static List<KeyValuePair<string, object>> getCustList()
        {

            return CustList;
        }

        public void fillCust()
        {
            MySqlConnection conn = new MySqlConnection(DBHelper.getDataString());

            try
            {
                string query = "SELECT customerId, concat(customerName, ' -- ID: ', customerId) as Display FROM customer;";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Cust");
                custComboBox.DisplayMember = "Display";
                custComboBox.ValueMember = "customerID";
                custComboBox.DataSource = ds.Tables["Cust"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured! " + ex);
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
                    else
                        clearIT(option.Controls);
            };

            clearIT(Controls);
        }
        private void enabling(bool status)
        {
            deleteButton.Enabled = status;
        }
        private void fillFields(List<KeyValuePair<string, object>> custList)
        {
            // Lambda used to set text values from kvp
            nameTextbox.Text = custList.First(kvp => kvp.Key == "customerName").Value.ToString();
            phoneTextbox.Text = custList.First(kvp => kvp.Key == "phone").Value.ToString();
            addressTextbox.Text = custList.First(kvp => kvp.Key == "address").Value.ToString();
            SecAddressTextBox.Text = custList.First(kvp => kvp.Key == "address2").Value.ToString();
            cityTextbox.Text = custList.First(kvp => kvp.Key == "city").Value.ToString();
            zipTextbox.Text = custList.First(kvp => kvp.Key == "postalCode").Value.ToString();
            countryTextbox.Text = custList.First(kvp => kvp.Key == "country").Value.ToString();
            if (Convert.ToInt32(custList.First(kvp => kvp.Key == "active").Value) == 1)
            {
                yesRadio.Checked = true;
            }
            else
            {
                noRadio.Checked = true;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            // Grabs ID
            DataRowView drv = custComboBox.SelectedItem as DataRowView;
            int id = Convert.ToInt32(custComboBox.SelectedValue);
            var custList = DBHelper.searchCustomer(id);
            setCustList(custList);
            // Calls db helper to get all customer results as object array
            // If we got a null array, don't continue
            if (custList != null)
            {
                // Enable fields
                enabling(true);
                // Input data into text fields
                fillFields(custList);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult youSure = MessageBox.Show("Are you sure you want to delete this customer?", "", MessageBoxButtons.YesNo);
            if (youSure == DialogResult.Yes)
            {
                try
                {
                    // Grab List & convert
                    var list = getCustList();
                    IDictionary<string, object> dictionary = list.ToDictionary(pair => pair.Key, pair => pair.Value);
                    // First we need to check if appointments exist
                    bool appoint = DBHelper.appointExist(dictionary["customerId"].ToString());
                    if (appoint == false)
                    {
                        DBHelper.deleteCustomer(dictionary);

                    }
                    else
                    {
                        DialogResult youSure2 = MessageBox.Show("Deleting this customer will remove all of there associated appointments, contiune?", "", MessageBoxButtons.YesNo);
                        if (youSure2 == DialogResult.Yes)
                        {
                            DBHelper.noCustAppointments(dictionary["customerId"].ToString());
                            DBHelper.deleteCustomer(dictionary);
                        }
                        else
                        {
                            return;
                        }
                    }
                    ClearButton_Click(null, new EventArgs());
                    MessageBox.Show("Customer Record Deleted");

                    this.Owner.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            }

        }

        private void DeleteCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
