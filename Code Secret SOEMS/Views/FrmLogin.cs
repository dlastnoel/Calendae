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
using Code_Secret_SOEMS.Presenters;
using Code_Secret_SOEMS.Views;

namespace Code_Secret_SOEMS
{
    public partial class FrmLogin : Form
    {
        SettingsHelper sh;
        LoginPresenter loginPresenter;
        public FrmLogin()
        {
            InitializeComponent();
            sh = new SettingsHelper();
            ThemeHelper th = new ThemeHelper();
            loginPresenter = new LoginPresenter();
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
            th.setLabelColor(lblIDNo);
            th.setLabelColor(lblPassword);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            new FrmConnectionSettings().ShowDialog();
            sh = new SettingsHelper();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new FrmStudentRegistration().Show();
            this.Hide();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtIDNo.Text) && !String.IsNullOrEmpty(txtPassword.Text))
            {
                string officer = loginPresenter.loginOfficer(txtIDNo.Text, txtPassword.Text);
                if (!String.IsNullOrEmpty(officer))
                {
                    new FrmMain(officer).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect ID No or Password", "Calendae", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else
            {
                MessageBox.Show("Please fill up all the fields correctly", "Calendae", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (sh.isFirstRun())
            {
                this.Hide();
                new FrmAdviserRegistration().ShowDialog();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new FrmAbout().ShowDialog();
        }
    }
}
