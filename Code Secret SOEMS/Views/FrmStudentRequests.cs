using System;
using System.Drawing;
using System.Windows.Forms;
using XanderUI;
using Code_Secret_SOEMS.Presenters;
using Code_Secret_SOEMS.Helpers;

namespace Code_Secret_SOEMS.Views
{
    public partial class FrmStudentRequests : Form
    {
        private StudentRequestPresenter studentRequestPresenter;
        private ThemeHelper th;
        public FrmStudentRequests()
        {
            InitializeComponent();
            studentRequestPresenter = new StudentRequestPresenter(flowLayoutPanelStudent);
            th = new ThemeHelper();
            th.setPanelColor(panelTop);
        }

        private void FrmStudentRequests_Load(object sender, EventArgs e)
        {
            studentRequestPresenter.setStudentRequests();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
