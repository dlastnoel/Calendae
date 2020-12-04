using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS.Helpers;
using Code_Secret_SOEMS.Models;

namespace Code_Secret_SOEMS.Presenters
{
    class DashboardPresenter
    {
        Event _event = new Event();
        EventDetails _eventDetails = new EventDetails();
        Student _student = new Student();
        Guest _guest = new Guest();
        Officer _officer = new Officer();
        SettingsHelper sh = new SettingsHelper();

        public string getSchoolName()
        {
            return "School: " + Properties.Settings.Default.schoolName;
        }

        public string getOrganization()
        {
            return "Organization: " + Properties.Settings.Default.organization;
        }

        public void setAdviser(Label lblAdviser)
        {
            lblAdviser.Text  = "Adviser: " + _officer.getAdviser();
        }

        public void setDashboardTile(Label lblActiveEvents, Label lblStudentsRegistered, Label lblGuestsRegistered)
        {
            lblActiveEvents.Text = _event.countAllActiveEvents().ToString();
            lblStudentsRegistered.Text = _student.countAllStudents().ToString();
            lblGuestsRegistered.Text = _guest.countAllGuestsRegistered().ToString();
            if (_student.countAllStudents() > 99)
            {
                lblStudentsRegistered.Font = new Font("Roboto", 60, FontStyle.Regular);
                lblStudentsRegistered.Location = new Point(-5, 11);
            }
            if(_guest.countAllGuestsRegistered() > 99)
            {
                lblGuestsRegistered.Font = new Font("Roboto", 60, FontStyle.Regular);
                lblGuestsRegistered.Location = new Point(-5, 11);
            }
        }

        public void setIncomingRequests(Label lblIncomingEvents, Label lblIncomingStudents, Label lblIncomingGuests)
        {
            lblIncomingEvents.Text = _event.countAllInactiveEvents().ToString();
            lblIncomingStudents.Text = _student.countAllInactiveStudents().ToString();
            lblIncomingGuests.Text = _guest.countAllGuestsUnregistered().ToString();
        }

        public void setRecentEvent(Panel panelRecentEventCover, Label lblRecentEventName, Label lblRecentEventVenue,
            Label lblRecentEventDate, Label lblRecentEventTime, Label lblRecentEventStudents,
            Label lblRecentEventStudentFee, Label lblRecentEventGuests, Label lblRecentEventGuestFee,
            Label lblRecentEventIGP)
        {
            if (_eventDetails.recentEvent())
            {
                panelRecentEventCover.Hide();
                _eventDetails.selectStudentsRecentEvent();
                int student_igp = int.Parse(_eventDetails.getEventDetailItems("student_count")) *
                    int.Parse(_eventDetails.getEventDetailItems("student_registration"));
                int guest_igp = 0;

                lblRecentEventName.Text = _eventDetails.getEventDetailItems("event_name");
                lblRecentEventName.Left = (282 - lblRecentEventName.Width) / 2;
                lblRecentEventVenue.Text = _eventDetails.getEventDetailItems("venue");
                DateTime date_from = Convert.ToDateTime(_eventDetails.getEventDetailItems("date_from"));
                DateTime date_to = Convert.ToDateTime(_eventDetails.getEventDetailItems("date_to"));
                string date;
                if (date_from.ToString("MMMM") == date_to.Month.ToString("MMMM"))
                {
                    date = date_from.ToString("MMMM dd") + " - " + date_to.ToString("MMMM dd, yyyy");
                }
                else
                {
                    date = date_from.ToString("MMMM dd") + " - " + date_to.ToString("dd, yyyy");
                }

                lblRecentEventDate.Text = date;
                lblRecentEventTime.Text = "Time: " + _eventDetails.getEventDetailItems("time");
                lblRecentEventStudents.Text = "Students Participated: " + _eventDetails.getEventDetailItems("student_count");
                if (_eventDetails.getEventDetailItems("student_registration") != "0")
                {
                    lblRecentEventStudentFee.Text = "Student Fee: Php " + _eventDetails.getEventDetailItems("student_registration");
                }
                else
                {
                    lblRecentEventStudentFee.Text = "Student Fee: Free";
                }

                if (_eventDetails.getEventDetailItems("allow_guests") == "1")
                {
                    _eventDetails.selectGuestsRecentEvent();
                    lblRecentEventGuests.Text = "Guests Participated: " + _eventDetails.getEventDetailItems("guest_count");
                    if (_eventDetails.getEventDetailItems("guest_registration") != "0")
                    {
                        lblRecentEventGuestFee.Text = "Guest Fee: Php " + _eventDetails.getEventDetailItems("guest_registration");
                    }
                    else
                    {
                        lblRecentEventGuestFee.Text = "Guest Fee: Free";
                    }
                    guest_igp = int.Parse(_eventDetails.getEventDetailItems("guest_count")) *
                    int.Parse(_eventDetails.getEventDetailItems("guest_registration"));
                }
                else
                {
                    lblRecentEventGuests.Text = "Guests Attended: N/A";
                    lblRecentEventGuestFee.Text = "Guest Fee: N/A";
                }
                lblRecentEventIGP.Text = "Expected IGP: Php " + (student_igp + guest_igp).ToString();
            }
        }

