using System;
using System.Drawing;
using System.Windows.Forms;
using Code_Secret_SOEMS.Presenters;
using Code_Secret_SOEMS.Helpers;

namespace Code_Secret_SOEMS
{
    public partial class FrmEvents : Form
    {
        private EventPresenter eventPresenter;
        private ThemeHelper th;
        private FormHelper fh;
        private UserControl currentUserControl;
        private string position;
        private int event_id;
        private bool activation;

        public FrmEvents(UserControl userControl, string position, bool update, int id)
        {
            InitializeComponent();
            th = new ThemeHelper();
            eventPresenter = new EventPresenter();
            fh = new FormHelper();
            th.setFormColor(this);
            th.setPanelColor(panelTop);
            th.setGroupBoxColor(groupEventInfo);
            th.setGroupBoxColor(groupGuests);
            th.setCheckBoxColor(checkGuests);
            th.setButtonColor(btnAdd);
            th.setButtonColor(btnUpdate);
            th.setButtonColor(btnDelete);
            th.setButtonColor(btnShowDetails);

            th.setLabelColor(lblEventName);
            th.setLabelColor(lblVenue);
            th.setLabelColor(lblDate);
            th.setLabelColor(lblTime);
            th.setLabelColor(lblTime);
            th.setLabelColor(lblStudentRegistrationFee);
            th.setLabelColor(lblStudentSlots);
            th.setLabelColor(lblGuestRegistrationFee);
            th.setLabelColor(lblGuestSlots);

            event_id = id;
            this.position = position;
            if (this.position != "Adviser")
            {
                activation = false;
                switchIsActivated.Hide();
                lblStatus.Hide();
                lblSwitchStatus.Hide();
                this.Size = new Size(614, 673);
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
                this.Size = new Size(614, 673);
            }
            currentUserControl = userControl;
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
                /*TimeSpan event_date = dateTo.Value.Date.Subtract(dateFrom.Value.Date);
                TimeSpan event_time = timeTo.Value.TimeOfDay - timeFrom.Value.TimeOfDay;
                MessageBox.Show(event_date.TotalDays.ToString());
                MessageBox.Show(event_time.TotalMinutes.ToString());*/
                MessageBox.Show((DateTime.Today.Date.Subtract(dateFrom.Value.Date).TotalDays).ToString());
                MessageBox.Show((dateTo.Value.Date.Subtract(dateFrom.Value.Date).TotalDays).ToString());
                if (!String.IsNullOrEmpty(txtEventName.Text) && !String.IsNullOrEmpty(txtVenue.Text) &&
                   DateTime.Today.Date.Subtract(dateFrom.Value.Date).TotalDays <= 0 &&
                   dateTo.Value.Date.Subtract(dateFrom.Value.Date).TotalDays >= -0.9 &&
                !String.IsNullOrEmpty(timeFrom.Text) && !String.IsNullOrEmpty(timeTo.Text) &&
                !String.IsNullOrEmpty(txtStudentRegistrationFee.Text) &&
                !String.IsNullOrEmpty(txtStudentSlots.Text) && !String.IsNullOrEmpty(txtEventDetails.Text))
                {
                    if (dateFrom.Value != DateTime.Now.Date)
                    {
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
                            setEvent(false);
                            eventPresenter.addEvent();
                            MessageBox.Show("Event successfully added", "Events", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                            this.Close();
                        }
                    }
                    else
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
            }
            else
            {
                clearFields();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtEventName.Text) && !String.IsNullOrEmpty(txtVenue.Text) &&
                 !String.IsNullOrEmpty(timeFrom.Text) && !String.IsNullOrEmpty(timeTo.Text) &&
                 !String.IsNullOrEmpty(txtStudentRegistrationFee.Text) &&
                 !String.IsNullOrEmpty(txtStudentSlots.Text) && !String.IsNullOrEmpty(txtEventDetails.Text))
            {
                if (checkGuests.Checked)
                {
                    if (!String.IsNullOrEmpty(txtGuestRegistrationFee.Text) && !String.IsNullOrEmpty(txtGuestSlots.Text))
                    {
                        setEvent(true);
                        eventPresenter.updateEvent(event_id);
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
                    setEvent(false);
                    eventPresenter.updateEvent(event_id);
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
            eventPresenter.deleteEvent(event_id);
            MessageBox.Show("Event successfully deleted", "Events", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void switchIsActivated_Click(object sender, EventArgs e)
        {
            if(event_id != 0)
            {
                eventPresenter.eventActivation(event_id, switchIsActivated, lblSwitchStatus);
            } else
            {
                if(switchIsActivated.SwitchState == XanderUI.XUISwitch.State.On)
                {
                    lblSwitchStatus.Text = "Activated";
                } else
                {
                    lblSwitchStatus.Text = "Deactivated";
                }
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

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            this.Close();
            fh.setEventId(event_id);
            fh.setCurrentUserControl(currentUserControl);
            fh.setUserControl("Event Details", position);
        }

        private void populateFields()
        {
            btnAdd.Enabled = false;
            btnAdd.FlatStyle = FlatStyle.Standard;
            btnUpdate.Enabled = true;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnDelete.Enabled = true;
            btnDelete.FlatStyle = FlatStyle.Flat;
            eventPresenter.prepareEvent(event_id, txtEventName, txtVenue, dateFrom, dateTo,
                timeFrom, timeTo, txtStudentRegistrationFee, txtStudentSlots, txtEventDetails, checkGuests,
                txtGuestRegistrationFee, txtGuestSlots, switchIsActivated, lblSwitchStatus);
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
        }

        private void setEvent(bool guests)
        {
            int guest_fee;
            int guest_slots;

            if (guests)
            {
                guest_fee = int.Parse(txtGuestRegistrationFee.Text);
                guest_slots = int.Parse(txtGuestSlots.Text);
            }
            else
            {
                guest_fee = 0;
                guest_slots = 0;
            }
            eventPresenter.setEvent(txtEventName.Text, txtVenue.Text, dateFrom.Text, dateTo.Text,
                timeFrom.Text, timeTo.Text, int.Parse(txtStudentRegistrationFee.Text),
                int.Parse(txtStudentSlots.Text), txtEventDetails.Text, guests,
                guest_fee, guest_slots, activation);
        }
    }
}
