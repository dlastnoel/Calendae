using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Secret_SOEMS.Helpers
{
    class SettingsHelper
    {
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

        public bool isSchooSet()
        {
            if (!String.IsNullOrEmpty(Properties.Settings.Default.schoolName))
            {
                return true;
            } else
            {
                return false;
            }
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

        // Test if login is locked
        // Returns result as bool
        public bool isLocked()
        {
            return Properties.Settings.Default.lockStatus;
        }

        //Locks the lock status of login
        public void lockLogin()
        {
            Properties.Settings.Default.lockStatus = true;
            Properties.Settings.Default.Save();
        }
        
        // Unlocks the lock status of login
        public void unlockLogin()
        {
            Properties.Settings.Default.lockStatus = false;
            Properties.Settings.Default.Save();
        }

        // Disables login lock
        public void disableLoginLock()
        {
            Properties.Settings.Default.loginLock = false;
            Properties.Settings.Default.Save();
        }

        // Gets the minutes of the lock
        // Returns as string
        public string getMinutes()
        {
            return Properties.Settings.Default.minutes.ToString();
        }

        // Enables login lock
        public void enableLoginLock(byte minutes)
        {
            Properties.Settings.Default.loginLock = true;
            Properties.Settings.Default.minutes = minutes;
            Properties.Settings.Default.Save();
        }

        // Gets the notes for the dashboard
        public string getNotes()
        {
            return Properties.Settings.Default.notes;
        }

        // Sets the notes from the dashboard
        public void saveNotes(string notes)
        {
            Properties.Settings.Default.notes = notes;
            Properties.Settings.Default.Save();
        }
    }
}
