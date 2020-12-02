using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS.Models;

namespace Code_Secret_SOEMS.Presenters
{
    class DashboardPresenter
    {
        Event _event = new Event();
        Student _student = new Student();
        Guest _guest = new Guest();
        Officer _officer = new Officer();

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
    }
}
