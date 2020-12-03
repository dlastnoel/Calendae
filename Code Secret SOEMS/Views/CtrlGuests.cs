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
    public partial class CtrlGuests : UserControl
    {
        GuestPresenter guestPresenter;
        int currentID = 0;

        private void populateFields()
        {
            btnAdd.Enabled = false;
            btnAdd.FlatStyle = FlatStyle.Standard;
            btnUpdate.Enabled = true;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnDelete.Enabled = true;
            btnDelete.FlatStyle = FlatStyle.Flat;
            guestPresenter.prepareGuest(currentID, rbnStudent, rbnWorking, txtFirstName, txtMiddleName, txtLastName,
                txtAddress, txtContactNo, txtEmailAddress, rbnMale, rbnFemale, txtSchoolName, txtCourse, txtYear, txtWorksAt,
                txtPosition, switchIsActivated, lblSwitchStatus, cmbEvents);
        }

        private void clearFields()
        {
            currentID = 0;
            rbnStudent.Checked = false;
            rbnWorking.Checked = false;
            groupSchoolInfo.Enabled = false;
            groupWorkInfo.Enabled = false;
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtContactNo.Clear();
            txtEmailAddress.Clear();
            rbnMale.Checked = false;
            rbnFemale.Checked = false;
            txtSchoolName.Clear();
            txtCourse.Clear();
            txtYear.Clear();
            txtWorksAt.Clear();
            txtPosition.Clear();

            btnAdd.Text = "Add";
            btnUpdate.Enabled = false;
            btnUpdate.FlatStyle = FlatStyle.Standard;
            btnDelete.Enabled = false;
            btnDelete.FlatStyle = FlatStyle.Standard;
        }

        public CtrlGuests()
        {
            InitializeComponent();
            guestPresenter = new GuestPresenter();
            guestPresenter.setEvents(cmbEvents);

            btnUpdate.Enabled = false;
            btnUpdate.FlatStyle = FlatStyle.Standard;
            btnDelete.Enabled = false;
            btnDelete.FlatStyle = FlatStyle.Standard;
        }

        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            new FrmGuests("form",0).ShowDialog();
            guestPresenter.loadGuests(dataGuests);
        }

        private void btnOpenForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.Size == new Size(940, 614))
            {
                btnOpenForm.Show();
            }
            else
            {
                btnOpenForm.Hide();
            }
        }

        private void CtrlGuests_Load(object sender, EventArgs e)
        {
            ThemeHelper th = new ThemeHelper();
            th.setUserControlColor(this);
            th.setGroupBoxColor(groupPersonalInfo);
            th.setGroupBoxColor(groupSchoolInfo);
            th.setGroupBoxColor(groupWorkInfo);
            th.setButtonColor(btnOpenForm);
            th.setButtonColor(btnAdd);
            th.setButtonColor(btnUpdate);
            th.setButtonColor(btnDelete);

            th.setRadioButtonColor(rbnStudent);
            th.setRadioButtonColor(rbnWorking);
            th.setRadioButtonColor(rbnMale);
            th.setRadioButtonColor(rbnFemale);

            th.setLabelColor(lblFirstName);
            th.setLabelColor(lblMiddleName);
            th.setLabelColor(lblLastName);
            th.setLabelColor(lblAddress);
            th.setLabelColor(lblEvents);
            th.setLabelColor(lblContactNo);
            th.setLabelColor(lblEmailAddress);
            th.setLabelColor(lblSchoolName);
            th.setLabelColor(lblCourse);
            th.setLabelColor(lblYear);
            th.setLabelColor(lblWorksAt);
            th.setLabelColor(lblPosition);

            guestPresenter.loadGuests(dataGuests);
        }

        private void CtrlGuests_SizeChanged(object sender, EventArgs e)
        {
            if (this.Size == new Size(940, 614))
            {
                btnOpenForm.Show();
            }
            else
            {
                btnOpenForm.Hide();
            }
        }

        private void rbnStudent_CheckedChanged(object sender, EventArgs e)
        {
            if(rbnStudent.Checked)
            {
                groupSchoolInfo.Enabled = true;
                groupWorkInfo.Enabled = false;
            } else
            {
                groupSchoolInfo.Enabled = false;
                groupWorkInfo.Enabled = true;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                if (!String.IsNullOrEmpty(txtFirstName.Text) && !String.IsNullOrEmpty(txtMiddleName.Text) &&
                    !String.IsNullOrEmpty(txtLastName.Text) && !String.IsNullOrEmpty(txtAddress.Text) &&
                    !String.IsNullOrEmpty(txtContactNo.Text) && !String.IsNullOrEmpty(txtEmailAddress.Text) &&
                    (rbnMale.Checked || rbnFemale.Checked) && cmbEvents.SelectedIndex != -1)
                {
                    if (rbnStudent.Checked)
                    {
                        if (!String.IsNullOrEmpty(txtSchoolName.Text) && !String.IsNullOrEmpty(txtCourse.Text) &&
                            !String.IsNullOrEmpty(txtYear.Text))
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

                            guestPresenter.setGuest(txtFirstName.Text, txtMiddleName.Text, txtLastName.Text,
                                txtAddress.Text, txtContactNo.Text, txtEmailAddress.Text, gender, txtSchoolName.Text,
                                txtCourse.Text, txtYear.Text, txtWorksAt.Text, txtPosition.Text, true, cmbEvents.Text);
                            guestPresenter.addGuest();
                            guestPresenter.registerGuest();
                            MessageBox.Show("Guest successfully registered to " + cmbEvents.Text, "Guests", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            clearFields();
                            guestPresenter.loadGuests(dataGuests);
                        }
                        else
                        {
                            MessageBox.Show("Please fill up the form correctly", "Guests", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                        }
                    }
                    else if (rbnWorking.Checked)
                    {
                        if (!String.IsNullOrEmpty(txtWorksAt.Text) && !String.IsNullOrEmpty(txtPosition.Text))
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

                            guestPresenter.setGuest(txtFirstName.Text, txtMiddleName.Text, txtLastName.Text,
                                txtAddress.Text, txtContactNo.Text, txtEmailAddress.Text, gender, txtSchoolName.Text,
                                txtCourse.Text, txtYear.Text, txtWorksAt.Text, txtPosition.Text, true, cmbEvents.Text);
                            guestPresenter.addGuest();
                            guestPresenter.registerGuest();
                            MessageBox.Show("Guest successfully registered to " + cmbEvents.Text, "Guests", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Please fill up the form correctly", "Guests", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill up the form correctly", "Events", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill up the form correctly", "Events", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                }
            } else
            {
                clearFields();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            guestPresenter.deactivateGuest(currentID);
            MessageBox.Show("Guest successfully deleted", "Events", MessageBoxButtons.OK, MessageBoxIcon.Information);

            clearFields();
            guestPresenter.loadGuests(dataGuests);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtFirstName.Text) && !String.IsNullOrEmpty(txtMiddleName.Text) &&
                    !String.IsNullOrEmpty(txtLastName.Text) && !String.IsNullOrEmpty(txtAddress.Text) &&
                    !String.IsNullOrEmpty(txtContactNo.Text) && !String.IsNullOrEmpty(txtEmailAddress.Text) &&
                    (rbnMale.Checked || rbnFemale.Checked) && cmbEvents.SelectedIndex != -1)
            {
                if (rbnStudent.Checked)
                {
                    if (!String.IsNullOrEmpty(txtSchoolName.Text) && !String.IsNullOrEmpty(txtCourse.Text) &&
                        !String.IsNullOrEmpty(txtYear.Text))
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

                        guestPresenter.setGuest(txtFirstName.Text, txtMiddleName.Text, txtLastName.Text,
                                txtAddress.Text, txtContactNo.Text, txtEmailAddress.Text, gender, txtSchoolName.Text,
                                txtCourse.Text, txtYear.Text, txtWorksAt.Text, txtPosition.Text, true, cmbEvents.Text);
                        guestPresenter.updateGuest(currentID);
                        MessageBox.Show("Guest info successfully updated", "Guests", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        clearFields();
                        guestPresenter.loadGuests(dataGuests);
                    }
                    else
                    {
                        MessageBox.Show("Please fill up the form correctly", "Guests", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                }
                else if (rbnWorking.Checked)
                {
                    if (!String.IsNullOrEmpty(txtWorksAt.Text) && !String.IsNullOrEmpty(txtPosition.Text))
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

                        guestPresenter.setGuest(txtFirstName.Text, txtMiddleName.Text, txtLastName.Text,
                                txtAddress.Text, txtContactNo.Text, txtEmailAddress.Text, gender, txtSchoolName.Text,
                                txtCourse.Text, txtYear.Text, txtWorksAt.Text, txtPosition.Text, true, cmbEvents.Text);
                        guestPresenter.updateGuest(currentID);
                        MessageBox.Show("Guest info successfully updated", "Guests", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        clearFields();
                        guestPresenter.loadGuests(dataGuests);
                    }
                    else
                    {
                        MessageBox.Show("Please fill up the form correctly", "Guests", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill up the form correctly", "Events", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
        }

        private void dataGuests_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow dataGridViewRow = dataGuests.Rows[indexRow];
            currentID = int.Parse(dataGridViewRow.Cells[0].Value.ToString());

            if (this.Size == new Size(1576, 956))
            {
                populateFields();
            }
            else
            {
                FrmGuests frmGuests = new FrmGuests("form", currentID);
                frmGuests.ShowDialog();
                guestPresenter.loadGuests(dataGuests);
            }
        }

        private void switchIsActivated_Click(object sender, EventArgs e)
        {
            if(currentID != 0)
            {
                guestPresenter.guestActivation(currentID, switchIsActivated, lblSwitchStatus);
            }
        }
    }
}
