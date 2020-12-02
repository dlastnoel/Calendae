using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XanderUI;
using Code_Secret_SOEMS.Models;
using Code_Secret_SOEMS.Helpers;

namespace Code_Secret_SOEMS.Presenters
{
    class EventRequestPresenter
    {
        Event _event;
        List<string> listEventIds;
        FlowLayoutPanel flowLayoutEvent;
        ThemeHelper th;

        public EventRequestPresenter(FlowLayoutPanel myFlowLayoutPanel)
        {
            _event = new Event();
            listEventIds = _event.getInactiveEventIds();
            flowLayoutEvent = myFlowLayoutPanel;
            th = new ThemeHelper();
        }

        public void setEventRequests()
        {
            foreach(var eventId in listEventIds)
            {
                _event.selectEvent(int.Parse(eventId));
                Label lblVenue = new Label();
                lblVenue.AutoSize = true;
                lblVenue.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblVenue.Location = new Point(6, 19);
                lblVenue.Name = "lblVenue";
                lblVenue.Size = new Size(46, 15);
                lblVenue.Text = "Venue: " + _event.getEventItems("venue");
                

                Label lblDate = new Label();
                lblDate.AutoSize = true;
                lblDate.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblDate.Location = new Point(6, 39);
                lblDate.Name = "lblDate";
                lblDate.Size = new Size(37, 15);
                lblDate.Text = "Date: " + _event.getEventItems("date");

                Label lblTime = new Label();
                lblTime.AutoSize = true;
                lblTime.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblTime.Location = new Point(6, 59);
                lblTime.Name = "lblTime";
                lblTime.Size = new Size(40, 15);
                lblTime.Text = "Time: " + _event.getEventItems("time");

                Label lblStudentRegistrationFee = new Label();
                lblStudentRegistrationFee.AutoSize = true;
                lblStudentRegistrationFee.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblStudentRegistrationFee.Location = new Point(6, 99);
                lblStudentRegistrationFee.Name = "lblStudentRegistrationFee";
                lblStudentRegistrationFee.Size = new Size(149, 15);
                if(_event.getEventItems("student_registration") != "0")
                {
                    lblStudentRegistrationFee.Text = "Student Registration Fee: Php " + 
                        _event.getEventItems("student_registration");
                } else
                {
                    lblStudentRegistrationFee.Text = "Student Registration Fee: Free";
                }

                Label lblStudentSlots = new Label();
                lblStudentSlots.AutoSize = true;
                lblStudentSlots.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblStudentSlots.Location = new Point(6, 79);
                lblStudentSlots.Name = "lblStudentSlots";
                lblStudentSlots.Size = new Size(86, 15);
                if(_event.getEventItems("student_slots") != "0")
                {
                    lblStudentSlots.Text = "Student Slots: " + _event.getEventItems("student_slots");
                }
                 else
                {
                    lblStudentSlots.Text = "Student Slots: Open";
                }

                Label lblGuestRegistrationFee = new Label();
                lblGuestRegistrationFee.AutoSize = true;
                lblGuestRegistrationFee.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblGuestRegistrationFee.Location = new Point(6, 139);
                lblGuestRegistrationFee.Name = "lblGuestRegistrationFee";
                lblGuestRegistrationFee.Size = new Size(139, 15);

                Label lblGuestSlots = new Label();
                lblGuestSlots.AutoSize = true;
                lblGuestSlots.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblGuestSlots.Location = new Point(6, 119);
                lblGuestSlots.Name = "lblGuestSlots";
                lblGuestSlots.Size = new Size(76, 15);


                if (_event.getEventItems("allow_guests") != "0")
                {
                    if(_event.getEventItems("guest_registration") != "0")
                    {
                        lblGuestRegistrationFee.Text = "Guest Registration Fee: Php " +
                            _event.getEventItems("guest_registration");
                    } else
                    {
                        lblGuestRegistrationFee.Text = "Guest Registration Fee: Free";
                    }
                    if(_event.getEventItems("guest_slots") != "0")
                    {
                        lblGuestSlots.Text = "Guest Slots: " + _event.getEventItems("guest_slots");
                    } else
                    {
                        lblGuestSlots.Text = "Guest Slots: Open";
                    }

                } else
                {
                    lblGuestRegistrationFee.Text = "N/A";
                    lblGuestSlots.Text = "N/A";
                }

                Label lblEventDetails = new Label();
                lblEventDetails.AutoSize = true;
                lblEventDetails.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblEventDetails.Location = new Point(313, 34);
                lblEventDetails.Name = "lblEventDetails";
                lblEventDetails.Size = new Size(81, 15);
                lblEventDetails.Text = "Event Details";

                TextBox txtEventDetails = new TextBox();
                txtEventDetails.BackColor = Color.White;
                txtEventDetails.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                txtEventDetails.Location = new Point(316, 52);
                txtEventDetails.Multiline = true;
                txtEventDetails.Name = "txtEventDetails";
                txtEventDetails.ReadOnly = true;
                txtEventDetails.Size = new Size(302, 102);
                txtEventDetails.Text = _event.getEventItems("event_details");

                Label lblSwitchStatus = new Label();
                lblSwitchStatus.AutoSize = true;
                lblSwitchStatus.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                lblSwitchStatus.Location = new Point(549, 34);
                lblSwitchStatus.Name = "lblSwitchStatus";
                lblSwitchStatus.Size = new Size(69, 14);
                lblSwitchStatus.Text = "Deactivated";

                XUISwitch switchIsActivated = new XUISwitch();
                switchIsActivated.BackColor = Color.Transparent;
                switchIsActivated.HandleOffColor = Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
                switchIsActivated.HandleOnColor = Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
                switchIsActivated.Location = new Point(483, 24);
                switchIsActivated.Name = "switchIsActivated";
                switchIsActivated.OffColor = Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(129)))), ((int)(((byte)(136)))));
                switchIsActivated.OnColor = Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
                switchIsActivated.Size = new Size(60, 28);
                switchIsActivated.SwitchState = XUISwitch.State.Off;
                switchIsActivated.SwitchStyle = XUISwitch.Style.Horizontal;
                switchIsActivated.Text = "xuiSwitch1";
                switchIsActivated.Click += (s, e) => {
                    Event e1 = new Event();
                    if (switchIsActivated.SwitchState == XUISwitch.State.Off)
                    {
                        e1.deactivateEvent(int.Parse(eventId));
                        lblSwitchStatus.Text = "Deactivated";
                    } else
                    {
                        e1.activateEvent(int.Parse(eventId));
                        lblSwitchStatus.Text = "Activated";
                    }
                };

                GroupBox groupEvent = new GroupBox();
                groupEvent.Controls.Add(lblSwitchStatus);
                groupEvent.Controls.Add(txtEventDetails);
                groupEvent.Controls.Add(switchIsActivated);
                groupEvent.Controls.Add(lblEventDetails);
                groupEvent.Controls.Add(lblGuestSlots);
                groupEvent.Controls.Add(lblGuestRegistrationFee);
                groupEvent.Controls.Add(lblStudentSlots);
                groupEvent.Controls.Add(lblStudentRegistrationFee);
                groupEvent.Controls.Add(lblTime);
                groupEvent.Controls.Add(lblDate);
                groupEvent.Controls.Add(lblVenue);
                groupEvent.Font = new Font("Roboto", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                groupEvent.Location = new Point(3, 3);
                groupEvent.Name = "groupEvent";
                groupEvent.Size = new Size(629, 170);
                groupEvent.TabStop = false;
                groupEvent.Text = _event.getEventItems("event_name");

                th.setLabelColor(lblVenue);
                th.setLabelColor(lblDate);
                th.setLabelColor(lblTime);
                th.setLabelColor(lblStudentRegistrationFee);
                th.setLabelColor(lblStudentSlots);
                th.setLabelColor(lblGuestRegistrationFee);
                th.setLabelColor(lblGuestSlots);
                th.setLabelColor(lblEventDetails);
                th.setLabelColor(lblSwitchStatus);
                th.setGroupBoxColor(groupEvent);

                flowLayoutEvent.Controls.Add(groupEvent);
            }
        }

        private void SwitchIsActivated_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
