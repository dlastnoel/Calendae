using System.Windows.Forms;
using Code_Secret_SOEMS.Models;
using XanderUI;

namespace Code_Secret_SOEMS.Presenters
{
    class StudentPresenter
    {
        private Student _student;

        public StudentPresenter()
        {
            _student = new Student();
        }

        public void loadStudents(DataGridView mydataGridView)
        {
            _student.loadStudents(mydataGridView);
        }

        public void searchStudents(string search, DataGridView myDataGridView)
        {
            _student.searchStudents(search, myDataGridView);
        }

        public void setStudent(string id, string first_name, string middle_name, string last_name, string address, 
            string contact, string email, char gender, string course, string year_and_section, bool is_activated)
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
                _student.studentActivation(currentID, 1);
                lblSwitchStatus.Text = "Activated";
            }
            else
            {
                _student.studentActivation(currentID, 0);
                lblSwitchStatus.Text = "Deactivated";
            }
        }

        public void prepareStudent(string currentID, TextBox txtFirstName, TextBox txtMiddleName, TextBox txtLastName,
            TextBox txtAddress, TextBox txtContact, TextBox txtEmailAddress, RadioButton rbnMale, RadioButton rbnFemale,
            TextBox txtIDNo, TextBox txtCourse, TextBox txtYearAndSection, XUISwitch switchIsActivated, Label lblSwitchStatus)
        {
            _student.selectStudent(currentID);
            txtIDNo.Text = _student.getStudentData("id");
            txtFirstName.Text = _student.getStudentData("first_name");
            txtMiddleName.Text = _student.getStudentData("middle_name");
            txtLastName.Text = _student.getStudentData("last_name");
            txtAddress.Text = _student.getStudentData("address");
            txtContact.Text = _student.getStudentData("contact");
            txtEmailAddress.Text = _student.getStudentData("email");
            if(_student.getStudentData("gender") == "M")
            {
                rbnMale.Checked = true;
            } else
            {
                rbnFemale.Checked = false;
            }
            txtCourse.Text = _student.getStudentData("course");
            txtYearAndSection.Text = _student.getStudentData("year_and_section");
            if (bool.Parse(_student.getStudentData("is_activated")) == true)
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
