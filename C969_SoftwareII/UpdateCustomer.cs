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
    public partial class UpdateCustomer : Form
    {
        public static List<KeyValuePair<string, object>> CustList;

        public UpdateCustomer()
        {
            InitializeComponent();
            fillCust();
        }

        public void setCustList(List<KeyValuePair<string, object>> list)
        {

            CustList = list;

        }

        public static List<KeyValuePair<string, object>> getCustList()
        {

            return CustList;
        }



        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Hide();
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

        private void clearButton_Click(object sender, EventArgs e)
        {
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


        private void enabling(bool status)
        {
            nameTextbox.Enabled = status;
            phoneTextbox.Enabled = status;
            addressTextbox.Enabled = status;
            SecAddressTextBox.Enabled = status;
            cityTextbox.Enabled = status;
            zipTextbox.Enabled = status;
            countryTextbox.Enabled = status;
            yesRadio.Enabled = status;
            noRadio.Enabled = status;
            updateButton.Enabled = status;
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            bool pass = validator();
            if (pass)
            {
                DialogResult youSure = MessageBox.Show("Are you sure you want to update this customer?", "", MessageBoxButtons.YesNo);
                if (youSure == DialogResult.Yes)
                {
                    try
                    {
                        // Grab List & convert
                        var list = getCustList();
                        IDictionary<string, object> dictionary = list.ToDictionary(pair => pair.Key, pair => pair.Value);
                        // Replace values for the keys in the form         
                        dictionary["customerName"] = nameTextbox.Text;
                        dictionary["phone"] = phoneTextbox.Text;
                        dictionary["address"] = addressTextbox.Text;
                        dictionary["address2"] = SecAddressTextBox.Text;
                        dictionary["city"] = cityTextbox.Text;
                        dictionary["postalCode"] = zipTextbox.Text;
                        dictionary["country"] = countryTextbox.Text;
                        dictionary["active"] = yesRadio.Checked ? 1 : 0;

                        // Pass the updated IDictionary to dbhelper to update the database
                        DBHelper.updateCustomer(dictionary);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                    finally
                    {
                        clearButton_Click(null, new EventArgs());
                        MessageBox.Show("Customer Record Updated");

                        this.Owner.Show();
                        this.Close();
                    }

                }
            }

        }

        private bool validator()
        {

            if (System.Text.RegularExpressions.Regex.IsMatch(nameTextbox.Text, "[^a-zA-Z]+$"))
            {
                showError(nameLabel.Text);
                return false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(phoneTextbox.Text, "[^0-9-()]+$"))
            {
                showError(phoneLabel.Text);
                return false;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(zipTextbox.Text, "[^0-9]"))
            {
                showError(zipLabel.Text);
                return false;
            }

            var textBoxes = new List<string> { nameTextbox.Text, phoneTextbox.Text, addressTextbox.Text, cityTextbox.Text, zipTextbox.Text, countryTextbox.Text };
            foreach (string value in textBoxes)
            {
                if (value.Length < 1)
                {
                    MessageBox.Show("Please complete all Customer Information fields.");
                    return false;
                }
            }
            return true;
        }

        private void showError(string item)
        {
            MessageBox.Show("Please enter a valid information for " + item);

        }

        private void UpdateCustomer_Load_1(object sender, EventArgs e)
        {

        }
    }
}
