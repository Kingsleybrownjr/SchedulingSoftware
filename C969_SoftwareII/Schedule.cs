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
    public partial class Schedule : Form
    {
        public static List<KeyValuePair<string, object>> userList;

        public Schedule()
        {
            InitializeComponent();
            fillConsol();
        }
        public void setUserList(List<KeyValuePair<string, object>> list)
        {

            userList = list;

        }

        public static List<KeyValuePair<string, object>> getUserList()
        {

            return userList;
        }


        public void fillConsol()
        {
            MySqlConnection conn = new MySqlConnection(DBHelper.getDataString());

            try
            {
                string query = "SELECT userId, userName as 'Display' from user;";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "User");
                consultantComboBox.DisplayMember = "Display";
                consultantComboBox.ValueMember = "userId";
                consultantComboBox.DataSource = ds.Tables["User"];
            }
            catch (Exception ex)
            {
                // Write exception info to log or anything else
                Console.WriteLine("Error occured! " + ex);
            }
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            DataRowView drv = consultantComboBox.SelectedItem as DataRowView;
            int id = Convert.ToInt32(consultantComboBox.SelectedValue);

            DataTable dtRecord = DBHelper.schedule(id.ToString());
            dataGridView.DataSource = dtRecord;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {

        }
    }
}
