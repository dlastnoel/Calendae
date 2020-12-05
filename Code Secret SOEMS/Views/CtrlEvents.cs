using System;
using System.Drawing;
using System.Windows.Forms;
using Code_Secret_SOEMS.Helpers;
using Code_Secret_SOEMS.Presenters;

namespace Code_Secret_SOEMS
{
    public partial class CtrlEvents : UserControl
    {
        private EventPresenter eventPresenter;
        private ThemeHelper th;
        private FormHelper fh;
        private int event_id;
        private string position;
        private bool activation;

        public CtrlEvents(string position)
        {
            InitializeComponent();
            eventPresenter = new EventPresenter();
            fh = new FormHelper();
            btnUpdate.Enabled = false;
            btnUpdate.FlatStyle = FlatStyle.Standard;
            btnDelete.Enabled = false;
            btnDelete.FlatStyle = FlatStyle.Standard;
            dateFrom.Value = DateTime.Now.Date;
            dateTo.Value = DateTime.Now.Date;

            this.position = position;
            if(this.position != "Adviser")
            {
                activation = false;
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
            new FrmEvents(this, position, false, 0).ShowDialog();
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
            th.setButtonColor(btnShowDetails);

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

            eventPresenter.loadEvents(dataEvents);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(btnAdd.Text == "Add")
            {
                /*TimeSpan event_date = dateTo.Value.Date.Subtract(dateFrom.Value.Date);
                TimeSpan event_time = timeTo.Value.TimeOfDay - timeFrom.Value.TimeOfDay;
                MessageBox.Show(event_date.TotalDays.ToString());
                MessageBox.Show(event_time.TotalMinutes.ToString());
                MessageBox.Show((DateTime.Today.Date.Subtract(dateFrom.Value.Date).TotalDays).ToString());
                MessageBox.Show((dateTo.Value.Date.Subtract(dateFrom.Value.Date).TotalDays).ToString());*/
                    
                // Check fields
                if (!String.IsNullOrEmpty(txtEventName.Text) && !String.IsNullOrEmpty(txtVenue.Text) && 
                   DateTime.Today.Date.Subtract(dateFrom.Value.Date).TotalDays <= 0 &&
                   dateTo.Value.Date.Subtract(dateFrom.Value.Date).TotalDays >= -0.9 &&
                !String.IsNullOrEmpty(timeFrom.Text) && !String.IsNullOrEmpty(timeTo.Text) && 
                !String.IsNullOrEmpty(txtStudentRegistrationFee.Text) &&
                !String.IsNullOrEmpty(txtStudentSlots.Text) && !String.IsNullOrEmpty(txtEventDetails.Text))
                {
                    if(dateFrom.Value != DateTime.Now.Date)
                    {
                        // Check if allow guest
                        if (checkGuests.Checked)
                        {
                            if (!String.IsNullOrEmpty(txtGuestRegistrationFee.Text) && !String.IsNullOrEmpty(txtGuestSlots.Text))
                            {
                                setEvent(true);
                                eventPresenter.addEvent();
                                if (activation)
                                {
                                    MessageBox.Show("Event successfully added", "Events", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Event successfully with a deactivated status", "Events",
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
                        // Not allow guest
                        else
                        {
                            setEvent(false);
                            eventPresenter.addEvent();
                            if(activation)
                                {
                                MessageBox.Show("Event successfully added", "Events", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                            }
                                else
                            {
                                MessageBox.Show("Event successfully added and is pending for approval", "Events",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            clearFields();
                            eventPresenter.loadEvents(dataEvents);
                        }
                    } else
                    {
                        MessageBox.Show("You cannot set an event happening today", "Events", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if(!String.IsNullOrEmpty(txtEventName.Text) && !String.IsNullOrEmpty(txtVenue.Text) &&
                 !String.IsNullOrEmpty(timeFrom.Text) && !String.IsNullOrEmpty(timeTo.Text) &&
                 !String.IsNullOrEmpty(txtStudentRegistrationFee.Text) &&
                 !String.IsNullOrEmpty(txtStudentSlots.Text) && !String.IsNullOrEmpty(txtEventDetails.Text))
            {
                if (checkGuests.Checked)
                {
                    if (!String.IsNullOrEmpty(txtGuestRegistrationFee.Text) && !String.IsNullOrEmpty(txtGuestSlots.Text))
                    {
                        MessageBox.Show(activation.ToString());
                        setEvent(true);
                        eventPresenter.updateEvent(event_id);
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
                    setEvent(false);
                    eventPresenter.updateEvent(event_id);
                    MessageBox.Show("Event successfully updated", "Events", MessageBoxButtons.OK,
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
            eventPresenter.deleteEvent(event_id);
            MessageBox.Show("Event successfully deleted", "Events", MessageBoxButtons.OK, MessageBoxIcon.Information);

            clearFields();
            eventPresenter.loadEvents(dataEvents);
        }

        private void dataEvents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow dataGridViewRow = dataEvents.Rows[indexRow];
            event_id = int.Parse(dataGridViewRow.Cells[0].Value.ToString());

            if (this.Size == new Size(1576, 956))
            {
                populateFields();
                btnShowDetails.Show();
                eventPresenter.loadEvents(dataEvents);
                txtSearch.Text = "Search";
                txtSearch.ForeColor = Color.Gray;
            }
            else
            {
                if(position != "Adviser")
                {
                    if(eventPresenter.checkEventStatus(event_id))
                    {
                        FrmEvents frmEvents = new FrmEvents(this, position, true, event_id);
                        frmEvents.ShowDialog();
                        eventPresenter.loadEvents(dataEvents);
                        txtSearch.Text = "Search";
                        txtSearch.ForeColor = Color.Gray;
                    } else
                    {
                        MessageBox.Show("Event is not yet activated", "Events", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } else
                {
                    FrmEvents frmEvents = new FrmEvents(this, position, true, event_id);
                    frmEvents.ShowDialog();
                    eventPresenter.loadEvents(dataEvents);
                }
            }
        }

        private void switchIsActivated_Click(object sender, EventArgs e)
        {
            if(event_id != 0)
            {
                eventPresenter.eventActivation(event_id, switchIsActivated, lblSwitchStatus);
                if (switchIsActivated.SwitchState == XanderUI.XUISwitch.State.On)
                {
                    lblSwitchStatus.Text = "Activated";
                }
                else
                {
                    lblSwitchStatus.Text = "Deactivated";
                }
                eventPresenter.loadEvents(dataEvents);
            } else if(position == "Adviser")
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

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            fh.setEventId(event_id);
            fh.setCurrentUserControl(this);
            fh.setUserControl("Event Details",position);
        }

        private void populateFields()
        {
            btnAdd.Text = "Cancel";
            btnUpdate.Enabled = true;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnDelete.Enabled = true;
            btnDelete.FlatStyle = FlatStyle.Flat;
            if (position != "Adviser")
            {
                if (eventPresenter.checkEventStatus(event_id))
                {
                    eventPresenter.prepareEvent(event_id, txtEventName, txtVenue,
                        dateFrom, dateTo, timeFrom, timeTo, txtStudentRegistrationFee, txtStudentSlots, txtEventDetails,
                        checkGuests, txtGuestRegistrationFee, txtGuestSlots, switchIsActivated, lblSwitchStatus);
                }
                else
                {
                    MessageBox.Show("Action restricted. Please wait until event is activated", "Events", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                eventPresenter.prepareEvent(event_id, txtEventName, txtVenue, dateFrom, dateTo,
                    timeFrom, timeTo, txtStudentRegistrationFee, txtStudentSlots, txtEventDetails, checkGuests,
                    txtGuestRegistrationFee, txtGuestSlots, switchIsActivated, lblSwitchStatus);
            }

            if (checkGuests.Checked)
            {
                groupGuests.Enabled = true;
            }
            else
            {
                groupGuests.Enabled = false;
            }

        }
        private void clearFields()
        {
            event_id = 0;
            txtEventName.Clear();
            txtVenue.Clear();
            txtStudentRegistrationFee.Clear();
            txtStudentSlots.Clear();
            txtEventDetails.Clear();
            checkGuests.Checked = false;
            txtGuestRegistrationFee.Clear();
            txtGuestSlots.Clear();
            switchIsActivated.SwitchState = XanderUI.XUISwitch.State.Off;
            lblSwitchStatus.Text = "Deactivated";
            dateFrom.Value = DateTime.Now.Date;
            dateTo.Value = DateTime.Now.Date;

            btnAdd.Text = "Add";
            btnUpdate.Enabled = false;
            btnUpdate.FlatStyle = FlatStyle.Standard;
            btnDelete.Enabled = false;
            btnDelete.FlatStyle = FlatStyle.Standard;
            btnShowDetails.Hide();
        }

        private void setEvent(bool guests)
        {
            int guest_fee;
            int guest_slots;

            if (guests)
            {
                guest_fee = int.Parse(txtGuestRegistrationFee.Text);
                guest_slots = int.Parse(txtGuestSlots.Text);
            } else
            {
                guest_fee = 0;
                guest_slots = 0;
            }
            eventPresenter.setEvent(txtEventName.Text, txtVenue.Text, dateFrom.Text, dateTo.Text,
                timeFrom.Text, timeTo.Text, int.Parse(txtStudentRegistrationFee.Text),
                int.Parse(txtStudentSlots.Text), txtEventDetails.Text, guests,
                guest_fee, guest_slots, activation);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtSearch.Text))
            {
                eventPresenter.searchEvent(txtSearch.Text, dataEvents);
            } else
            {
                eventPresenter.loadEvents(dataEvents);
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if(txtSearch.Text == "Search")
            {
                txtSearch.Clear();
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtSearch.Text))
            {
                txtSearch.Text = "Search";
                txtSearch.ForeColor = Color.Gray;
            }
        }
    }
}
