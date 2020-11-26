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

        private void CtrlDashboard_Load(object sender, EventArgs e)
        {
            ThemeHelper th = new ThemeHelper();
            th.setUserControlColor(this);
        }
    }
}
