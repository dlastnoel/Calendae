using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XanderUI;
using XanderUI.Designers;
using Code_Secret_SOEMS.Models;

namespace Code_Secret_SOEMS.Presenters
{
    class GuestPresenter
    {
        Guest _guest = new Guest();
        Event _event = new Event();

        public void loadGuests(DataGridView mydataGridView)
        {
            _guest.loadGuests(mydataGridView);
        }

        public void setEvents(ComboBox cmbEvents)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = _event.getAllActiveEvents();
            cmbEvents.DataSource = bindingSource;
            cmbEvents.SelectedIndex = -1;
        }

        public int eventID(string event_name)
        {
            _event.selectEventByName(event_name);
            return int.Parse(_event.getEventItems("id"));
        }

        public string getEventName(int currentID)
        {
            _event.selectEvent(currentID);
            return _event.getEventItems("event_name");
        }

        public void setGuest(string first_name, string middle_name, string last_name, string address, string contact, 
            string email, char gender, string school_name, string course, string year, string works_at, string position, 
            bool is_activated, string event_name)
        {
            _guest.first_name = first_name;
            _guest.middle_name = middle_name;
            _guest.last_name = last_name;
            _guest.address = address;
            _guest.contact = contact;
            _guest.email = email;
            _guest.gender = gender;
            _guest.school_name = school_name;
            _guest.course = course;
            _guest.year = year;
            _guest.works_at = works_at;
            _guest.position = position;
            _guest.is_activated = is_activated;
            _guest.event_id = this.eventID(event_name);
        }

        public void addGuest()
        {
            _guest.addGuest();
        }

        public void prepareGuest(int currentID, RadioButton rbnstudent, RadioButton rbnWorking, TextBox txtFirstName, 
            TextBox txtMiddleName, TextBox txtLastName, TextBox txtAddress, TextBox txtContact, TextBox txtEmail,
            RadioButton rbnMale, RadioButton rbnFemale, TextBox txtSchoolName, TextBox txtCourse, TextBox txtYear,
            TextBox txtWorksAt, TextBox txtPosition, ComboBox cmbEvents)
        {
            _guest.selectGuest(currentID);
            txtFirstName.Text = _guest.getGuestDetails("first_name");
            txtMiddleName.Text = _guest.getGuestDetails("middle_name");
            txtLastName.Text = _guest.getGuestDetails("last_name");
            txtAddress.Text = _guest.getGuestDetails("address");
            txtContact.Text = _guest.getGuestDetails("contact");
            txtEmail.Text = _guest.getGuestDetails("email");
            if(_guest.getGuestDetails("gender") == "M")
            {
                rbnMale.Checked = true;
            } else
            {
                rbnFemale.Checked = true;
            }
            if(!String.IsNullOrEmpty(_guest.getGuestDetails("school_name")))
            {
                rbnstudent.Checked = true;
            } else
            {
                rbnWorking.Checked = true;
            }
            txtSchoolName.Text = _guest.getGuestDetails("school_name");
            txtCourse.Text = _guest.getGuestDetails("course");
            txtYear.Text = _guest.getGuestDetails("year");
            txtWorksAt.Text = _guest.getGuestDetails("works_at");
            txtPosition.Text = _guest.getGuestDetails("position");
            cmbEvents.SelectedIndex = cmbEvents.FindStringExact(_guest.getGuestDetails("event_name"));
        }
        public void updateGuest(int currentID)
        {
            _guest.updateGuest(currentID);
        }

        public void deleteEvent(int currentID)
        {
            _guest.deleteGuest(currentID);
        }
    }
}
