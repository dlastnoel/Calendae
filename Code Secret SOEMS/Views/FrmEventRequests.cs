using System;
using System.Windows.Forms;
using XanderUI;
using Code_Secret_SOEMS.Presenters;
using Code_Secret_SOEMS.Helpers;

namespace Code_Secret_SOEMS.Views
{
    public partial class FrmEventRequests : Form
    {
        private EventRequestPresenter eventRequestPresenter;
        private ThemeHelper th;
        public FrmEventRequests()
        {
            InitializeComponent();
            eventRequestPresenter = new EventRequestPresenter(flowLayoutPanelEvent);
            th = new ThemeHelper();
            th.setFormColor(this);
            th.setPanelColor(panelTop);
        }
        private void FrmEventRequests_Load(object sender, EventArgs e)
        {
            eventRequestPresenter.setEventRequests();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
