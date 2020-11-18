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
            this.groupGuests = new System.Windows.Forms.GroupBox();
            this.txtGuestSlots = new System.Windows.Forms.TextBox();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblGuestSlots = new System.Windows.Forms.Label();
            this.lblGuestRegistrationFee = new System.Windows.Forms.Label();
            this.txtGuestRegistraionFree = new System.Windows.Forms.TextBox();
            this.checkGuests = new System.Windows.Forms.CheckBox();
            this.groupEventInfo = new System.Windows.Forms.GroupBox();
            this.lblEventDetails = new System.Windows.Forms.Label();
            this.txtEventDetails = new System.Windows.Forms.TextBox();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.txtStudentSlots = new System.Windows.Forms.TextBox();
            this.lblStudentSlots = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.txtDateFrom = new System.Windows.Forms.TextBox();
            this.lblStudentRegistrationFee = new System.Windows.Forms.Label();
            this.txtStudentRegistration = new System.Windows.Forms.TextBox();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.txtDateTo = new System.Windows.Forms.TextBox();
            this.panelTop.SuspendLayout();
            this.groupGuests.SuspendLayout();
            this.groupEventInfo.SuspendLayout();
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
            // 
            // groupGuests
            // 
            this.groupGuests.Controls.Add(this.txtGuestSlots);
            this.groupGuests.Controls.Add(this.lblInfo1);
            this.groupGuests.Controls.Add(this.lblInfo2);
            this.groupGuests.Controls.Add(this.lblGuestSlots);
            this.groupGuests.Controls.Add(this.lblGuestRegistrationFee);
            this.groupGuests.Controls.Add(this.txtGuestRegistraionFree);
            this.groupGuests.Enabled = false;
            this.groupGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupGuests.Location = new System.Drawing.Point(11, 484);
            this.groupGuests.Name = "groupGuests";
            this.groupGuests.Size = new System.Drawing.Size(591, 145);
            this.groupGuests.TabIndex = 43;
            this.groupGuests.TabStop = false;
            this.groupGuests.Text = "       Allow Guests?";
            // 
            // txtGuestSlots
            // 
            this.txtGuestSlots.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestSlots.Location = new System.Drawing.Point(317, 66);
            this.txtGuestSlots.Name = "txtGuestSlots";
            this.txtGuestSlots.Size = new System.Drawing.Size(213, 22);
            this.txtGuestSlots.TabIndex = 19;
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.ForeColor = System.Drawing.Color.Black;
            this.lblInfo1.Location = new System.Drawing.Point(40, 101);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(198, 13);
            this.lblInfo1.TabIndex = 33;
            this.lblInfo1.Text = "Leave registration fee empty to set it free";
            // 
            // lblGuestSlots
            // 
            this.lblGuestSlots.AutoSize = true;
            this.lblGuestSlots.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestSlots.Location = new System.Drawing.Point(314, 48);
            this.lblGuestSlots.Name = "lblGuestSlots";
            this.lblGuestSlots.Size = new System.Drawing.Size(38, 16);
            this.lblGuestSlots.TabIndex = 18;
            this.lblGuestSlots.Text = "Slots";
            // 
            // lblGuestRegistrationFee
            // 
            this.lblGuestRegistrationFee.AutoSize = true;
            this.lblGuestRegistrationFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestRegistrationFee.Location = new System.Drawing.Point(40, 48);
            this.lblGuestRegistrationFee.Name = "lblGuestRegistrationFee";
            this.lblGuestRegistrationFee.Size = new System.Drawing.Size(107, 16);
            this.lblGuestRegistrationFee.TabIndex = 5;
            this.lblGuestRegistrationFee.Text = "Registration Fee";
            // 
            // txtGuestRegistraionFree
            // 
            this.txtGuestRegistraionFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestRegistraionFree.Location = new System.Drawing.Point(43, 66);
            this.txtGuestRegistraionFree.Name = "txtGuestRegistraionFree";
            this.txtGuestRegistraionFree.Size = new System.Drawing.Size(213, 22);
            this.txtGuestRegistraionFree.TabIndex = 6;
            // 
            // checkGuests
            // 
            this.checkGuests.AutoSize = true;
            this.checkGuests.Location = new System.Drawing.Point(22, 483);
            this.checkGuests.Name = "checkGuests";
            this.checkGuests.Size = new System.Drawing.Size(15, 14);
            this.checkGuests.TabIndex = 36;
            this.checkGuests.UseVisualStyleBackColor = true;
            this.checkGuests.CheckedChanged += new System.EventHandler(this.checkGuests_CheckedChanged);
            // 
            // groupEventInfo
            // 
            this.groupEventInfo.Controls.Add(this.lblDateTo);
            this.groupEventInfo.Controls.Add(this.txtDateTo);
            this.groupEventInfo.Controls.Add(this.lblEventDetails);
            this.groupEventInfo.Controls.Add(this.txtEventDetails);
            this.groupEventInfo.Controls.Add(this.txtStudentSlots);
            this.groupEventInfo.Controls.Add(this.lblStudentSlots);
            this.groupEventInfo.Controls.Add(this.lblTime);
            this.groupEventInfo.Controls.Add(this.txtEventName);
            this.groupEventInfo.Controls.Add(this.txtTime);
            this.groupEventInfo.Controls.Add(this.lblEventName);
            this.groupEventInfo.Controls.Add(this.lblVenue);
            this.groupEventInfo.Controls.Add(this.txtVenue);
            this.groupEventInfo.Controls.Add(this.lblDateFrom);
            this.groupEventInfo.Controls.Add(this.txtDateFrom);
            this.groupEventInfo.Controls.Add(this.lblStudentRegistrationFee);
            this.groupEventInfo.Controls.Add(this.txtStudentRegistration);
            this.groupEventInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupEventInfo.Location = new System.Drawing.Point(12, 36);
            this.groupEventInfo.Name = "groupEventInfo";
            this.groupEventInfo.Size = new System.Drawing.Size(591, 441);
            this.groupEventInfo.TabIndex = 47;
            this.groupEventInfo.TabStop = false;
            this.groupEventInfo.Text = "Event Information";
            // 
            // lblEventDetails
            // 
            this.lblEventDetails.AutoSize = true;
            this.lblEventDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDetails.Location = new System.Drawing.Point(40, 261);
            this.lblEventDetails.Name = "lblEventDetails";
            this.lblEventDetails.Size = new System.Drawing.Size(87, 16);
            this.lblEventDetails.TabIndex = 36;
            this.lblEventDetails.Text = "Event Details";
            // 
            // txtEventDetails
            // 
            this.txtEventDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventDetails.Location = new System.Drawing.Point(43, 279);
            this.txtEventDetails.Multiline = true;
            this.txtEventDetails.Name = "txtEventDetails";
            this.txtEventDetails.Size = new System.Drawing.Size(487, 137);
            this.txtEventDetails.TabIndex = 35;
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo2.ForeColor = System.Drawing.Color.Black;
            this.lblInfo2.Location = new System.Drawing.Point(40, 114);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(175, 13);
            this.lblInfo2.TabIndex = 34;
            this.lblInfo2.Text = "Leave slots empty for unlimited slots";
            // 
            // txtStudentSlots
            // 
            this.txtStudentSlots.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentSlots.Location = new System.Drawing.Point(316, 236);
            this.txtStudentSlots.Name = "txtStudentSlots";
            this.txtStudentSlots.Size = new System.Drawing.Size(213, 22);
            this.txtStudentSlots.TabIndex = 19;
            // 
            // lblStudentSlots
            // 
            this.lblStudentSlots.AutoSize = true;
            this.lblStudentSlots.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentSlots.Location = new System.Drawing.Point(313, 218);
            this.lblStudentSlots.Name = "lblStudentSlots";
            this.lblStudentSlots.Size = new System.Drawing.Size(38, 16);
            this.lblStudentSlots.TabIndex = 18;
            this.lblStudentSlots.Text = "Slots";
            // 
            // txtEventName
            // 
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.Location = new System.Drawing.Point(43, 62);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(487, 22);
            this.txtEventName.TabIndex = 17;
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(40, 44);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(82, 16);
            this.lblEventName.TabIndex = 16;
            this.lblEventName.Text = "Event Name";
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.Location = new System.Drawing.Point(40, 88);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(47, 16);
            this.lblVenue.TabIndex = 1;
            this.lblVenue.Text = "Venue";
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(43, 193);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(486, 22);
            this.txtTime.TabIndex = 15;
            // 
            // txtVenue
            // 
            this.txtVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVenue.Location = new System.Drawing.Point(43, 106);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(487, 22);
            this.txtVenue.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(40, 175);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(39, 16);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "Time";
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFrom.Location = new System.Drawing.Point(40, 132);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(39, 16);
            this.lblDateFrom.TabIndex = 3;
            this.lblDateFrom.Text = "From";
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateFrom.Location = new System.Drawing.Point(43, 150);
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.Size = new System.Drawing.Size(241, 22);
            this.txtDateFrom.TabIndex = 4;
            // 
            // lblStudentRegistrationFee
            // 
            this.lblStudentRegistrationFee.AutoSize = true;
            this.lblStudentRegistrationFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentRegistrationFee.Location = new System.Drawing.Point(39, 218);
            this.lblStudentRegistrationFee.Name = "lblStudentRegistrationFee";
            this.lblStudentRegistrationFee.Size = new System.Drawing.Size(107, 16);
            this.lblStudentRegistrationFee.TabIndex = 5;
            this.lblStudentRegistrationFee.Text = "Registration Fee";
            // 
            // txtStudentRegistration
            // 
            this.txtStudentRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudentRegistration.Location = new System.Drawing.Point(42, 236);
            this.txtStudentRegistration.Name = "txtStudentRegistration";
            this.txtStudentRegistration.Size = new System.Drawing.Size(268, 22);
            this.txtStudentRegistration.TabIndex = 6;
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTo.Location = new System.Drawing.Point(290, 132);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(25, 16);
            this.lblDateTo.TabIndex = 37;
            this.lblDateTo.Text = "To";
            // 
            // txtDateTo
            // 
            this.txtDateTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateTo.Location = new System.Drawing.Point(290, 150);
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.Size = new System.Drawing.Size(241, 22);
            this.txtDateTo.TabIndex = 38;
            // 
            // FrmEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 740);
            this.Controls.Add(this.groupEventInfo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.checkGuests);
            this.Controls.Add(this.groupGuests);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEvents";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEvents";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.groupGuests.ResumeLayout(false);
            this.groupGuests.PerformLayout();
            this.groupEventInfo.ResumeLayout(false);
            this.groupEventInfo.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupGuests;
        private System.Windows.Forms.CheckBox checkGuests;
        private System.Windows.Forms.TextBox txtGuestSlots;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblGuestSlots;
        private System.Windows.Forms.Label lblGuestRegistrationFee;
        private System.Windows.Forms.TextBox txtGuestRegistraionFree;
        private System.Windows.Forms.GroupBox groupEventInfo;
        private System.Windows.Forms.Label lblEventDetails;
        private System.Windows.Forms.TextBox txtEventDetails;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.TextBox txtStudentSlots;
        private System.Windows.Forms.Label lblStudentSlots;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.TextBox txtDateFrom;
        private System.Windows.Forms.Label lblStudentRegistrationFee;
        private System.Windows.Forms.TextBox txtStudentRegistration;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.TextBox txtDateTo;
    }
}