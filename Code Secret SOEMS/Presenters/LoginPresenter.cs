using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public string getLoggedInOfficerPosition()
        {
            return _officer.getLoggedInOfficer("position");
        }

        public string getLoggedInOfficerName()
        {
            return _officer.getLoggedInOfficer("first_name");
        }
    }
}
