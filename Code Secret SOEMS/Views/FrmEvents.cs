using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS.Presenters;
using Code_Secret_SOEMS.Helpers;

namespace Code_Secret_SOEMS
{
    public partial class FrmEvents : Form
    {
        EventPresenter eventPresenter;
        ThemeHelper th;
        int currentID;
        bool activation;

        private void populateFields()
        {
            btnAdd.Enabled = false;
            btnAdd.FlatStyle = FlatStyle.Standard;
            btnUpdate.Enabled = true;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnDelete.Enabled = true;
            btnDelete.FlatStyle = FlatStyle.Flat;
            activation = eventPresenter.prepareEvent(currentID, txtEventName, txtVenue, txtDate, txtTime, txtStudentRegistrationFee,
                        txtStudentSlots, txtEventDetails, checkGuests, txtGuestRegistrationFee, txtGuestSlots, switchIsActivated, 
                        lblSwitchStatus);
        }

        private void clearFields()
        {
            txtEventName.Clear();
            txtVenue.Clear();
            txtDate.Clear();
            txtTime.Clear();
            txtStudentRegistrationFee.Clear();
            txtStudentSlots.Clear();
            txtEventDetails.Clear();
            checkGuests.Checked = false;
            txtGuestRegistrationFee.Clear();
            txtGuestSlots.Clear();
            switchIsActivated.SwitchState = XanderUI.XUISwitch.State.Off;
            lblSwitchStatus.Text = "Deactivated";

            btnAdd.Text = "Add";
            btnUpdate.Enabled = false;
            btnUpdate.FlatStyle = FlatStyle.Standard;
            btnDelete.Enabled = false;
            btnDelete.FlatStyle = FlatStyle.Standard;
        }
        public FrmEvents(string position, bool update, int id)
        {
            InitializeComponent();
            th = new ThemeHelper();
            eventPresenter = new EventPresenter();
            th.setFormColor(this);
            th.setPanelColor(panelTop);
            th.setGroupBoxColor(groupEventInfo);
            th.setGroupBoxColor(groupGuests);
            th.setCheckBoxColor(checkGuests);
            th.setButtonColor(btnAdd);
            th.setButtonColor(btnUpdate);
            th.setButtonColor(btnDelete);

            th.setLabelColor(lblEventName);
            th.setLabelColor(lblVenue);
            th.setLabelColor(lblDate);
            th.setLabelColor(lblTime);
            th.setLabelColor(lblTime);
            th.setLabelColor(lblStudentRegistrationFee);
            th.setLabelColor(lblStudentSlots);
            th.setLabelColor(lblGuestRegistrationFee);
            th.setLabelColor(lblGuestSlots);

            currentID = id;
            
            if (position != "Adviser")
            {
                activation = false;
                switchIsActivated.Hide();
                lblStatus.Hide();
                lblSwitchStatus.Hide();
            }

            if (update)
            {
                btnUpdate.Enabled = true;
                btnUpdate.FlatStyle = FlatStyle.Flat;
                btnDelete.Enabled = true;
                btnDelete.FlatStyle = FlatStyle.Flat;
                populateFields();
            }
            else
            {
                btnUpdate.Enabled = false;
                btnUpdate.FlatStyle = FlatStyle.Standard;
                btnDelete.Enabled = false;
                btnDelete.FlatStyle = FlatStyle.Standard;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkGuests_CheckedChanged(object sender, EventArgs e)
        {
            if(checkGuests.CheckState == CheckState.Checked)
            {
                groupGuests.Enabled = true;
            } else
            {
                groupGuests.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                if (!String.IsNullOrEmpty(txtEventName.Text) && !String.IsNullOrEmpty(txtVenue.Text) && !String.IsNullOrEmpty(txtDate.Text) &&
                !String.IsNullOrEmpty(txtTime.Text) && !String.IsNullOrEmpty(txtStudentRegistrationFee.Text) &&
                !String.IsNullOrEmpty(txtStudentSlots.Text) && !String.IsNullOrEmpty(txtEventDetails.Text))
                {
                    if (checkGuests.Checked)
                    {
                        if (!String.IsNullOrEmpty(txtGuestRegistrationFee.Text) && !String.IsNullOrEmpty(txtGuestSlots.Text))
                        {
                            eventPresenter.setEvent(txtEventName.Text, txtVenue.Text, txtDate.Text, txtTime.Text,
                                int.Parse(txtStudentRegistrationFee.Text), int.Parse(txtStudentSlots.Text), txtEventDetails.Text,
                                checkGuests.Checked, int.Parse(txtGuestRegistrationFee.Text), int.Parse(txtGuestSlots.Text), activation);
                            eventPresenter.addEvent();
                            if (activation)
                            {
                                MessageBox.Show("Event successfully added", "Events", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Event successfully added and is pending for approval", "Events",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Please fill up the form correctly", "Events", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        eventPresenter.setEvent(txtEventName.Text, txtVenue.Text, txtDate.Text, txtTime.Text,
                            int.Parse(txtStudentRegistrationFee.Text), int.Parse(txtStudentSlots.Text), txtEventDetails.Text,
                            checkGuests.Checked, 0, 0, activation);
                        eventPresenter.addEvent();
                        MessageBox.Show("Event successfully added", "Events", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                        this.Close();
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
                clearFields();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtEventName.Text) && !String.IsNullOrEmpty(txtVenue.Text) && !String.IsNullOrEmpty(txtDate.Text) &&
                !String.IsNullOrEmpty(txtTime.Text) && !String.IsNullOrEmpty(txtStudentRegistrationFee.Text) &&
                !String.IsNullOrEmpty(txtStudentSlots.Text) && !String.IsNullOrEmpty(txtEventDetails.Text))
            {
                if (checkGuests.Checked)
                {
                    if (!String.IsNullOrEmpty(txtGuestRegistrationFee.Text) && !String.IsNullOrEmpty(txtGuestSlots.Text))
                    {
                        eventPresenter.setEvent(txtEventName.Text, txtVenue.Text, txtDate.Text, txtTime.Text,
                            int.Parse(txtStudentRegistrationFee.Text), int.Parse(txtStudentSlots.Text), txtEventDetails.Text,
                            checkGuests.Checked, int.Parse(txtGuestRegistrationFee.Text), int.Parse(txtGuestSlots.Text), activation);
                        eventPresenter.updateEvent(currentID);
                        MessageBox.Show("Event successfully updated", "Events", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Please fill up the form correctly", "Events", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                }
                else
                {
                    eventPresenter.setEvent(txtEventName.Text, txtVenue.Text, txtDate.Text, txtTime.Text,
                        int.Parse(txtStudentRegistrationFee.Text), int.Parse(txtStudentSlots.Text), txtEventDetails.Text,
                        checkGuests.Checked, 0, 0, activation);
                    eventPresenter.updateEvent(currentID);
                    MessageBox.Show("Event successfully added", "Events", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please fill up the form correctly", "Events", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            eventPresenter.deleteEvent(currentID);
            MessageBox.Show("Event successfully deleted", "Events", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void switchIsActivated_Click(object sender, EventArgs e)
        {
            if (switchIsActivated.SwitchState == XanderUI.XUISwitch.State.On)
            {
                lblSwitchStatus.Text = "Activated";
                activation = true;
            }
            else
            {
                lblSwitchStatus.Text = "Deactivated";
                activation = false;
            }
        }

        private void checkGuests_CheckedChanged_1(object sender, EventArgs e)
        {
            if(checkGuests.Checked)
            {
                groupGuests.Enabled = true;
            } else
            {
                groupGuests.Enabled = false;
            }
        }
    }
}