        public void setUpcomingEvent(Panel panelUpcomingEventCover, Label lblUpcomingEventName, Label lblUpcomingEventVenue, 
            Label lblUpcomingEventDate, Label lblUpcomingEventTime, Label lblUpcomingEventStudents, 
            Label lblUpcomingEventStudentFee, Label lblUpcomingEventGuests, Label lblUpcomingEventGuestFee,
            Label lblUpcomingEventIGP)
        {
            if(_eventDetails.upcomingEvent())
            {
                panelUpcomingEventCover.Hide();
                _eventDetails.selectStudentsUpcomingEvent();
                int student_igp = int.Parse(_eventDetails.getEventDetailItems("student_count")) *
                    int.Parse(_eventDetails.getEventDetailItems("student_registration"));
                int guest_igp = 0;

                lblUpcomingEventName.Text = _eventDetails.getEventDetailItems("event_name");
                lblUpcomingEventName.Left = (282 - lblUpcomingEventName.Width) / 2;
                lblUpcomingEventVenue.Text = _eventDetails.getEventDetailItems("venue");
                DateTime date_from = Convert.ToDateTime(_eventDetails.getEventDetailItems("date_from"));
                DateTime date_to = Convert.ToDateTime(_eventDetails.getEventDetailItems("date_to"));
                string date;
                if(date_from.ToString("MMMM") == date_to.Month.ToString("MMMM"))
                {
                    date = date_from.ToString("MMMM dd") + " - " + date_to.ToString("MMMM dd, yyyy");
                } else
                {
                    date = date_from.ToString("MMMM dd") + " - " + date_to.ToString("dd, yyyy");
                }

                lblUpcomingEventDate.Text = date;
                lblUpcomingEventTime.Text = "Time: " + _eventDetails.getEventDetailItems("time");
                lblUpcomingEventStudents.Text = "Current Students: " + _eventDetails.getEventDetailItems("student_count");
                if (_eventDetails.getEventDetailItems("student_registration") != "0")
                {
                    lblUpcomingEventStudentFee.Text = "Student Fee: Php " + _eventDetails.getEventDetailItems("student_registration");
                }
                else
                {
                    lblUpcomingEventStudentFee.Text = "Student Fee: Free";
                }

                if (_eventDetails.getEventDetailItems("allow_guests") == "1")
                {
                    _eventDetails.selectGuestsUpcomingEvent();
                    lblUpcomingEventGuests.Text = "Current Guests: " + _eventDetails.getEventDetailItems("guest_count");
                    if(_eventDetails.getEventDetailItems("guest_registration") != "0")
                    {
                        lblUpcomingEventGuestFee.Text = "Guest Fee: Php " + _eventDetails.getEventDetailItems("guest_registration");
                    } else
                    {
                        lblUpcomingEventGuestFee.Text = "Guest Fee: Free";
                    }
                    guest_igp = int.Parse(_eventDetails.getEventDetailItems("guest_count")) *
                    int.Parse(_eventDetails.getEventDetailItems("guest_registration"));
                }
                else
                {
                    lblUpcomingEventGuests.Text = "N/A";
                    lblUpcomingEventGuestFee.Text = "N/A";
                }
                lblUpcomingEventIGP.Text = "Expected IGP: Php " + (student_igp + guest_igp).ToString();
            }
        }

        public void loadNotes(TextBox txtNotes)
        {
            txtNotes.Text = sh.getNotes();
        }
        public void saveNotes(string notes)
        {
            sh.saveNotes(notes);
        }
    }
}
