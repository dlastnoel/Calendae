﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Code_Secret_SOEMS.Presenters;
using Code_Secret_SOEMS.Helpers;

namespace Code_Secret_SOEMS
{
    public partial class FrmGuests : Form
    {
        private GuestPresenter guestPresenter;
        private ThemeHelper th;
        private int guest_id;
        private bool activation;

        public FrmGuests(string mode, int id)
        {
            InitializeComponent();
            th = new ThemeHelper();
            guestPresenter = new GuestPresenter();
            th.setFormColor(this);
            th.setPanelColor(panelTop);
            th.setGroupBoxColor(groupPersonalInfo);
            th.setGroupBoxColor(groupSchoolInfo);
            th.setGroupBoxColor(groupWorkInfo);
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

            guestPresenter.setEvents(cmbEvents);

            if(mode == "form")
            {
                btnAdd.Text = "Add";
                lblTitle.Text = "GUEST FORM";
                this.Text = lblTitle.Text;
                if(id != 0)
                {
                    guest_id = id;
                    populateFields();
                }
                else
                {
                    btnUpdate.Enabled = false;
                    btnUpdate.FlatStyle = FlatStyle.Standard;
                    btnDelete.Enabled = false;
                }
            } else
            {
                //int event_id = guestPresenter.eventID(cmbEvents.Text);
                //cmbEvents.Text = guestPresenter.getEventName(int.Parse(mode));
                activation = false;
                cmbEvents.Text = mode;
                cmbEvents.Enabled = false;
                btnAdd.Text = "Register";
                lblStatus.Hide();
                switchIsActivated.Hide();
                lblSwitchStatus.Hide();
                this.Size = new Size(616, 580);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtFirstName.Text) && !String.IsNullOrEmpty(txtMiddleName.Text) &&
                    !String.IsNullOrEmpty(txtLastName.Text) && !String.IsNullOrEmpty(txtAddress.Text) &&
                    !String.IsNullOrEmpty(txtContactNo.Text) && !String.IsNullOrEmpty(txtEmailAddress.Text) &&
                    (rbnMale.Checked || rbnFemale.Checked) && cmbEvents.SelectedIndex != -1 &&
                    (rbnStudent.Checked && !String.IsNullOrEmpty(txtSchoolName.Text) && !String.IsNullOrEmpty(txtCourse.Text) &&
                        !String.IsNullOrEmpty(txtYear.Text)) ||
                        (rbnWorking.Checked && !String.IsNullOrEmpty(txtWorksAt.Text) && !String.IsNullOrEmpty(txtPosition.Text)))
            {
                setGuest();
                guestPresenter.addGuest();
                if (btnAdd.Text == "Add")
                {
                    guestPresenter.registerGuest();
                    MessageBox.Show("Guest successfully registered to " + cmbEvents.Text, "Guests", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Your registration to " + cmbEvents.Text + " is successful and is pending for approval",
                                "Guests", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Your registration code is " + guestPresenter.getCode() + ". Use this code to check your " +
                        "status of registration later on. Thank you!", "Guest Registration", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill up the form correctly", "Guests", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            /*if (btnAdd.Text == "Add")
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
                            setGuest();
                            guestPresenter.addGuest();
                            guestPresenter.registerGuest();

                            MessageBox.Show("Guest successfully registered to " + cmbEvents.Text, "Guests", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.Close();
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
                            setGuest();
                            guestPresenter.addGuest();
                            guestPresenter.registerGuest();

                            MessageBox.Show("Guest successfully registered to " + cmbEvents.Text, "Guests", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Please fill up the form correctly", "Guests", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill up the form correctly", "Guests", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill up the form correctly", "Guests", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                }
            }
            else if (btnAdd.Text == "Register")
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
                            setGuest();
                            guestPresenter.addGuest();

                            MessageBox.Show("Your registration to " + cmbEvents.Text + " is successful and is pending for approval", 
                                "Guests", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show("Your registration code is " + guestPresenter.getCode() + ". Use this code to check your " +
                                "status of registration later on. Thank you!", "Guest Registration", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Please fill up the form correctly", "Guest Registration", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                        }
                    }
                    else if (rbnWorking.Checked)
                    {
                        if (!String.IsNullOrEmpty(txtWorksAt.Text) && !String.IsNullOrEmpty(txtPosition.Text))
                        {
                            setGuest();
                            guestPresenter.addGuest();

                            MessageBox.Show("Your registration to " + cmbEvents.Text + " is successful and is pending for approval",
                                "Guests", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MessageBox.Show("Your registration code is " + guestPresenter.getCode() + ". Use this code to check your " +
                                "status of registration later on. Thank you!", "Guest Registration", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Please fill up the form correctly", "Guest Registration", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please fill up the form correctly", "Guest Registration", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill up the form correctly", "Guest Registration", MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                }
            }
            else
            {
                clearFields();
            }*/
        }

        private void rbnStudent_CheckedChanged(object sender, EventArgs e)
        {
            groupWorkInfo.Hide();
            groupSchoolInfo.Show();
        }

        private void rbnWorking_CheckedChanged(object sender, EventArgs e)
        {
            groupWorkInfo.Show();
            groupSchoolInfo.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if((!String.IsNullOrEmpty(txtFirstName.Text) && !String.IsNullOrEmpty(txtMiddleName.Text) &&
                    !String.IsNullOrEmpty(txtLastName.Text) && !String.IsNullOrEmpty(txtAddress.Text) &&
                    !String.IsNullOrEmpty(txtContactNo.Text) && !String.IsNullOrEmpty(txtEmailAddress.Text) &&
                    (rbnMale.Checked || rbnFemale.Checked) && cmbEvents.SelectedIndex != -1 &&
                    (rbnStudent.Checked && !String.IsNullOrEmpty(txtSchoolName.Text) && !String.IsNullOrEmpty(txtCourse.Text) &&
                        !String.IsNullOrEmpty(txtYear.Text)) ||
                        (rbnWorking.Checked && !String.IsNullOrEmpty(txtWorksAt.Text) && !String.IsNullOrEmpty(txtPosition.Text))))
            {
                setGuest();
                guestPresenter.updateGuest(guest_id);
                MessageBox.Show("Guest successfully registered to " + cmbEvents.Text, "Guests", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                this.Close();
            } else
            {
                MessageBox.Show("Please fill up the form correctly", "Events", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
            }
            /*if (!String.IsNullOrEmpty(txtFirstName.Text) && !String.IsNullOrEmpty(txtMiddleName.Text) &&
                    !String.IsNullOrEmpty(txtLastName.Text) && !String.IsNullOrEmpty(txtAddress.Text) &&
                    !String.IsNullOrEmpty(txtContactNo.Text) && !String.IsNullOrEmpty(txtEmailAddress.Text) &&
                    (rbnMale.Checked || rbnFemale.Checked) && cmbEvents.SelectedIndex != -1)
            {
                if (rbnStudent.Checked)
                {
                    if (!String.IsNullOrEmpty(txtSchoolName.Text) && !String.IsNullOrEmpty(txtCourse.Text) &&
                        !String.IsNullOrEmpty(txtYear.Text))
                    {
                        setGuest();
                        guestPresenter.updateGuest(guest_id);

                        MessageBox.Show("Guest successfully registered to " + cmbEvents.Text, "Guests", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        this.Close();
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
                        setGuest();
                        guestPresenter.updateGuest(guest_id);

                        MessageBox.Show("Guest successfully updated to " + cmbEvents.Text + " and is pending for approval",
                            "Guests", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
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
            }*/
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            guestPresenter.deleteGuest(guest_id);
            MessageBox.Show("Guest successfully deleted", "Events", MessageBoxButtons.OK, MessageBoxIcon.Information);

            clearFields();
            this.Close();
        }

        private void switchIsActivated_Click(object sender, EventArgs e)
        {
            if(guest_id != 0)
            {
                guestPresenter.guestActivation(guest_id, switchIsActivated, lblSwitchStatus);
            } else if(this.Size != new Size(616, 580))
            {
                if (switchIsActivated.SwitchState == XanderUI.XUISwitch.State.On)
                {
                    activation = true;
                    lblSwitchStatus.Text = "Activated";
                }
                else
                {
                    activation = false;
                    lblSwitchStatus.Text = "Deactivated";
                }
            }
        }

        private void populateFields()
        {
            btnAdd.Enabled = false;
            btnAdd.FlatStyle = FlatStyle.Standard;
            btnUpdate.Enabled = true;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnDelete.Enabled = true;
            btnDelete.FlatStyle = FlatStyle.Flat;
            guestPresenter.prepareGuest(guest_id, rbnStudent, rbnWorking, txtFirstName, txtMiddleName, txtLastName,
                txtAddress, txtContactNo, txtEmailAddress, rbnMale, rbnFemale, txtSchoolName, txtCourse, txtYear, txtWorksAt,
                txtPosition, switchIsActivated, lblSwitchStatus, cmbEvents);
        }

        private void clearFields()
        {
            guest_id = 0;
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

        private void setGuest()
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
                txtCourse.Text, txtYear.Text, txtWorksAt.Text, txtPosition.Text, activation, cmbEvents.Text);
        }
    }
}
