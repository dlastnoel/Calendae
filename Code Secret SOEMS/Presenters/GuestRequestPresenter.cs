using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS.Models;
using XanderUI;
using Code_Secret_SOEMS.Helpers;

namespace Code_Secret_SOEMS.Presenters
{
    class GuestRequestPresenter
    {
        Guest _guest;
        Event _event;
        EventDetails _eventDetails;
        List<string> listGuestId;
        FlowLayoutPanel flowLayoutGuest;
        ThemeHelper th;


        public GuestRequestPresenter(FlowLayoutPanel myFlowLayoutPanel)
        {
            _guest = new Guest();
            listGuestId = _guest.getInactiveGuestIds();
            _event = new Event();
            _eventDetails = new EventDetails();
            flowLayoutGuest = myFlowLayoutPanel;
            th = new ThemeHelper();
        }

        public void registerGuest(int event_id, int guest_id)
        {
            _eventDetails.event_id = event_id;
            _eventDetails.guest_id = guest_id;
            _eventDetails.addGuestParticipant();
        }

        public void setGuestRequests()
        {
            foreach(var guestId in listGuestId)
            {
                _guest.selectGuest(int.Parse(guestId));

                Label lblEventName = new Label();
                lblEventName.AutoSize = true;
                lblEventName.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblEventName.Location = new Point(9, 5);
                lblEventName.Name = "lblEventName";
                lblEventName.Size = new Size(41, 15);
                lblEventName.Text = "Event: " + _guest.getGuestDetails("event_name");

                Label lblFullName = new Label();
                lblFullName.AutoSize = true;
                lblFullName.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblFullName.Location = new Point(9, 25);
                lblFullName.Name = "lblFullName";
                lblFullName.Size = new Size(68, 15);
                lblFullName.Text = "Full Name: " + _guest.getGuestDetails("first_name") + " " +
                    _guest.getGuestDetails("middle_name") + " " + _guest.getGuestDetails("last_name");

                Label lblGender = new Label();
                lblGender.AutoSize = true;
                lblGender.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblGender.Location = new Point(9, 45);
                lblGender.Name = "lblGender";
                lblGender.Size = new Size(57, 15);
                if(_guest.getGuestDetails("gender") == "M")
                {
                    lblGender.Text = "Gender: Male" ;
                } else
                {
                    lblGender.Text = "Gender: Female";
                }

                Label lblAddress = new Label();
                lblAddress.AutoSize = true;
                lblAddress.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblAddress.Location = new Point(8, 65);
                lblAddress.Name = "lblAddress";
                lblAddress.Size = new Size(51, 15);
                lblAddress.Text = "Address: " + _guest.getGuestDetails("address");

                Label lblContactNo = new Label();
                lblContactNo.AutoSize = true;
                lblContactNo.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblContactNo.Location = new Point(9, 85);
                lblContactNo.Name = "lblContactNo";
                lblContactNo.Size = new Size(103, 15);
                lblContactNo.Text = "Contact Number: " + _guest.getGuestDetails("contact");

                Label lblEmailAddress = new Label();
                lblEmailAddress.AutoSize = true;
                lblEmailAddress.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblEmailAddress.Location = new Point(9, 105);
                lblEmailAddress.Name = "lblEmailAddress";
                lblEmailAddress.Size = new Size(92, 15);
                lblEmailAddress.Text = "Email Address: " + _guest.getGuestDetails("email");

                Label lblInfo1 = new Label();
                lblInfo1.AutoSize = true;
                lblInfo1.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblInfo1.Location = new Point(8, 125);
                lblInfo1.Name = "lblInfo1";
                lblInfo1.Size = new Size(38, 15);

                Label lblInfo2 = new Label();
                lblInfo2.AutoSize = true;
                lblInfo2.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblInfo2.Location = new Point(8, 145);
                lblInfo2.Name = "lblInfo2";
                lblInfo2.Size = new Size(38, 15);
                if (!String.IsNullOrEmpty(_guest.getGuestDetails("school_name")))
                {
                    lblInfo1.Text = "School Name: " + _guest.getGuestDetails("school_name");
                    lblInfo2.Text = "Course & Year: " + _guest.getGuestDetails("course") + " - " + 
                        _guest.getGuestDetails("year");
                } else
                {
                    lblInfo1.Text = "Works at: " + _guest.getGuestDetails("works_at");
                    lblInfo2.Text = "Position: " + _guest.getGuestDetails("position");
                }

                Label lblSwitchStatus = new Label();
                lblSwitchStatus.AutoSize = true;
                lblSwitchStatus.Font = new Font("Roboto", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                lblSwitchStatus.Location = new Point(369, 20);
                lblSwitchStatus.Name = "lblSwitchStatus";
                lblSwitchStatus.Size = new Size(69, 14);
                lblSwitchStatus.Text = "Deactivated";

                XUISwitch switchIsActivated = new XUISwitch();
                switchIsActivated.BackColor = Color.Transparent;
                switchIsActivated.HandleOffColor = Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
                switchIsActivated.HandleOnColor = Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
                switchIsActivated.Location = new Point(303, 12);
                switchIsActivated.Name = "switchIsActivated";
                switchIsActivated.OffColor = Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(129)))), ((int)(((byte)(136)))));
                switchIsActivated.OnColor = Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
                switchIsActivated.Size = new Size(60, 28);
                switchIsActivated.SwitchState = XanderUI.XUISwitch.State.Off;
                switchIsActivated.SwitchStyle = XanderUI.XUISwitch.Style.Horizontal;
                switchIsActivated.Text = "xuiSwitch1";
                switchIsActivated.Click += (s, e) => {
                    Guest g1 = new Guest();
                    if (switchIsActivated.SwitchState == XUISwitch.State.Off)
                    {
                        g1.deactivateGuest(int.Parse(guestId));
                        lblSwitchStatus.Text = "Deactivated";
                        g1.deactivateGuest(int.Parse(guestId));
                        _eventDetails.removeGuestParticipant(int.Parse(guestId));
                    }
                    else
                    {
                        g1.activateGuest(int.Parse(guestId));
                        _event.selectEventByName(_guest.getGuestDetails("event_name"));
                        int event_id = int.Parse(_event.getEventItems("id"));
                        registerGuest(event_id, int.Parse(guestId));
                        lblSwitchStatus.Text = "Activated";
                    }
                };
                
                Panel panelGuest = new Panel();
                panelGuest.Controls.Add(lblSwitchStatus);
                panelGuest.Controls.Add(lblEventName);
                panelGuest.Controls.Add(switchIsActivated);
                panelGuest.Controls.Add(lblInfo1);
                panelGuest.Controls.Add(lblInfo2);
                panelGuest.Controls.Add(lblAddress);
                panelGuest.Controls.Add(lblEmailAddress);
                panelGuest.Controls.Add(lblContactNo);
                panelGuest.Controls.Add(lblFullName);
                panelGuest.Controls.Add(lblGender);
                panelGuest.Location = new Point(3, 3);
                panelGuest.Name = "panelGuest";
                panelGuest.BorderStyle = BorderStyle.FixedSingle;
                panelGuest.Size = new Size(458, 166);

                th.setLabelColor(lblEventName);
                th.setLabelColor(lblFullName);
                th.setLabelColor(lblGender);
                th.setLabelColor(lblAddress);
                th.setLabelColor(lblContactNo);
                th.setLabelColor(lblEmailAddress);
                th.setLabelColor(lblInfo1);
                th.setLabelColor(lblInfo2);
                th.setLabelColor(lblSwitchStatus);

                flowLayoutGuest.Controls.Add(panelGuest);

            }
        }
    }
}
