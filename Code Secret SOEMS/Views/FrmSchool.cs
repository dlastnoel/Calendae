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

namespace Code_Secret_SOEMS.Views
{
    public partial class FrmSchool : Form
    {
        SettingsHelper sh;
        SchoolPresenter schoolPresenter;
        public FrmSchool()
        {
            InitializeComponent();
            sh = new SettingsHelper();
            ThemeHelper th = new ThemeHelper();
            schoolPresenter = new SchoolPresenter();
            th.setFormColor(this);
            th.setPanelColor(panelTop);
            th.setButtonColor(btnRegister);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSchoolName.Text) && !String.IsNullOrEmpty(txtOrganization.Text))
            {
                schoolPresenter.setSchoolName(txtSchoolName.Text, txtOrganization.Text);
                MessageBox.Show("Organization successfully registered \n You  will now redirected to" +
                    "login window", "Organization Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);

                sh.disableFirstRun();

                this.Close();
                new FrmLogin().Show();
            } else
            {
                MessageBox.Show("Please fill up the form correctly", "Adviser Registration", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
        }
    }
}
