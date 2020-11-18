using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Secret_SOEMS.Models
{
    class Theme
    {
        // Properties
        public string theme { get; set; }
        public bool isDark { get; set; }

        // Methods
        public string getCurrentTheme()
        {
            return Properties.Settings.Default.theme;
        }

        public bool getCurrentMode()
        {
            return Properties.Settings.Default.isDark;
        }

        public void saveTheme()
        {
            Properties.Settings.Default.theme = theme;
            Properties.Settings.Default.Save();
        }

        public void saveMode()
        {
            Properties.Settings.Default.isDark = isDark;
            Properties.Settings.Default.Save();
        }

        public void saveBoth()
        {
            Properties.Settings.Default.theme = theme;
            Properties.Settings.Default.isDark = isDark;
            Properties.Settings.Default.Save();
        }
    }
}
