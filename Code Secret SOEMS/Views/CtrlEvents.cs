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
    public partial class CtrlEvents : UserControl
    {
        EventPresenter eventPresenter = new EventPresenter();
        ThemeHelper th;
        int currentID;
        string position;
        byte activation;

        private void populateFields()
        {
            btnAdd.Text = "Cancel";
            btnUpdate.Enabled = true;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnDelete.Enabled = true;
            btnDelete.FlatStyle = FlatStyle.Flat;
            if(position != "Adviser")
            {
                if (eventPresenter.checkEventStatus(currentID))
                {
                    eventPresenter.prepareEvent(currentID, txtEventName, txtVenue, txtDate, txtTime, txtStudentRegistrationFee,
                        txtStudentSlots, txtEventDetails, checkGuests, txtGuestRegistrationFee, txtGuestSlots, activation,
                        switchIsActivated, lblSwitchStatus);
                } else
                {
                    MessageBox.Show("Event is not yet activated", "Events", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else
            {
                eventPresenter.prepareEvent(currentID, txtEventName, txtVenue, txtDate, txtTime, txtStudentRegistrationFee,
                        txtStudentSlots, txtEventDetails, checkGuests, txtGuestRegistrationFee, txtGuestSlots, activation,
                        switchIsActivated, lblSwitchStatus);
            }

            if(checkGuests.Checked)
            {
                groupGuests.Enabled = true;
            } else
            {
                groupGuests.Enabled = false;
            }

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
        public CtrlEvents(string position)
        {
            InitializeComponent();

            btnUpdate.Enabled = false;
            btnUpdate.FlatStyle = FlatStyle.Standard;
            btnDelete.Enabled = false;
            btnDelete.FlatStyle = FlatStyle.Standard;

            this.position = position;
            if(this.position != "Adviser")
            {
                activation = 0;
                switchIsActivated.Hide();
                lblStatus.Hide();
                lblSwitchStatus.Hide();
            }
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

        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            new FrmEvents(position, false, 0).ShowDialog();
            eventPresenter.loadEvents(dataEvents);
        }

        private void CtrlEvents_SizeChanged(object sender, EventArgs e)
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

        private void CtrlEvents_Load(object sender, EventArgs e)
        {
            th = new ThemeHelper();
            th.setUserControlColor(this);
            th.setGroupBoxColor(groupEventInfo);
            th.setGroupBoxColor(groupGuests);
            th.setCheckBoxColor(checkGuests);
            th.setButtonColor(btnOpenForm);
            th.setButtonColor(btnAdd);
            th.setButtonColor(btnUpdate);
            th.setButtonColor(btnDelete);

            th.setLabelColor(lblEventName);
            th.setLabelColor(lblVenue);
            th.setLabelColor(lblDate);
            th.setLabelColor(lblTime);
            th.setLabelColor(lblStudentRegistrationFee);
            th.setLabelColor(lblStudentSlots);
            th.setLabelColor(lblGuestRegistrationFee);
            th.setLabelColor(lblGuestSlots);
            th.setLabelColor(lblStatus);
            th.setLabelColor(lblSwitchStatus);

            th.setLabelColor(lblInfo3);
            th.setLabelColor(lblInfo4);

            eventPresenter.loadEvents(dataEvents);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(btnAdd.Text == "Add")
            {
                if (!String.IsNullOrEmpty(txtEventName.Text) && !String.IsNullOrEmpty(txtVenue.Text) && !String.IsNullOrEmpty(txtDate.Text) &&
                !String.IsNullOrEmpty(txtTime.Text) && !String.IsNullOrEmpty(txtStudentRegistrationFee.Text) &&
                !String.IsNullOrEmpty(txtStudentSlots.Text) && !String.IsNullOrEmpty(txtEventDetails.Text))
                {
                    if (checkGuests.Checked)
                    {
                        if (!String.IsNullOrEmpty(txtGuestRegistrationFee.Text) && !String.IsNullOrEmpty(txtGuestSlots.Text))
                        {
                            byte allow_guests;
                            if (checkGuests.Checked)
                            {
                                allow_guests = 1;
                            }
                            else
                            {
                                allow_guests = 0;
                            }
                            eventPresenter.setEvent(txtEventName.Text, txtVenue.Text, txtDate.Text, txtTime.Text,
                                int.Parse(txtStudentRegistrationFee.Text), int.Parse(txtStudentSlots.Text), txtEventDetails.Text,
                                allow_guests, int.Parse(txtGuestRegistrationFee.Text), int.Parse(txtGuestSlots.Text), activation);
                            eventPresenter.addEvent();
                            if(activation == 1)
                            {
                                MessageBox.Show("Event successfully added", "Events", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                            } else
                            {
                                MessageBox.Show("Event successfully added and is pending for approval", "Events", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            clearFields();
                            eventPresenter.loadEvents(dataEvents);

                        }
                        else
                        {
                            MessageBox.Show("Please fill up the form correctly", "Events", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        byte is_activated;
                        byte allow_guests;
                        if (switchIsActivated.SwitchState == XanderUI.XUISwitch.State.On)
                        {
                            is_activated = 1;
                        }
                        else
                        {
                            is_activated = 0;
                        }
                        if (checkGuests.Checked)
                        {
                            allow_guests = 1;
                        }
                        else
                        {
                            allow_guests = 0;
                        }

                        eventPresenter.setEvent(txtEventName.Text, txtVenue.Text, txtDate.Text, txtTime.Text,
                            int.Parse(txtStudentRegistrationFee.Text), int.Parse(txtStudentSlots.Text), txtEventDetails.Text,
                            allow_guests, 0, 0, is_activated);
                        eventPresenter.addEvent();
                        MessageBox.Show("Event successfully added", "Events", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                        clearFields();
                        eventPresenter.loadEvents(dataEvents);
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
                        byte is_activated;
                        byte allow_guests;
                        if (switchIsActivated.SwitchState == XanderUI.XUISwitch.State.On)
                        {
                            is_activated = 1;
                        }
                        else
                        {
                            is_activated = 0;
                        }
                        if (checkGuests.Checked)
                        {
                            allow_guests = 1;
                        }
                        else
                        {
                            allow_guests = 0;
                        }
                        eventPresenter.setEvent(txtEventName.Text, txtVenue.Text, txtDate.Text, txtTime.Text,
                            int.Parse(txtStudentRegistrationFee.Text), int.Parse(txtStudentSlots.Text), txtEventDetails.Text,
                            allow_guests, int.Parse(txtGuestRegistrationFee.Text), int.Parse(txtGuestSlots.Text), is_activated);
                        eventPresenter.updateEvent(currentID);
                        MessageBox.Show("Event successfully updated", "Events", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                        clearFields();
                        eventPresenter.loadEvents(dataEvents);

                    }
                    else
                    {
                        MessageBox.Show("Please fill up the form correctly", "Events", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                    }
                }
                else
                {
                    byte is_activated;
                    byte allow_guests;
                    if (switchIsActivated.SwitchState == XanderUI.XUISwitch.State.On)
                    {
                        is_activated = 1;
                    }
                    else
                    {
                        is_activated = 0;
                    }
                    if (checkGuests.Checked)
                    {
                        allow_guests = 1;
                    }
                    else
                    {
                        allow_guests = 0;
                    }

                    eventPresenter.setEvent(txtEventName.Text, txtVenue.Text, txtDate.Text, txtTime.Text,
                        int.Parse(txtStudentRegistrationFee.Text), int.Parse(txtStudentSlots.Text), txtEventDetails.Text, 
                        allow_guests, 0, 0, is_activated);
                    eventPresenter.updateEvent(currentID);
                    MessageBox.Show("Event successfully added", "Events", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    clearFields();
                    eventPresenter.loadEvents(dataEvents);
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

            clearFields();
            eventPresenter.loadEvents(dataEvents);
        }

        private void dataEvents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow dataGridViewRow = dataEvents.Rows[indexRow];
            currentID = int.Parse(dataGridViewRow.Cells[0].Value.ToString());

            if (this.Size == new Size(1576, 956))
            {
                populateFields();
            }
            else
            {
                if(position != "Adviser")
                {
                    if(eventPresenter.checkEventStatus(currentID))
                    {
                        FrmEvents frmEvents = new FrmEvents(position, true, currentID);
                        frmEvents.ShowDialog();
                        eventPresenter.loadEvents(dataEvents);
                    } else
                    {
                        MessageBox.Show("Event is not yet activated", "Events", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else
                {
                    FrmEvents frmEvents = new FrmEvents(position, true, currentID);
                    frmEvents.ShowDialog();
                    eventPresenter.loadEvents(dataEvents);
                }
            }
        }

        private void switchIsActivated_Click(object sender, EventArgs e)
        {
            if(switchIsActivated.SwitchState == XanderUI.XUISwitch.State.On)
            {
                lblSwitchStatus.Text = "Activated";
                activation = 1;
            } else
            {
                lblSwitchStatus.Text = "Deactivated";
                activation = 0;
            }
        }
    }
}
