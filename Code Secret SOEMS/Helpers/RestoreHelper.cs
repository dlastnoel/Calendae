using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Secret_SOEMS.Helpers
{
    class RestoreHelper
    {
        public RestoreHelper(bool run)
        {
            if(run)
            {
                Properties.Settings.Default.theme = "Dark Orange";
                Properties.Settings.Default.isDark = false;
                Properties.Settings.Default.server = "localhost";
                Properties.Settings.Default.database = "calendae";
                Properties.Settings.Default.user = "root";
                Properties.Settings.Default.port = "3306";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.firstRun = true;
                Properties.Settings.Default.loginLock = false;
                Properties.Settings.Default.schoolName = "";
                Properties.Settings.Default.organization = "";
                Properties.Settings.Default.Save();

                MessageBox.Show("All settings reverted to default");
            } else
            {
                Properties.Settings.Default.theme = "Dark Orange";
                Properties.Settings.Default.isDark = false;
                Properties.Settings.Default.server = "localhost";
                Properties.Settings.Default.database = "calendae";
                Properties.Settings.Default.user = "root";
                Properties.Settings.Default.port = "3306";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.firstRun = false;
                Properties.Settings.Default.loginLock = false;
                Properties.Settings.Default.schoolName = "College of Information Technology";
                Properties.Settings.Default.organization = "Team Code Secret";
                Properties.Settings.Default.Save();

                MessageBox.Show("Adviser registration removed");
            }
        }
    }
}
