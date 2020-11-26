using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS.Models;

namespace Code_Secret_SOEMS.Presenters
{
    class OfficerPresenter
    {
        Officer _officer = new Officer();

        public void loadOfficers(DataGridView myDataGridview)
        {
            _officer.loadOfficers(myDataGridview);
        }

        public void setOfficer(string id, string position, string first_name, string middle_name, string last_name,
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

        public void addOfficer()
        {
            _officer.addOfficer();
        }

        public void prepareOfficer(string currentIDNo, TextBox txtIDNo, TextBox txtPosition, TextBox txtFirstName, TextBox txtMiddleName,
            TextBox txtLastName, TextBox txtAddress, TextBox txtContact, TextBox txtEmail, RadioButton rbnMale, RadioButton rbnFemale,
            TextBox txtCourse, TextBox txtYearAndSection)
        {
            _officer.selectOfficer(currentIDNo);
            txtIDNo.Text = _officer.getOfficerDetails("id");
            txtPosition.Text = _officer.getOfficerDetails("position");
            txtFirstName.Text = _officer.getOfficerDetails("first_name");
            txtMiddleName.Text = _officer.getOfficerDetails("middle_name");
            txtLastName.Text = _officer.getOfficerDetails("last_name");
            txtAddress.Text = _officer.getOfficerDetails("address");
            txtContact.Text = _officer.getOfficerDetails("contact");
            txtEmail.Text = _officer.getOfficerDetails("email");
            if (_officer.getOfficerDetails("gender") == "M")
            {
                rbnMale.Checked = true;
            }
            else
            {
                rbnFemale.Checked = true;
            }
            txtCourse.Text = _officer.getOfficerDetails("course");
            txtYearAndSection.Text = _officer.getOfficerDetails("year_and_section");
        }

        public void updateOfficer(string currentIDNo)
        {
            _officer.updateOfficer(currentIDNo);
        }

        public void deleteOfficer(string currentIDNo)
        {
            _officer.deleteOfficer(currentIDNo);
        }
    }
}
