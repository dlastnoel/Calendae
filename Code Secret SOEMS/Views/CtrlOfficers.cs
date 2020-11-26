using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS.Helpers;
using Code_Secret_SOEMS.Presenters;

namespace Code_Secret_SOEMS
{
    public partial class CtrlOfficers : UserControl
    {
        FormHelper fh;
        OfficerPresenter officerPresenter;
        string currentID;

        private void populateFields()
        {
            btnAdd.Text = "Cancel";
            btnUpdate.Enabled = true;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnDelete.Enabled = true;
            btnDelete.FlatStyle = FlatStyle.Flat;
            officerPresenter.prepareOfficer(currentID, txtIDNo, txtPosition, txtFirstName, txtMiddleName, txtLastName,
                txtAddress, txtContactNo, txtEmailAddress, rbnMale, rbnFemale, txtCourse, txtYearAndSection);

        }

        private void clearFields()
        {
            txtIDNo.Clear();
            txtPosition.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtContactNo.Clear();
            txtEmailAddress.Clear();
            rbnMale.Checked = false;
            rbnFemale.Checked = false;
            txtCourse.Clear();
            txtYearAndSection.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            lblPasswordMessage.Text = "";
        }

        public CtrlOfficers()
        {
            InitializeComponent();
            fh = new FormHelper();
            officerPresenter = new OfficerPresenter();

            btnUpdate.Enabled = false;
            btnUpdate.FlatStyle = FlatStyle.Standard;
            btnDelete.Enabled = false;
            btnDelete.FlatStyle = FlatStyle.Standard;
        }

        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            new FrmOfficers(false, "").ShowDialog();
        }

        private void CtrlOfficers_SizeChanged(object sender, EventArgs e)
        {
            if(this.Size == new Size(940, 614))
            {
                btnOpenForm.Show();
            } else
            {
                btnOpenForm.Hide();
            }
        }

        private void CtrlOfficers_Load(object sender, EventArgs e)
        {
            ThemeHelper th = new ThemeHelper();
            th.setUserControlColor(this);
            th.setGroupBoxColor(groupPersonalInfo);
            th.setGroupBoxColor(groupSchoolInfo);
            th.setGroupBoxColor(groupSecurity);
            th.setButtonColor(btnOpenForm);
            th.setButtonColor(btnAdd);
            th.setButtonColor(btnUpdate);
            th.setButtonColor(btnDelete);

            th.setRadioButtonColor(rbnMale);
            th.setRadioButtonColor(rbnFemale);

            th.setLabelColor(lblFirstName);
            th.setLabelColor(lblMiddleName);
            th.setLabelColor(lblLastName);
            th.setLabelColor(lblAddress);
            th.setLabelColor(lblContactNo);
            th.setLabelColor(lblEmailAddress);
            th.setLabelColor(lblIDNo);
            th.setLabelColor(lblCourse);
            th.setLabelColor(lblYearAndSection);
            th.setLabelColor(lblPassword);
            th.setLabelColor(lblConfirmPassword);

            officerPresenter.loadOfficers(dataOfficers);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(btnAdd.Text == "Add")
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
                            if (txtPosition.Text != "Adviser")
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

                                officerPresenter.setOfficer(txtIDNo.Text, txtPosition.Text, txtFirstName.Text,
                                    txtMiddleName.Text, txtLastName.Text, txtAddress.Text, txtContactNo.Text, txtEmailAddress.Text,
                                    gender, txtCourse.Text, txtYearAndSection.Text, txtPassword.Text);
                                officerPresenter.addOfficer();

                                MessageBox.Show("Officer successfully added", "Officers", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                                clearFields();
                                officerPresenter.loadOfficers(dataOfficers);
                            } else
                            {
                                MessageBox.Show("Adviser position had already been occupied", "Officers", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            }

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
            } else
            {
                clearFields();
                btnAdd.Text = "Add";
                btnUpdate.Enabled = false;
                btnUpdate.FlatStyle = FlatStyle.Standard;
                btnDelete.Enabled = false;
                btnDelete.FlatStyle = FlatStyle.Standard;
            }
        }

        private void dataOfficers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow dataGridViewRow = dataOfficers.Rows[indexRow];
            currentID = dataGridViewRow.Cells[0].Value.ToString();

            if (this.Size == new Size(1576, 956))
            {
                populateFields();
            } else
            {
                FrmOfficers frmOfficers = new FrmOfficers(true, currentID);
                frmOfficers.ShowDialog();
                officerPresenter.loadOfficers(dataOfficers);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                        if(txtPosition.Text != "Adviser" || txtPosition.Text != "adviser")
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

                            officerPresenter.setOfficer(txtIDNo.Text, txtPosition.Text, txtFirstName.Text,
                                txtMiddleName.Text, txtLastName.Text, txtAddress.Text, txtContactNo.Text, txtEmailAddress.Text,
                                gender, txtCourse.Text, txtYearAndSection.Text, txtPassword.Text);
                            officerPresenter.updateOfficer(currentID);

                            MessageBox.Show("Officer successfully updated", "Officers", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            clearFields();
                            officerPresenter.loadOfficers(dataOfficers);
                        } else
                        {
                            MessageBox.Show("Adviser position had already been occupied", "Officers", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
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
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            officerPresenter.deleteOfficer(currentID);
            MessageBox.Show("Officer successfully deleted", "Officers", MessageBoxButtons.OK, MessageBoxIcon.Information);

            officerPresenter.loadOfficers(dataOfficers);
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            fh.passwordMessage(txtPassword.Text, txtConfirmPassword.Text, lblPasswordMessage);
        }
    }
}
