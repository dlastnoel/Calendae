using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS.Helpers;
using Code_Secret_SOEMS.Presenters;
using Code_Secret_SOEMS.Views;

namespace Code_Secret_SOEMS
{
    public partial class CtrlDashboard : UserControl
    {
        DashboardPresenter dashboardPresenter;
        public CtrlDashboard()
        {
            InitializeComponent();
            dashboardPresenter = new DashboardPresenter();
            lblSchool.Text = dashboardPresenter.getSchoolName();
            lblOrganization.Text = dashboardPresenter.getOrganization();
        }
        private void reset()
        {
            dashboardPresenter.setDashboardTile(lblActiveEvents, lblStudentsRegistered, lblGuestsRegistered);
            dashboardPresenter.setIncomingRequests(lblIncomingEvents, lblIncomingStudents, lblIncomingGuests);
            dashboardPresenter.setAdviser(lblAdviser);
        }

        private void CtrlDashboard_Load(object sender, EventArgs e)
        {
            ThemeHelper th = new ThemeHelper();
            th.setUserControlColor(this);
            reset();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            if(lblIncomingEvents.Text != "0")
            {
                new FrmEventRequests().ShowDialog();
                reset();
            } else
            {
                MessageBox.Show("There are no incoming requests for events at this time", "Calendae",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            if(lblIncomingStudents.Text != "0")
            {
                new FrmStudentRequests().ShowDialog();
                reset();
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
                reset();
            } else
            {
                MessageBox.Show("There are no incoming requests for guests at this time", "Calendae",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
