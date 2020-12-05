using System;
using System.Windows.Forms;
using Code_Secret_SOEMS.Helpers;
using Code_Secret_SOEMS.Presenters;
using Code_Secret_SOEMS.Views;

namespace Code_Secret_SOEMS
{
    public partial class CtrlDashboard : UserControl
    {
        private DashboardPresenter dashboardPresenter;
        private string position;
        public CtrlDashboard(string position)
        {
            InitializeComponent();
            dashboardPresenter = new DashboardPresenter();
            lblSchool.Text = dashboardPresenter.getSchoolName();
            lblOrganization.Text = dashboardPresenter.getOrganization();
            this.position = position;
        }
        private void refresh()
        {
            dashboardPresenter.setDashboardTile(lblActiveEvents, lblStudentsRegistered, lblGuestsRegistered);
            dashboardPresenter.setIncomingRequests(lblIncomingEvents, lblIncomingStudents, lblIncomingGuests);
            dashboardPresenter.setAdviser(lblAdviser);
            dashboardPresenter.setRecentEvent(panelRecentEventCover, lblRecentEventName, lblRecentEventVenue,
                lblRecentEventDate, lblRecentEventTime, lblRecentEventStudents, lblRecentEventStudentFee,
                lblRecentEventGuests, lblRecentEventGuestFee, lblRecentEventIGP);
            dashboardPresenter.setUpcomingEvent(panelUpcomingEventCover, lblUpcomingEventName, lblUpcomingEventVenue,
                lblUpcomingEventDate, lblUpcomingEventTime, lblUpcomingEventStudents, lblUpcomingEventStudentFee,
                lblUpcomingEventGuests, lblUpcomingEventGuestFee, lblUpcomingEventIGP);
            dashboardPresenter.loadNotes(txtNotes);
        }

        private void CtrlDashboard_Load(object sender, EventArgs e)
        {
            ThemeHelper th = new ThemeHelper();
            th.setUserControlColor(this);
            refresh();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            if(position == "Adviser")
            {
                if (lblIncomingEvents.Text != "0")
                {
                    new FrmEventRequests().ShowDialog();
                    refresh();
                }
                else
                {
                    MessageBox.Show("There are no incoming requests for events at this time", "Calendae",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else
            {
                MessageBox.Show("Action is restricted", "Calendae",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            if(lblIncomingStudents.Text != "0")
            {
                new FrmStudentRequests().ShowDialog();
                refresh();
            } else
            {
                MessageBox.Show("There are no incoming requests for students at this time", "Calendae",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGuests_Click(object sender, EventArgs e)
        {
            if(lblIncomingGuests.Text != "0")
            {
                new FrmGuestRequests().ShowDialog();
                refresh();
            } else
            {
                MessageBox.Show("There are no incoming requests for guests at this time", "Calendae",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNotes_MouseLeave(object sender, EventArgs e)
        {
            dashboardPresenter.saveNotes(txtNotes.Text);
        }
    }
}
