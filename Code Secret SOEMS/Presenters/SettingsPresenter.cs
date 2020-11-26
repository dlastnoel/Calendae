using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code_Secret_SOEMS.Helpers;

namespace Code_Secret_SOEMS.Presenters
{
    class SettingsPresenter
    {
        SettingsHelper sh = new SettingsHelper();
        ThemeHelper th = new ThemeHelper();
        public string getCurrentTheme()
        {
            return th.getCurrentTheme();
        }

        public bool getCurrentMode()
        {
            return th.isDark();
        }

        public void applyTheme(string theme)
        {
            th.saveTheme(theme);
        }

        public void applyMode(bool mode)
        {
            th.saveMode(mode);
        }
        public bool isLoginLocked()
        {
            return sh.isLoginLocked();
        }

        public void applyBoth(string theme, bool mode)
        {
            th.saveBoth(theme, mode);
        }
        public void enableLoginLock(byte minutes)
        {
            sh.enableLoginLock(minutes);
        }

        // Disables login lock
        public void disableLoginLock()
        {
            sh.disableLoginLock();
        }

    }
}
