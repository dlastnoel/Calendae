using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Secret_SOEMS.Presenters
{
    class DashboardPresenter
    {
        public string getSchoolName()
        {
            return "School: " + Properties.Settings.Default.schoolName;
        }

        public string getOrganization()
        {
            return "Organization: " + Properties.Settings.Default.organization;
        }
    }
}
