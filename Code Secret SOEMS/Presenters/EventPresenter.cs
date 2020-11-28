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

        public void setEvent(string event_name, string venue, string date, string time,
            int student_registration, int student_slots, string event_details, byte allow_guests, int guest_registration, int guest_slots, byte is_activated)
        {
            _event.event_name = event_name;
            _event.venue = venue;
            _event.date = date; ;
            _event.time = time;
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

        public void prepareEvent(int currentID, TextBox txtEventName, TextBox txtVenue, TextBox txtDate, TextBox txtTime,
            TextBox txtStudentRegistration, TextBox txtStudentSlots, TextBox txtEventDetails, CheckBox chkGuests, TextBox txtGuestRegistration, 
            TextBox txtGuestSlots, XUISwitch switchIsActivated, Label lblswitchStatus)
        {
            _event.selectEvent(currentID);
            txtEventName.Text = _event.getEventItems("event_name");
            txtVenue.Text = _event.getEventItems("venue");
            txtDate.Text = _event.getEventItems("date");
            txtTime.Text = _event.getEventItems("time");
            txtStudentRegistration.Text = _event.getEventItems("student_registration");
            txtStudentSlots.Text = _event.getEventItems("student_slots");
            txtEventDetails.Text = _event.getEventItems("event_details");
            if(bool.Parse(_event.getEventItems("allow_guests")) == true)
            {
                chkGuests.Checked = true;
            } else
            {
                chkGuests.Checked = false;
            }
            txtGuestRegistration.Text = _event.getEventItems("guest_registration");
            txtGuestSlots.Text = _event.getEventItems("guest_slots");
            if(bool.Parse(_event.getEventItems("is_activated")) == true)
            {
                switchIsActivated.SwitchState = XUISwitch.State.On;
                lblswitchStatus.Text = "Activated";
            } else
            {
                switchIsActivated.SwitchState = XUISwitch.State.Off;
                lblswitchStatus.Text = "Deactivated";
            }
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
