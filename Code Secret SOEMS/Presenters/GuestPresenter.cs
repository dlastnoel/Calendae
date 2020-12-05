using System;
using System.Windows.Forms;
using XanderUI;
using Code_Secret_SOEMS.Models;

namespace Code_Secret_SOEMS.Presenters
{
    class GuestPresenter
    {
        private Guest _guest;
        private Event _event;
        private EventDetails _eventDetails;

        public GuestPresenter()
        {
            _guest = new Guest();
            _event = new Event();
            _eventDetails = new EventDetails();
        }
        public void loadGuests(DataGridView mydataGridView)
        {
            _guest.loadGuests(mydataGridView);
        }

        public void searchGuests(string name, DataGridView myDataGridView)
        {
            _guest.searchGuests(name, myDataGridView);
        }

        public void setEvents(ComboBox cmbEvents)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = _event.getAllGuestAllowedActiveEvents();
            cmbEvents.DataSource = bindingSource;
            cmbEvents.SelectedIndex = -1;
        }

        public int eventID(string event_name)
        {
            _event.selectEventByName(event_name);
            return int.Parse(_event.getEventData("id"));
        }

        public string getEventName(int currentID)
        {
            _event.selectEvent(currentID);
            return _event.getEventData("event_name");
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

        public string getCode()
        {
            _guest.selectGuest(_guest.getLastGuestID());
            return _guest.getGuestData("code");
        }

        public void registerGuest()
        {
            _eventDetails.event_id = _guest.event_id;
            _eventDetails.guest_id = _guest.getLastGuestID();
            _eventDetails.addGuestParticipant();
        }

        public void deactivateGuest(int guest_id)
        {
            _guest.guestActivation(guest_id, 0);
        }

        public void prepareGuest(int currentID, RadioButton rbnstudent, RadioButton rbnWorking, TextBox txtFirstName, 
            TextBox txtMiddleName, TextBox txtLastName, TextBox txtAddress, TextBox txtContact, TextBox txtEmail,
            RadioButton rbnMale, RadioButton rbnFemale, TextBox txtSchoolName, TextBox txtCourse, TextBox txtYear,
            TextBox txtWorksAt, TextBox txtPosition, XUISwitch switchIsActivated, Label lblSwitchStatus, ComboBox cmbEvents)
        {
            _guest.selectGuest(currentID);
            txtFirstName.Text = _guest.getGuestData("first_name");
            txtMiddleName.Text = _guest.getGuestData("middle_name");
            txtLastName.Text = _guest.getGuestData("last_name");
            txtAddress.Text = _guest.getGuestData("address");
            txtContact.Text = _guest.getGuestData("contact");
            txtEmail.Text = _guest.getGuestData("email");
            if(_guest.getGuestData("gender") == "M")
            {
                rbnMale.Checked = true;
            } else
            {
                rbnFemale.Checked = true;
            }
            if(!String.IsNullOrEmpty(_guest.getGuestData("school_name")))
            {
                rbnstudent.Checked = true;
            } else
            {
                rbnWorking.Checked = true;
            }
            txtSchoolName.Text = _guest.getGuestData("school_name");
            txtCourse.Text = _guest.getGuestData("course");
            txtYear.Text = _guest.getGuestData("year");
            txtWorksAt.Text = _guest.getGuestData("works_at");
            txtPosition.Text = _guest.getGuestData("position");
            if(bool.Parse(_guest.getGuestData("is_activated")) == true)
            {
                switchIsActivated.SwitchState = XUISwitch.State.On;
                lblSwitchStatus.Text = "Activated";
            } else
            {
                switchIsActivated.SwitchState = XUISwitch.State.Off;
                lblSwitchStatus.Text = "Deactivated";
            }
            cmbEvents.SelectedIndex = cmbEvents.FindStringExact(_guest.getGuestData("event_name"));
        }

        public void guestActivation(int currentID, XUISwitch switchIsActivated, Label lblSwitchStatus)
        {
            if (switchIsActivated.SwitchState == XUISwitch.State.On)
            {
                _guest.guestActivation(currentID, 1);
                lblSwitchStatus.Text = "Activated";
            }
            else
            {
                _guest.guestActivation(currentID, 0);
                lblSwitchStatus.Text = "Deactivated";
            }
        }
        public void updateGuest(int currentID)
        {
            _guest.updateGuest(currentID);
        }

        public void deleteGuest(int currentID)
        {
            _guest.deleteGuest(currentID);
        }
    }
}
