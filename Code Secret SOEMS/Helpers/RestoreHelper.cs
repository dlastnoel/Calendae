using System.Windows.Forms;

namespace Code_Secret_SOEMS.Helpers
{
    //Helper class useful for resetting property settings when debugging
    class RestoreHelper
    {
        public RestoreHelper(string mode)
        {
            //Resets the entire property settings
            if(mode == "all")
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
            } 
            // Skips the adviser and school registration
            else if(mode == "super")
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
                Properties.Settings.Default.schoolName = "";
                Properties.Settings.Default.organization = "";
                Properties.Settings.Default.Save();

                MessageBox.Show("Adviser registration removed");
            } 
            // Removes the lock property settings
            else
            {
                Properties.Settings.Default.lockStatus = false;
                Properties.Settings.Default.loginLock = false;
                Properties.Settings.Default.Save();

                MessageBox.Show("Lock removed");
            }
        }
    }
}
