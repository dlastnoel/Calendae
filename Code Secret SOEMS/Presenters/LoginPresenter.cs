using Code_Secret_SOEMS.Models;

namespace Code_Secret_SOEMS.Presenters
{
    class LoginPresenter
    {
        private Officer _officer;

        public LoginPresenter()
        {
            _officer = new Officer();
        }

        public bool loginOfficer(string id, string password)
        {
            return _officer.loginOfficer(id, password);
        }

        public string getOfficerPosition()
        {
            return _officer.getOfficerData("position");
        }

        public string getOfficerName()
        {
            return _officer.getOfficerData("first_name");
        }
    }
}
