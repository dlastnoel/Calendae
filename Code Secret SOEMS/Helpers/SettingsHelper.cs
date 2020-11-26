using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Secret_SOEMS.Helpers
{
    class SettingsHelper
    {
        // Sets organization infos
        // School name
        // Organization name
        public void setOrganization(string schoolName, string organization)
        {
            Properties.Settings.Default.schoolName = schoolName;
            Properties.Settings.Default.organization = organization;
            Properties.Settings.Default.Save();
        }

        // Test if system run is first
        // Returns result as bool
        public bool isFirstRun()
        {
            return Properties.Settings.Default.firstRun;
        }

        // Disables first run
        public void disableFirstRun()
        {
            Properties.Settings.Default.firstRun = false;
            Properties.Settings.Default.Save();
        }

        // Test if login lock is on
        // Returns result as bool
        public bool isLoginLocked()
        {
            return Properties.Settings.Default.loginLock;
        }

        // Enables login lock
        public void enableLoginLock(byte minutes)
        {
            Properties.Settings.Default.loginLock = true;
            Properties.Settings.Default.minutes = minutes;
            Properties.Settings.Default.Save();
        }

        // Disables login lock
        public void disableLoginLock()
        {
            Properties.Settings.Default.loginLock = false;
            Properties.Settings.Default.Save();
        }

        // Sets db default connection settings
        public void setDefaultConnectionSettings()
        {
            Properties.Settings.Default.server = "localhost";
            Properties.Settings.Default.user = "root";
            Properties.Settings.Default.port = "3306";
            Properties.Settings.Default.password = "";
            Properties.Settings.Default.Save();
        }

        // Sets new db connection settings
        public void setConnectionSettings(string server, string user, string port, string password)
        {
            Properties.Settings.Default.server = server;
            Properties.Settings.Default.user = user;
            Properties.Settings.Default.port = port;
            Properties.Settings.Default.password = password;
            Properties.Settings.Default.Save();
        }
    }
}
