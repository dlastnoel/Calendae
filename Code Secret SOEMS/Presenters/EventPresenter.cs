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
    class EventPresenter
    {
        Event _event = new Event();

        public void loadEvents(DataGridView mydataGridView)
        {
            _event.loadEvents(mydataGridView);
        }

        public void setEvent(string event_name, string venue, string date_from, string date_to, string time_from,
            string time_to, int student_registration, int student_slots, string event_details, bool allow_guests, 
            int guest_registration, int guest_slots, bool is_activated)
        {
            _event.event_name = event_name;
            _event.venue = venue;
            _event.date_from = date_from;
            _event.date_to = date_to;
            _event.time = time_from + " - " + time_to;
            _event.student_registration = student_registration;
            _event.student_slots = student_slots;
            _event.event_details = event_details;
            _event.allow_guests = allow_guests;
            _event.guest_registration = guest_registration;
            _event.guest_slots = guest_slots;
            _event.is_activated = is_activated;
        }

        public void addEvent()
        {
            _event.addEvent();
        }

        public bool checkEventStatus(int currentID)
        {
            _event.selectEvent(currentID);
            return bool.Parse(_event.getEventItems("is_activated"));
            
        }

        public void eventActivation(int currentID, XUISwitch switchIsActivated, Label lblSwitchStatus)
        {
            if(switchIsActivated.SwitchState == XUISwitch.State.On)
            {
                _event.activateEvent(currentID);
                lblSwitchStatus.Text = "Activated";
            } else
            {
                _event.deactivateEvent(currentID);
                lblSwitchStatus.Text = "Activated";
            }
        }


        public bool prepareEvent(int currentID, TextBox txtEventName, TextBox txtVenue, DateTimePicker dateFrom, 
            DateTimePicker dateTo, DateTimePicker timeFrom, DateTimePicker timeTo, TextBox txtStudentRegistration, TextBox txtStudentSlots,
            TextBox txtEventDetails, CheckBox chkGuests, TextBox txtGuestRegistration, TextBox txtGuestSlots, 
            XUISwitch switchIsActivated, Label lblSwitchStatus)
        {
            bool activation;
            _event.selectEvent(currentID);
            txtEventName.Text = _event.getEventItems("event_name");
            txtVenue.Text = _event.getEventItems("venue");
            dateFrom.Value = Convert.ToDateTime(_event.getEventItems("date_from"));
            dateTo.Value = Convert.ToDateTime(_event.getEventItems("date_to"));
            string[] times = _event.getEventItems("time").Split(new string[] {" - "}, StringSplitOptions.None);
            timeFrom.Value = Convert.ToDateTime(times[0]);
            timeTo.Value = Convert.ToDateTime(times[1]);
            txtStudentRegistration.Text = _event.getEventItems("student_registration");
            txtStudentSlots.Text = _event.getEventItems("student_slots");
            txtEventDetails.Text = _event.getEventItems("event_details");
            if(bool.Parse(_event.getEventItems("allow_guests")) == true)
            {
                chkGuests.Checked = true;
                txtGuestRegistration.Text = _event.getEventItems("guest_registration");
                txtGuestSlots.Text = _event.getEventItems("guest_slots");
            } else
            {
                chkGuests.Checked = false;
            }
            if(bool.Parse(_event.getEventItems("is_activated")) == true)
            {
                activation = true;
                switchIsActivated.SwitchState = XUISwitch.State.On;
                lblSwitchStatus.Text = "Activated";
            } else
            {
                activation = false;
                switchIsActivated.SwitchState = XUISwitch.State.Off;
                lblSwitchStatus.Text = "Deactivated";
            }

            return activation;
        }

        public void updateEvent(int currentID)
        {
            _event.updateEvent(currentID);
        }

        public void deleteEvent(int currentID)
        {
            _event.deleteEvent(currentID);
        }
    }

}
