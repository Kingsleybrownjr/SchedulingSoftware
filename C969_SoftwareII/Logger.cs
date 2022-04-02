using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_SoftwareII
{
    class Logger
    {

        private static DateTime? _time;
        public static void setTime(DateTime? Time)
        {
            _time = Time;
        }
        public static DateTime? getTime()
        {
            return _time;
        }
        public static void signIn(string userName)
        {
            DateTime time = DateTime.Now.ToLocalTime();

            Dictionary<DateTime, string> dictionary = new Dictionary<DateTime, string>();
            dictionary.Add(time, userName);
            setTime(time);

            foreach (KeyValuePair<DateTime, string> keyValue in dictionary)
            {
                string log = string.Format("Login time = {0}, userName = {1}", keyValue.Key, keyValue.Value);
                StringBuilder sb = new StringBuilder();
                sb.Append(log + Environment.NewLine);

                File.AppendAllText(Application.StartupPath + "_logins-logouts.txt", sb.ToString());
                sb.Clear();
            }
        }


        public static void signOut(string userName)
        {

            Dictionary<DateTime, string> dictionary = new Dictionary<DateTime, string>();
            dictionary.Add(DateTime.Now, userName);

            foreach (KeyValuePair<DateTime, string> keyValue in dictionary)
            {
                string log = string.Format("Logout time = {0}, userName = {1}", keyValue.Key, keyValue.Value);
                StringBuilder sb = new StringBuilder();
                sb.Append(log + Environment.NewLine);

                File.AppendAllText(Application.StartupPath + "_logins-logouts.txt", sb.ToString());
                sb.Clear();

            }
        }

        public static void reminder()
        {
            try
            {

                // Grab time of next appointment start
                var list = DBHelper.getNextAppointInfo();
                IDictionary<string, object> dictionary = list.ToDictionary(pair => pair.Key, pair => pair.Value);
                // Time of login
                DateTime? timeIn = getTime();
                DateTime? nextAppoint = Convert.ToDateTime(dictionary["start"]);
                string name = dictionary["name"].ToString();
                if (timeIn != null && nextAppoint != null)
                {
                    DateTime dateTime1 = timeIn.Value;
                    DateTime dateTime2 = nextAppoint.Value;
                    TimeSpan diff = dateTime2.Subtract(dateTime1);
                    if (diff.TotalMinutes < 15)
                    {
                        string morning = dateTime2.Hour >= 12 ? " PM " : " AM ";
                        // Here we show the reminder
                        MessageBox.Show("You have a meeting at " + dateTime2.Hour + morning + " with " + name + "!", "Appointment Reminder");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }

}

