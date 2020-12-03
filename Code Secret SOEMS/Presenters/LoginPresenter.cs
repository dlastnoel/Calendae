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

        public string getOfficerPosition()
        {
            return _officer.getOfficerDetails("position");
        }

        public string getOfficerName()
        {
            return _officer.getOfficerDetails("first_name");
        }

        public string getOfficerId()
        {
            return _officer.getOfficerDetails("id");
        }
    }
}
