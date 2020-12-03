using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS.Models;
using XanderUI;

namespace Code_Secret_SOEMS.Presenters
{
    class StudentPresenter
    {
        Student _student = new Student();

        public void loadStudents(DataGridView mydataGridView)
        {
            _student.loadStudents(mydataGridView);
        }

        public void setStudent(string id, string first_name, string middle_name, string last_name, string address, 
            string contact, string email, char gender, string course, string year_and_section, int is_activated)
        {
            _student.id = id;
            _student.first_name = first_name;
            _student.middle_name = middle_name;
            _student.last_name = last_name;
            _student.address = address;
            _student.contact = contact;
            _student.email = email;
            _student.gender = gender;
            _student.course = course;
            _student.year_and_section = year_and_section;
            _student.is_activated = is_activated;
        }

        public void addStudent()
        {
            _student.addStudent();
        }
        public void studentActivation(string currentID, XUISwitch switchIsActivated, Label lblSwitchStatus)
        {
            if (switchIsActivated.SwitchState == XUISwitch.State.On)
            {
                _student.activateStudent(currentID);
                lblSwitchStatus.Text = "Activated";
            }
            else
            {
                _student.deactivateStudent(currentID);
                lblSwitchStatus.Text = "Deactivated";
            }
        }

        public void prepareStudent(string currentID, TextBox txtFirstName, TextBox txtMiddleName, TextBox txtLastName,
            TextBox txtAddress, TextBox txtContact, TextBox txtEmailAddress, RadioButton rbnMale, RadioButton rbnFemale,
            TextBox txtIDNo, TextBox txtCourse, TextBox txtYearAndSection, XUISwitch switchIsActivated, Label lblSwitchStatus)
        {
            _student.selectStudent(currentID);
            txtIDNo.Text = _student.getStudentDetails("id");
            txtFirstName.Text = _student.getStudentDetails("first_name");
            txtMiddleName.Text = _student.getStudentDetails("middle_name");
            txtLastName.Text = _student.getStudentDetails("last_name");
            txtAddress.Text = _student.getStudentDetails("address");
            txtContact.Text = _student.getStudentDetails("contact");
            txtEmailAddress.Text = _student.getStudentDetails("email");
            if(_student.getStudentDetails("gender") == "M")
            {
                rbnMale.Checked = true;
            } else
            {
                rbnFemale.Checked = false;
            }
            txtCourse.Text = _student.getStudentDetails("course");
            txtYearAndSection.Text = _student.getStudentDetails("year_and_section");
            if (bool.Parse(_student.getStudentDetails("is_activated")) == true)
            {
                switchIsActivated.SwitchState = XUISwitch.State.On;
                lblSwitchStatus.Text = "Activated";
            }
            else
            {
                switchIsActivated.SwitchState = XUISwitch.State.Off;
                lblSwitchStatus.Text = "Deactivated";
            }
        }

        public void updateStudent(string currentID)
        {
            _student.updateStudent(currentID);
        }

        public void deleteStudent(string currentID)
        {
            _student.deleteStudent(currentID);
        }
    }
}
