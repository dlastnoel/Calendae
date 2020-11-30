using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS.Models;

namespace Code_Secret_SOEMS.Presenters
{
    class EventDetailsPresenter
    {
        Event _event = new Event();
        EventDetails _eventDetails = new EventDetails();

        public void loadStudentRegistrations(int event_id, DataGridView myDataGridview)
        {
            _eventDetails.loadStudentRegistrations(event_id, myDataGridview);
        }

        public void loadGuestRegistrations(int event_id, DataGridView myDataGridview)
        {
            _eventDetails.loadGuestRegistrations(event_id, myDataGridview);
        }

        public void populateEventDetails(int event_id, Label lblEventName, Label lblDateAndTime, Label lblStudentSlots,
            Label lblStudentRegistrationFee, Label lblGuestSlots, Label lblGuestRegistrationFee)
        {
            _event.selectEvent(event_id);
            lblEventName.Text = _event.getEventItems("event_name");
            lblDateAndTime.Text = _event.getEventItems("date") + " at " + _event.getEventItems("time");
            if (_event.getEventItems("student_slots") != "0")
            {
                lblStudentSlots.Text = "Slots Left: " + (int.Parse(_event.getEventItems("student_slots")) -
                    _eventDetails.getRegisteredStudents(event_id)).ToString();
            }
            else
            {
                lblStudentSlots.Text = "Slots Left: Open";
            }
            if(_event.getEventItems("student_registration") != "0")
            {
                lblStudentRegistrationFee.Text = "Registration Fee: Php " + _event.getEventItems("student_registration");
            } else
            {
                lblStudentRegistrationFee.Text = "Registration Fee: Free";
            }
            if (_event.getEventItems("guest_slots") != "0")
            {
                lblGuestSlots.Text = "Slots Left: " + (int.Parse(_event.getEventItems("guest_slots")) -
                    _eventDetails.getRegisteredGuests(event_id)).ToString();
            }
            else
            {
                lblGuestSlots.Text = "Slots Left: Open";
            }
            if(_event.getEventItems("guest_registration") != "0")
            {
                lblGuestRegistrationFee.Text = "Registration Fee: Php " + _event.getEventItems("guest_registration");
            } else
            {
                lblGuestRegistrationFee.Text = "Registration Fee: Free";
            }
        }
    }
}
