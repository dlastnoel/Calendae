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
    public partial class FrmAdviserRegistration : Form
    {
        FormHelper fh;
        AdviserRegistrationPresenter adviserRegistrationPresenter;
        public FrmAdviserRegistration()
        {
            InitializeComponent();
            ThemeHelper th = new ThemeHelper();
            fh = new FormHelper();
            adviserRegistrationPresenter = new AdviserRegistrationPresenter();
            th.setFormColor(this);
            th.setPanelColor(panelTop);
            th.setButtonColor(btnRegister);
        }

        private void FrmAdviserRegistration_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This is the first run of the system. For security purposes, the organization's adviser information " +
                "needs to be registered first.", "Calendae", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            fh.passwordMessage(txtPassword.Text, txtConfirmPassword.Text, lblPasswordMessage);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtIDNo.Text) && !String.IsNullOrEmpty(txtFirstName.Text) &&
                !String.IsNullOrEmpty(txtMiddleName.Text) && !String.IsNullOrEmpty(txtLastName.Text) &&
                !String.IsNullOrEmpty(txtAddress.Text) && !String.IsNullOrEmpty(txtContactNo.Text) &&
                !String.IsNullOrEmpty(txtEmailAddress.Text) && (rbnMale.Checked == true || rbnFemale.Checked == true) &&
                !String.IsNullOrEmpty(txtPassword.Text) && !String.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                if (txtPassword.Text == txtConfirmPassword.Text)
                {
                    if (txtPassword.Text.Length >= 8)
                    {
                        char gender;
                        if (rbnMale.Checked)
                        {
                            gender = 'M';
                        }
                        else
                        {
                            gender = 'F';
                        }

                        adviserRegistrationPresenter.setAdviser(txtIDNo.Text, txtPosition.Text, txtFirstName.Text,
                            txtMiddleName.Text, txtLastName.Text, txtAddress.Text, txtContactNo.Text, txtEmailAddress.Text,
                            gender, "", "", txtPassword.Text);
                        adviserRegistrationPresenter.addAdivser();

                        MessageBox.Show("Adviser successfully added", "Adviser Registration", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        this.Close();

                        new FrmSchool().ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Password should be atleast 8 char(s) long", "Adviser Registration", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Password mismatched", "Adviser Registration", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill up the form correctly", "Adviser Registration", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
        }
    }
}
