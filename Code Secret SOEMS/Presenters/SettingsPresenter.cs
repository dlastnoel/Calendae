using Code_Secret_SOEMS.Helpers;

namespace Code_Secret_SOEMS.Presenters
{
    class SettingsPresenter
    {
        private SettingsHelper sh = new SettingsHelper();
        private ThemeHelper th = new ThemeHelper();

        public SettingsPresenter()
        {
            sh = new SettingsHelper();
            th = new ThemeHelper();
        }
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
            th.saveTheme(theme, false);
        }

        public void applyMode(bool mode)
        {
            th.saveTheme("", mode);
        }
        public bool isLoginLocked()
        {
            return sh.isLoginLocked();
        }

        public string getMinutes()
        {
            return sh.getMinutes();
        }

        public void applyBoth(string theme, bool mode)
        {
            th.saveTheme(theme, mode);
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
