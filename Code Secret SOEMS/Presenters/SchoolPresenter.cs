using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code_Secret_SOEMS.Helpers;

namespace Code_Secret_SOEMS.Presenters
{
    class SchoolPresenter
    {
        SettingsHelper sh = new SettingsHelper();
        public void setSchoolName(string schoolName, string organization)
        {
            sh.setOrganization(schoolName, organization);
        }
    }
}
