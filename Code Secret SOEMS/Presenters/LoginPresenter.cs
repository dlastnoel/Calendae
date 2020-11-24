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
        Officer _officer = new Officer();

        public string loginOfficer(string id, string password)
        {
            if(_officer.loginOfficer(id, password))
            {
                
                return _officer.getLoggedInOfficer();
            } else
            {
                return "";
            }
        }
    }
}
