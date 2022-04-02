using C969_SoftwareII;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_SoftwareII
{
    public partial class Login : Form
    {

        public string error = "The username and password entered are not valid.";
        public string exit = "Are you sure to exit this Application?";
        public Login()
        {
            InitializeComponent();
            // Supports English or Italian(LCID == 1040);
            languageCheck(CultureInfo.CurrentUICulture.LCID);
            // languageCheck(1040);
        }

        private void languageCheck(int LCID)
        {
            if (LCID == 1040)
            {
                this.Text = "Accesso";
                infoLabel.Text = "Inserisci le informazioni di accesso";
                usernameLabel.Text = "Nome utente";
                passwordLabel.Text = "Parola d'ordine";
                loginButton.Text = "Accesso";
                cancelButton.Text = "Annulla";
                error = "Il nome utente e la password inseriti non sono validi.";
                exit = "sei sicuro di uscire da questa Applicazione?";
            }
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(exit, this.Text,
                                   MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click_1(object sender, EventArgs e)
        {
            // Call to DB to make sure user and pass are correct
            if (DBHelper.userCheck(userTextbox.Text, passTextbox.Text) == 1)
            {
                // Log in text file username and time of login
                Logger.signIn(DBHelper.getCurrentUserName());
                // Show Dashboard
                Form dash = new Dashboard();
                // Function that handles appointment reminder
                Logger.reminder();
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(error);
            }

        }
    }
}
