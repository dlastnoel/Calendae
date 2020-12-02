using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XanderUI;
using Code_Secret_SOEMS.Presenters;
using Code_Secret_SOEMS.Helpers;

namespace Code_Secret_SOEMS.Views
{
    public partial class FrmEventRequests : Form
    {
        EventRequestPresenter eventRequestPresenter;
        ThemeHelper th;
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
