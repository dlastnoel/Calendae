namespace Code_Secret_SOEMS
{
    partial class FrmEvents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupEventInfo = new System.Windows.Forms.GroupBox();
            this.lblSwitchStatus = new System.Windows.Forms.Label();
            this.switchIsActivated = new XanderUI.XUISwitch();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblEventDetails = new System.Windows.Forms.Label();
            this.txtEventDetails = new System.Windows.Forms.TextBox();
            this.txtStudentSlots = new System.Windows.Forms.TextBox();
            this.lblStudentSlots = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblStudentRegistrationFee = new System.Windows.Forms.Label();
            this.txtStudentRegistrationFee = new System.Windows.Forms.TextBox();
            this.checkGuests = new System.Windows.Forms.CheckBox();
            this.groupGuests = new System.Windows.Forms.GroupBox();
            this.lblInfo4 = new System.Windows.Forms.Label();
            this.txtGuestSlots = new System.Windows.Forms.TextBox();
            this.lblInfo3 = new System.Windows.Forms.Label();
            this.lblGuestSlots = new System.Windows.Forms.Label();
            this.lblGuestRegistrationFee = new System.Windows.Forms.Label();
            this.txtGuestRegistrationFee = new System.Windows.Forms.TextBox();
            this.panelTop.SuspendLayout();
            this.groupEventInfo.SuspendLayout();
            this.groupGuests.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DarkOrange;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.btnBack);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(614, 30);
            this.panelTop.TabIndex = 41;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 20);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "EVENT FORM";
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(591, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(23, 30);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(310, 682);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(292, 41);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(11, 635);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(591, 41);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(11, 682);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(292, 41);
            this.btnUpdate.TabIndex = 44;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupEventInfo
            // 
            this.groupEventInfo.Controls.Add(this.lblSwitchStatus);
            this.groupEventInfo.Controls.Add(this.switchIsActivated);
            this.groupEventInfo.Controls.Add(this.lblStatus);
            this.groupEventInfo.Controls.Add(this.lblEventDetails);
            this.groupEventInfo.Controls.Add(this.txtEventDetails);
            this.groupEventInfo.Controls.Add(this.txtStudentSlots);
            this.groupEventInfo.Controls.Add(this.lblStudentSlots);
            this.groupEventInfo.Controls.Add(this.txtEventName);
            this.groupEventInfo.Controls.Add(this.lblEventName);
            this.groupEventInfo.Controls.Add(this.lblVenue);
            this.groupEventInfo.Controls.Add(this.txtTime);
            this.groupEventInfo.Controls.Add(this.txtVenue);
            this.groupEventInfo.Controls.Add(this.lblTime);
            this.groupEventInfo.Controls.Add(this.lblDate);
            this.groupEventInfo.Controls.Add(this.txtDate);
            this.groupEventInfo.Controls.Add(this.lblStudentRegistrationFee);
            this.groupEventInfo.Controls.Add(this.txtStudentRegistrationFee);
            this.groupEventInfo.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupEventInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupEventInfo.Location = new System.Drawing.Point(11, 36);
            this.groupEventInfo.Name = "groupEventInfo";
            this.groupEventInfo.Size = new System.Drawing.Size(591, 434);
            this.groupEventInfo.TabIndex = 47;
            this.groupEventInfo.TabStop = false;
            this.groupEventInfo.Text = "Event Information";
            // 
            // lblSwitchStatus
            // 
            this.lblSwitchStatus.AutoSize = true;
            this.lblSwitchStatus.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwitchStatus.Location = new System.Drawing.Point(165, 400);
            this.lblSwitchStatus.Name = "lblSwitchStatus";
            this.lblSwitchStatus.Size = new System.Drawing.Size(69, 14);
            this.lblSwitchStatus.TabIndex = 39;
            this.lblSwitchStatus.Text = "Deactivated";
            // 
            // switchIsActivated
            // 
            this.switchIsActivated.BackColor = System.Drawing.Color.Transparent;
            this.switchIsActivated.HandleOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.switchIsActivated.HandleOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.switchIsActivated.Location = new System.Drawing.Point(99, 390);
            this.switchIsActivated.Name = "switchIsActivated";
            this.switchIsActivated.OffColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(129)))), ((int)(((byte)(136)))));
            this.switchIsActivated.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.switchIsActivated.Size = new System.Drawing.Size(60, 30);
            this.switchIsActivated.SwitchState = XanderUI.XUISwitch.State.Off;
            this.switchIsActivated.SwitchStyle = XanderUI.XUISwitch.Style.Horizontal;
            this.switchIsActivated.TabIndex = 8;
            this.switchIsActivated.Text = "xuiSwitch1";
            this.switchIsActivated.Click += new System.EventHandler(this.switchIsActivated_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(43, 400);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 15);
            this.lblStatus.TabIndex = 37;
            this.lblStatus.Text = "Status: ";
            // 
            // lblEventDetails
            // 
            this.lblEventDetails.AutoSize = true;
            this.lblEventDetails.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDetails.Location = new System.Drawing.Point(40, 217);
            this.lblEventDetails.Name = "lblEventDetails";
            this.lblEventDetails.Size = new System.Drawing.Size(81, 15);
            this.lblEventDetails.TabIndex = 36;
            this.lblEventDetails.Text = "Event Details";
            // 
            // txtEventDetails
            // 
            this.txtEventDetails.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventDetails.Location = new System.Drawing.Point(43, 235);
            this.txtEventDetails.Multiline = true;
            this.txtEventDetails.Name = "txtEventDetails";
            this.txtEventDetails.Size = new System.Drawing.Size(487, 150);
            this.txtEventDetails.TabIndex = 7;
            // 
            // txtStudentSlots
            // 
            this.txtStudentSlots.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentSlots.Location = new System.Drawing.Point(317, 191);
            this.txtStudentSlots.Name = "txtStudentSlots";
            this.txtStudentSlots.Size = new System.Drawing.Size(213, 23);
            this.txtStudentSlots.TabIndex = 6;
            // 
            // lblStudentSlots
            // 
            this.lblStudentSlots.AutoSize = true;
            this.lblStudentSlots.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentSlots.Location = new System.Drawing.Point(314, 173);
            this.lblStudentSlots.Name = "lblStudentSlots";
            this.lblStudentSlots.Size = new System.Drawing.Size(36, 15);
            this.lblStudentSlots.TabIndex = 18;
            this.lblStudentSlots.Text = "Slots";
            // 
            // txtEventName
            // 
            this.txtEventName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.Location = new System.Drawing.Point(43, 59);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(487, 23);
            this.txtEventName.TabIndex = 1;
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(40, 41);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(76, 15);
            this.lblEventName.TabIndex = 16;
            this.lblEventName.Text = "Event Name";
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.Location = new System.Drawing.Point(40, 85);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(43, 15);
            this.lblVenue.TabIndex = 1;
            this.lblVenue.Text = "Venue";
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(317, 147);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(213, 23);
            this.txtTime.TabIndex = 4;
            // 
            // txtVenue
            // 
            this.txtVenue.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenue.Location = new System.Drawing.Point(43, 103);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(487, 23);
            this.txtVenue.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(314, 129);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(37, 15);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(40, 129);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(34, 15);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(43, 147);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(213, 23);
            this.txtDate.TabIndex = 3;
            // 
            // lblStudentRegistrationFee
            // 
            this.lblStudentRegistrationFee.AutoSize = true;
            this.lblStudentRegistrationFee.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentRegistrationFee.Location = new System.Drawing.Point(40, 173);
            this.lblStudentRegistrationFee.Name = "lblStudentRegistrationFee";
            this.lblStudentRegistrationFee.Size = new System.Drawing.Size(99, 15);
            this.lblStudentRegistrationFee.TabIndex = 5;
            this.lblStudentRegistrationFee.Text = "Registration Fee";
            // 
            // txtStudentRegistrationFee
            // 
            this.txtStudentRegistrationFee.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentRegistrationFee.Location = new System.Drawing.Point(43, 191);
            this.txtStudentRegistrationFee.Name = "txtStudentRegistrationFee";
            this.txtStudentRegistrationFee.Size = new System.Drawing.Size(213, 23);
            this.txtStudentRegistrationFee.TabIndex = 5;
            // 
            // checkGuests
            // 
            this.checkGuests.AutoSize = true;
            this.checkGuests.Location = new System.Drawing.Point(19, 477);
            this.checkGuests.Name = "checkGuests";
            this.checkGuests.Size = new System.Drawing.Size(15, 14);
            this.checkGuests.TabIndex = 40;
            this.checkGuests.UseVisualStyleBackColor = true;
            this.checkGuests.CheckedChanged += new System.EventHandler(this.checkGuests_CheckedChanged_1);
            // 
            // groupGuests
            // 
            this.groupGuests.Controls.Add(this.lblInfo4);
            this.groupGuests.Controls.Add(this.txtGuestSlots);
            this.groupGuests.Controls.Add(this.lblInfo3);
            this.groupGuests.Controls.Add(this.lblGuestSlots);
            this.groupGuests.Controls.Add(this.lblGuestRegistrationFee);
            this.groupGuests.Controls.Add(this.txtGuestRegistrationFee);
            this.groupGuests.Enabled = false;
            this.groupGuests.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupGuests.Location = new System.Drawing.Point(7, 476);
            this.groupGuests.Name = "groupGuests";
            this.groupGuests.Size = new System.Drawing.Size(591, 153);
            this.groupGuests.TabIndex = 41;
            this.groupGuests.TabStop = false;
            this.groupGuests.Text = "       Allow Guests?";
            // 
            // lblInfo4
            // 
            this.lblInfo4.AutoSize = true;
            this.lblInfo4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo4.ForeColor = System.Drawing.Color.Black;
            this.lblInfo4.Location = new System.Drawing.Point(44, 114);
            this.lblInfo4.Name = "lblInfo4";
            this.lblInfo4.Size = new System.Drawing.Size(175, 13);
            this.lblInfo4.TabIndex = 34;
            this.lblInfo4.Text = "Leave slots empty for unlimited slots";
            // 
            // txtGuestSlots
            // 
            this.txtGuestSlots.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestSlots.Location = new System.Drawing.Point(321, 61);
            this.txtGuestSlots.Name = "txtGuestSlots";
            this.txtGuestSlots.Size = new System.Drawing.Size(213, 23);
            this.txtGuestSlots.TabIndex = 11;
            // 
            // lblInfo3
            // 
            this.lblInfo3.AutoSize = true;
            this.lblInfo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo3.ForeColor = System.Drawing.Color.Black;
            this.lblInfo3.Location = new System.Drawing.Point(44, 96);
            this.lblInfo3.Name = "lblInfo3";
            this.lblInfo3.Size = new System.Drawing.Size(198, 13);
            this.lblInfo3.TabIndex = 33;
            this.lblInfo3.Text = "Leave registration fee empty to set it free";
            // 
            // lblGuestSlots
            // 
            this.lblGuestSlots.AutoSize = true;
            this.lblGuestSlots.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestSlots.Location = new System.Drawing.Point(318, 43);
            this.lblGuestSlots.Name = "lblGuestSlots";
            this.lblGuestSlots.Size = new System.Drawing.Size(36, 15);
            this.lblGuestSlots.TabIndex = 18;
            this.lblGuestSlots.Text = "Slots";
            // 
            // lblGuestRegistrationFee
            // 
            this.lblGuestRegistrationFee.AutoSize = true;
            this.lblGuestRegistrationFee.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestRegistrationFee.Location = new System.Drawing.Point(44, 43);
            this.lblGuestRegistrationFee.Name = "lblGuestRegistrationFee";
            this.lblGuestRegistrationFee.Size = new System.Drawing.Size(99, 15);
            this.lblGuestRegistrationFee.TabIndex = 5;
            this.lblGuestRegistrationFee.Text = "Registration Fee";
            // 
            // txtGuestRegistrationFee
            // 
            this.txtGuestRegistrationFee.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestRegistrationFee.Location = new System.Drawing.Point(47, 61);
            this.txtGuestRegistrationFee.Name = "txtGuestRegistrationFee";
            this.txtGuestRegistrationFee.Size = new System.Drawing.Size(213, 23);
            this.txtGuestRegistrationFee.TabIndex = 10;
            // 
            // FrmEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 740);
            this.Controls.Add(this.checkGuests);
            this.Controls.Add(this.groupEventInfo);
            this.Controls.Add(this.groupGuests);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEvents";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEvents";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.groupEventInfo.ResumeLayout(false);
            this.groupEventInfo.PerformLayout();
            this.groupGuests.ResumeLayout(false);
            this.groupGuests.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupEventInfo;
        private System.Windows.Forms.Label lblSwitchStatus;
        private XanderUI.XUISwitch switchIsActivated;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblEventDetails;
        private System.Windows.Forms.TextBox txtEventDetails;
        private System.Windows.Forms.TextBox txtStudentSlots;
        private System.Windows.Forms.Label lblStudentSlots;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblStudentRegistrationFee;
        private System.Windows.Forms.TextBox txtStudentRegistrationFee;
        private System.Windows.Forms.CheckBox checkGuests;
        private System.Windows.Forms.GroupBox groupGuests;
        private System.Windows.Forms.Label lblInfo4;
        private System.Windows.Forms.TextBox txtGuestSlots;
        private System.Windows.Forms.Label lblInfo3;
        private System.Windows.Forms.Label lblGuestSlots;
        private System.Windows.Forms.Label lblGuestRegistrationFee;
        private System.Windows.Forms.TextBox txtGuestRegistrationFee;
    }
}