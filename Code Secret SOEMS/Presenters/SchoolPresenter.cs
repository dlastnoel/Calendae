using Code_Secret_SOEMS.Helpers;

namespace Code_Secret_SOEMS.Presenters
{
    class SchoolPresenter
    {
        private SettingsHelper sh;

        public SchoolPresenter()
        {
            sh = new SettingsHelper();
        }
        public void setSchoolName(string schoolName, string organization)
        {
            sh.setOrganization(schoolName, organization);
        }
    }
}
