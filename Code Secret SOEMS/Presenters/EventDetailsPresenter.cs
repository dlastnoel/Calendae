using System.Windows.Forms;
using Code_Secret_SOEMS.Models;

namespace Code_Secret_SOEMS.Presenters
{
    class EventDetailsPresenter
    {
        private Event _event;
        private Guest _guest;
        private EventDetails _eventDetails;

        public EventDetailsPresenter()
        {
            _event = new Event();
            _guest = new Guest();
            _eventDetails = new EventDetails();
        }

        public void loadStudentRegistrations(int event_id, DataGridView myDataGridview)
        {
            _eventDetails.loadStudentRegistrations(event_id, myDataGridview);
        }

        public void loadGuestRegistrations(int event_id, DataGridView myDataGridview)
        {
            _eventDetails.loadGuestRegistrations(event_id, myDataGridview);
        }

        public void populateEventDetails(int event_id, UserControl CtrlEventDetails, Label lblEventName, 
            Label lblDateAndTime, Label lblStudentSlots, Label lblStudentRegistrationFee, 
            Label lblGuestSlots, Label lblGuestRegistrationFee)
        {
            _event.selectEvent(event_id);
            lblEventName.Text = _event.getEventData("event_name");
            lblDateAndTime.Text = _event.getEventData("date_from") + " - " + _event.getEventData("date_to") +
                " @ " + _event.getEventData("time");
            if (_event.getEventData("student_slots") != "0")
            {
                lblStudentSlots.Text = "Slots Left: " + (int.Parse(_event.getEventData("student_slots")) -
                    _eventDetails.getRegisteredStudents(event_id)).ToString();
            }
            else
            {
                lblStudentSlots.Text = "Slots Left: Open";
            }
            if(_event.getEventData("student_registration") != "0")
            {
                lblStudentRegistrationFee.Text = "Registration Fee: Php " + _event.getEventData("student_registration");
            } else
            {
                lblStudentRegistrationFee.Text = "Registration Fee: Free";
            }
            if (_event.getEventData("guest_slots") != "0")
            {
                lblGuestSlots.Text = "Slots Left: " + (int.Parse(_event.getEventData("guest_slots")) -
                    _eventDetails.getRegisteredGuests(event_id)).ToString();
            }
            else
            {
                lblGuestSlots.Text = "Slots Left: Open";
            }
            if(_event.getEventData("guest_registration") != "0")
            {
                lblGuestRegistrationFee.Text = "Registration Fee: Php " + _event.getEventData("guest_registration");
            } else
            {
                lblGuestRegistrationFee.Text = "Registration Fee: Free";
            }
        }

        public void unregisterStudent(int event_id, string student_id)
        {
            _eventDetails.removeStudentParticipant(event_id, student_id);
        }

        public void unregisterGuest(int guest_id)
        {
            _eventDetails.removeGuestParticipant(guest_id);
        }

        public void registerGuest(int guest_id)
        {
            _guest.guestActivation(guest_id, 1);
        }
    }
}
