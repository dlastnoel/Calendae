using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Code_Secret_SOEMS.Models;

namespace Code_Secret_SOEMS.Presenters
{
    class AdviserRegistrationPresenter
    {
        Officer _officer = new Officer();

        public void setAdviser(string id, string position, string first_name, string middle_name, string last_name, 
            string address, string contact, string email, char gender, string course, string year_and_section, string password)
        {
            _officer.id = id;
            _officer.position = position;
            _officer.first_name = first_name;
            _officer.middle_name = middle_name;
            _officer.last_name = last_name;
            _officer.address = address;
            _officer.contact = contact;
            _officer.email = email;
            _officer.gender = gender;
            _officer.course = course;
            _officer.year_and_section = year_and_section;
            _officer.password = password;
        }

        public void addAdivser()
        {
            _officer.addOfficer();
        }
    }
}
