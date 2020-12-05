using System;
using System.Windows.Forms;
using Code_Secret_SOEMS.Helpers;

namespace Code_Secret_SOEMS
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
            ThemeHelper th = new ThemeHelper();
            th.setFormColor(this);
            th.setCalendae(pictureBoxCalendae);
            th.setCodeSecret(pictureBoxCodeSecret);
            th.setGradientPanelColor(panelLeft);
            th.setDragPanelColor(panelTop);
            th.setControlButtonColor(btnBack);
            th.setLabelColor(lblAbout1);
            th.setLabelColor(lblAbout2);
            th.setLabelColor(lblAbout3);
            th.setLabelColor(lblTitle);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
