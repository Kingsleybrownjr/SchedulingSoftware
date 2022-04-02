using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace C969_SoftwareII
{
    public partial class Dashboard : Form
    {

        public static string dataString = DBHelper.getDataString();
        public Dashboard()
        {
            InitializeComponent();
            this.FormClosing += Dashboard_FormClosing;
            this.Activated += new System.EventHandler(this.Dashboard_Activated);
        }

        private void Dashboard_Activated(object sender, EventArgs e)
        {
            Dashboard_Load(weekViewRadio.Checked);
        }

        public void Dashboard_Load(bool week)
        {
           
            DateTime filter = week ? calcDateFilter("week") : calcDateFilter("month");
            DataTable dtRecord = DBHelper.dashboard(DBHelper.dateSQLFormat(filter), week);
            dataGridView.DataSource = dtRecord;
        }

        private void createCusButton_Click(object sender, EventArgs e)
        {
            Form createCust = new CreateCustomer();
            createCust.Owner = this;
            createCust.Show();
            this.Hide();
        }

        private void updateCusButton_Click(object sender, EventArgs e)
        {
            Form updateCust = new UpdateCustomer();
            updateCust.Owner = this;
            updateCust.Show();
            this.Hide();
        }

        private void deleteCusButton_Click(object sender, EventArgs e)
        {
            Form deleteCust = new DeleteCustomer();
            deleteCust.Owner = this;
            deleteCust.Show();
            this.Hide();
        }

        private void numApptButton_Click(object sender, EventArgs e)
        {
            Form appoint = new Appointment();
            appoint.Owner = this;
            appoint.Show();
            this.Hide();
        }

        private void schedButton_Click(object sender, EventArgs e)
        {
            Form schedule = new Schedule();
            schedule.Owner = this;
            schedule.Show();
            this.Hide();

        }

        private void cusReportButton_Click(object sender, EventArgs e)
        {
            Form timeCard = new Timecard();
            timeCard.Owner = this;
            timeCard.Show();
            this.Hide();
        }
        public DataTable ConvertToDataTable(string filePath, int numberOfColumns)
        {
            DataTable tbl = new DataTable();

            for (int col = 0; col < numberOfColumns; col++)
                tbl.Columns.Add(new DataColumn("Column" + (col + 1).ToString()));


            string[] lines = System.IO.File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                var cols = line.Split(':');

                DataRow dr = tbl.NewRow();
                for (int cIndex = 0; cIndex < 3; cIndex++)
                {
                    dr[cIndex] = cols[cIndex];
                }

                tbl.Rows.Add(dr);
            }

            return tbl;
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.signOut(DBHelper.getCurrentUserName());
        }

        private void AddApptButton_Click(object sender, EventArgs e)
        {
            Form addPoint = new AddAppt();
            addPoint.Owner = this;
            addPoint.Show();
            this.Hide();
        }


        private void UpdateApptButton_Click(object sender, EventArgs e)
        {
            Form updateAppoint = new UpdateAppt();
            updateAppoint.Owner = this;
            updateAppoint.Show();
            this.Hide();
        }

        private void DeleteApptButton_Click(object sender, EventArgs e)
        {
            Form deleteAppint = new DeleteAppt();
            deleteAppint.Owner = this;
            deleteAppint.Show();
            this.Hide();

        }

        private void WeekViewRadio_CheckedChanged(object sender, EventArgs e)
        {
            Dashboard_Load(weekViewRadio.Checked);
        }


        public DateTime calcDateFilter(string type)
        {
            if (type == "week")
            {
                DateTime week = DateTime.Now.AddDays(7);
                return week;
            }
            else
            {
                DateTime month = DateTime.Now.AddMonths(1);
                return month;
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
