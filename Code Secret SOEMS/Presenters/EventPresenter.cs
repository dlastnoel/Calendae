using System;
using System.Windows.Forms;
using XanderUI;
using Code_Secret_SOEMS.Models;

namespace Code_Secret_SOEMS.Presenters
{
    class EventPresenter
    {
        private Event _event;
        
        public EventPresenter()
        {
            _event = new Event();
        }

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

        public void searchEvents(string event_name, DataGridView myDataGridView)
        {
            _event.searchEvents(event_name, myDataGridView);
        }
        public void addEvent()
        {
            _event.addEvent();
        }

        public bool checkEventStatus(int event_id)
        {
            _event.selectEvent(event_id);
            return bool.Parse(_event.getEventData("is_activated"));
            
        }

        public void eventActivation(int event_id, XUISwitch switchIsActivated, Label lblSwitchStatus)
        {
            if(switchIsActivated.SwitchState == XUISwitch.State.On)
            {
                _event.eventActivation(event_id, 1);
                lblSwitchStatus.Text = "Activated";
            } else
            {
                _event.eventActivation(event_id, 0);
                lblSwitchStatus.Text = "Activated";
            }
        }


        public void prepareEvent(int event_id, TextBox txtEventName, TextBox txtVenue, DateTimePicker dateFrom, 
            DateTimePicker dateTo, DateTimePicker timeFrom, DateTimePicker timeTo, TextBox txtStudentRegistration, TextBox txtStudentSlots,
            TextBox txtEventDetails, CheckBox chkGuests, TextBox txtGuestRegistration, TextBox txtGuestSlots, 
            XUISwitch switchIsActivated, Label lblSwitchStatus)
        {
            _event.selectEvent(event_id);
            txtEventName.Text = _event.getEventData("event_name");
            txtVenue.Text = _event.getEventData("venue");
            dateFrom.Value = Convert.ToDateTime(_event.getEventData("date_from"));
            dateTo.Value = Convert.ToDateTime(_event.getEventData("date_to"));
            string[] times = _event.getEventData("time").Split(new string[] {" - "}, StringSplitOptions.None);
            timeFrom.Value = Convert.ToDateTime(times[0]);
            timeTo.Value = Convert.ToDateTime(times[1]);
            txtStudentRegistration.Text = _event.getEventData("student_registration");
            txtStudentSlots.Text = _event.getEventData("student_slots");
            txtEventDetails.Text = _event.getEventData("event_details");
            if(bool.Parse(_event.getEventData("allow_guests")) == true)
            {
                chkGuests.Checked = true;
                txtGuestRegistration.Text = _event.getEventData("guest_registration");
                txtGuestSlots.Text = _event.getEventData("guest_slots");
            } else
            {
                chkGuests.Checked = false;
            }
            if(bool.Parse(_event.getEventData("is_activated")) == true)
            {
                switchIsActivated.SwitchState = XUISwitch.State.On;
                lblSwitchStatus.Text = "Activated";
            } else
            {
                switchIsActivated.SwitchState = XUISwitch.State.Off;
                lblSwitchStatus.Text = "Deactivated";
            }
        }

        public void updateEvent(int event_id)
        {
            _event.updateEvent(event_id);
        }

        public void deleteEvent(int event_id)
        {
            _event.deleteEvent(event_id);
        }
    }

}
