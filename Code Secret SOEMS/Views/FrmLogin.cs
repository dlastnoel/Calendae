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
        LoginPresenter loginPresenter;
        SettingsHelper sh;
        ThemeHelper th;
        private static byte counter = 3;
        public FrmLogin()
        {
            InitializeComponent();
            loginPresenter = new LoginPresenter();
            sh = new SettingsHelper();
            th = new ThemeHelper();
            th.setFormColor(this);
            th.setCalendae(pictureBoxCalendae);
            th.setDragPanelColor(panelTop);
            th.setGradientPanelColor(panelLeft);
            th.setButtonColor(btnLogin);
            th.setButtonColor(btnRegister);
            th.setControlButtonColor(btnClose);
            th.setIconButtonColor(btnSettings);
            th.setIconButtonColor(btnAbout);
            th.setIconButtonColor(btnEvents);
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
            loginPresenter = new LoginPresenter();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new FrmStudentRegistration("","").ShowDialog();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtIDNo.Text) && !String.IsNullOrEmpty(txtPassword.Text))
            {
                if (sh.isLoginLocked())
                {
                    if(sh.isLocked())
                    {
                            MessageBox.Show("System is locked, try again later", "Calendae", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if(counter != 0)
                    {
                        if (loginPresenter.loginOfficer(txtIDNo.Text, txtPassword.Text))
                        {
                            new FrmMain(loginPresenter.getLoggedInOfficerPosition(), loginPresenter.getLoggedInOfficerName()).Show();
                            this.Hide();
                        }
                        else
                        {
                            counter--;
                            MessageBox.Show("Incorrect ID No or Password, " +
                                counter + " tries remaining", "Calendae", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            if(counter == 0)
                            {
                                sh.lockLogin();
                                counter = 3;
                                new FrmLocked(0).Show();
                            }
                        }
                    }
                } else
                {
                    if (loginPresenter.loginOfficer(txtIDNo.Text, txtPassword.Text))
                    {
                        new FrmMain(loginPresenter.getLoggedInOfficerPosition(), loginPresenter.getLoggedInOfficerName()).Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect ID No or Password", "Calendae", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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

            if (sh.isLoginLocked() && sh.isLocked())
            {
                new FrmLocked(1).ShowDialog();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new FrmAbout().ShowDialog();
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            new FrmEventRegistration("").Show();
            this.Hide();
        }

        private void btnEvents_MouseEnter(object sender, EventArgs e)
        {
            btnEvents.IconColor = Color.White;
        }

        private void btnEvents_MouseLeave(object sender, EventArgs e)
        {
            btnEvents.IconColor = Color.Black;
        }
    }
}
