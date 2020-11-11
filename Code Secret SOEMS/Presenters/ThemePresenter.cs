using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code_Secret_SOEMS.Models;

namespace Code_Secret_SOEMS.Presenters
{
    class ThemePresenter
    {
        Theme _theme = new Theme();

        public string getCurrentTheme()
        {
            return _theme.getCurrentTheme();
        }

        public bool getCurrentMode()
        {
            return _theme.getCurrentMode();
        }

        public void applyTheme(string theme)
        {
            _theme.theme = theme;
            _theme.saveTheme();
        }

        public void applyMode(bool mode)
        {
            _theme.isDark = mode;
            _theme.saveMode();
        }

        public void applyBoth(string theme, bool mode)
        {
            _theme.theme = theme;
            _theme.isDark = mode;
            _theme.saveBoth();
        }
    }
}
