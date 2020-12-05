using System;
using System.Windows.Forms;
using Code_Secret_SOEMS.Presenters;
using Code_Secret_SOEMS.Helpers;

namespace Code_Secret_SOEMS.Views
{
    public partial class FrmGuestRequests : Form
    {
        private ThemeHelper th;
        private GuestRequestPresenter guestRequestPresenter;
        public FrmGuestRequests()
        {
            InitializeComponent();
            guestRequestPresenter = new GuestRequestPresenter(flowLayoutPanelGuest);
            th = new ThemeHelper();
            th.setPanelColor(panelTop);
        }

        private void FrmGuestRequests_Load(object sender, EventArgs e)
        {
            guestRequestPresenter.setGuestRequests();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
