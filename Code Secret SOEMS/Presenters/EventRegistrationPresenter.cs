using System.Windows.Forms;
using Code_Secret_SOEMS.Models;

namespace Code_Secret_SOEMS.Presenters
{
    class EventRegistrationPresenter
    {
        public int event_id { get; set; }
        public string student_id { get; set; }
        public int guest_id { get; set; }
        public int student_slots { get; set; }
        public int guest_slots { get; set; }

        private Guest _guest;
        private Event _event;
        private EventDetails _eventDetails;

        public EventRegistrationPresenter()
        {
            _guest = new Guest();
            _event = new Event();
            _eventDetails = new EventDetails();
        }
        public string getSchoolName()
        {
            return Properties.Settings.Default.schoolName;
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
            return int.Parse(_event.getEventData("id"));
        }

        public int getStudentSlots()
        {
            return student_slots;
        }

        public int getGuestSlots()
        {
            return guest_slots;
        }

        public void prepareEvent(ComboBox cmbEvents, Panel panelEvents, Label lblEventName, Label lblVenue, Label lblDate,
            Label lblTime, TextBox txtEventDetails, Panel panelStudentRegistration, Label lblStudentSlots, Label lblStudentRegistrationFee,
            Panel panelGuestRegistration, Label lblGuestSlots, Label lblGuestRegistrationFee)
        {
            event_id = eventID(cmbEvents.Text);
            lblEventName.Text = cmbEvents.Text;
            lblEventName.Left = (panelEvents.Width - lblEventName.Width) / 2;
            lblVenue.Text = "Venue: " + _event.getEventData("venue");
            lblDate.Text = "Date: " + _event.getEventData("date_from") + " - " + _event.getEventData("date_to");
            lblTime.Text = "Time: " + _event.getEventData("time");
            txtEventDetails.Text = _event.getEventData("event_details");
            student_slots = int.Parse(_event.getEventData("student_slots"));
            panelStudentRegistration.Enabled = true;
            if (student_slots != 0)
            {
                if (int.Parse(_event.getEventData("student_slots")) - _eventDetails.getRegisteredStudents(int.Parse(_event.getEventData("id"))) != 0)
                {
                    lblStudentSlots.Text = "Slots Left: " + (int.Parse(_event.getEventData("student_slots")) -
                        _eventDetails.getRegisteredStudents(int.Parse(_event.getEventData("id")))).ToString();
                }
                else
                {
                    lblStudentSlots.Text = "All slots have been taken";
                    panelStudentRegistration.Enabled = false;
                }
            }
            else
            {
                lblStudentSlots.Text = "Slots Left: Open";
            }
            if (_event.getEventData("student_registration") == "0")
            {
                lblStudentRegistrationFee.Text = "Registration Fee: Free";
            }
            else
            {
                lblStudentRegistrationFee.Text = "Registation Fee: Php " + _event.getEventData("student_registration");
            }
            if (bool.Parse(_event.getEventData("allow_guests")))
            {
                panelGuestRegistration.Enabled = true;
                guest_slots = int.Parse(_event.getEventData("guest_slots"));
                if (guest_slots != 0)
                {
                    if (int.Parse(_event.getEventData("guest_slots")) -
                    _eventDetails.getRegisteredGuests(int.Parse(_event.getEventData("id"))) != 0)
                    {
                        lblGuestSlots.Text = "Slots Left: " + (int.Parse(_event.getEventData("guest_slots")) -
                        _eventDetails.getRegisteredGuests(int.Parse(_event.getEventData("id")))).ToString();
                    }
                    else
                    {
                        lblGuestSlots.Text = "All slots have been taken";
                        panelStudentRegistration.Enabled = false;
                    }
                }
                else
                {
                    lblGuestSlots.Text = "Slots Left: Open";
                }
                if (_event.getEventData("guest_registration") == "0")
                {
                    lblGuestRegistrationFee.Text = "Registration Fee: Free";
                }
                else
                {
                    lblGuestRegistrationFee.Text = "Registation Fee: Php " + _event.getEventData("student_registration");
                }
            }
            else
            {
                panelGuestRegistration.Enabled = false;
                lblGuestSlots.Text = "Slots Left: ";
                lblGuestRegistrationFee.Text = "Registration Fee: ";
            }
        }

        public int registerStudent(string student_id)
        {
            _eventDetails.event_id = event_id;
            _eventDetails.student_id = student_id;
            return _eventDetails.addStudentParticipant();
        }

        public void unregisterStudent(string student_id)
        {
            _eventDetails.removeStudentParticipant(event_id, student_id);
        }
        public string getGuestFullName()
        {
            return _eventDetails.getEventDetails("first_name") + " " + _eventDetails.getEventDetails("middle_name") + " " +
                _eventDetails.getEventDetails("last_name");
        }
        public int checkGuestRegistration(string code)
        {
            _eventDetails.event_id = event_id;
            return _eventDetails.selectGuestByCode(code);
        }

    }
}