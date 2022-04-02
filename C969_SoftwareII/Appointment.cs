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
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
        }

        private void reportButton_Click_1(object sender, EventArgs e)
        {
            DataRowView drv = typeComboBox.SelectedItem as DataRowView;
            try
            {
                string item = typeComboBox.SelectedItem.ToString();
                
                // Pass item to DBhelper and get back dict of counts for appoints that month with type
                // Grab List & convert
                IDictionary<string, object> dictionary = DBHelper.reportAppoint(item);
                janResult.Text = dictionary["Jan"].ToString();
                febResult.Text = dictionary["Feb"].ToString();
                marResult.Text = dictionary["Mar"].ToString();
                aprResult.Text = dictionary["Apr"].ToString();
                mayResult.Text = dictionary["May"].ToString();
                junResult.Text = dictionary["Jun"].ToString();
                julResult.Text = dictionary["Jul"].ToString();
                augResult.Text = dictionary["Aug"].ToString();
                septResult.Text = dictionary["Sep"].ToString();
                octResult.Text = dictionary["Oct"].ToString();
                novResult.Text = dictionary["Nov"].ToString();
                decResult.Text = dictionary["Dec"].ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void Appointment_Load_1(object sender, EventArgs e)
        {

        }

        private void backButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }
    }
}
