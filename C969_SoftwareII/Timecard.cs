using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_SoftwareII
{
    public partial class Timecard : Form
    {
        public Timecard()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            this.Owner.Show();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "_logins-logouts.txt";

            string[] readText = File.ReadAllLines(path);
            IList<String> dataStrings = new List<String>();
            foreach (string s in readText)
            {
                dataStrings.Add(s);
            }
            if (readText.Length == 0)
            {
                dataStrings.Add("No timecard information to show.");
            }
            dataGridView.DataSource = dataStrings.Select(x => new { Value = x }).ToList();
            dataGridView.Show();
        }

        private void Timecard_Load(object sender, EventArgs e)
        {

        }
    }
}
