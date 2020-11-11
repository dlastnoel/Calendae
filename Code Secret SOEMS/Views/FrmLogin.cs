using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS.Helpers;

namespace Code_Secret_SOEMS
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            ThemeHelper th = new ThemeHelper();
            th.setFormColor(this);
            th.setCalendae(pictureBoxCalendae);
            th.setDragPanelColor(panelTop);
            th.setGradientPanelColor(panelLeft);
            th.setButtonColor(btnLogin);
            th.setButtonColor(btnRegister);
            th.setControlButtonColor(btnClose);
            th.setIconButtonColor(btnSettings);
            th.setIconButtonColor(btnAbout);
            th.setLabelColor(lblTitle);
            th.setLabelColor(lblUser);
            th.setLabelColor(lblPassword);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            new FrmConnectionSettings().ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new FrmStudentRegistration().Show();
            this.Hide();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            new FrmMain().Show();
            this.Hide();
        }

        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            new FrmAbout().ShowDialog();
        }
    }
}
