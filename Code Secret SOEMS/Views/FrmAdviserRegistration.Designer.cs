namespace Code_Secret_SOEMS.Views
{
    partial class FrmAdviserRegistration
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
            this.groupSecurity = new System.Windows.Forms.GroupBox();
            this.lblPasswordMessage = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.rbnFemale = new System.Windows.Forms.RadioButton();
            this.lblAddress = new System.Windows.Forms.Label();
            this.rbnMale = new System.Windows.Forms.RadioButton();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.groupPersonalInfo = new System.Windows.Forms.GroupBox();
            this.lblIDNo = new System.Windows.Forms.Label();
            this.txtIDNo = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupSecurity.SuspendLayout();
            this.groupPersonalInfo.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupSecurity
            // 
            this.groupSecurity.Controls.Add(this.lblPasswordMessage);
            this.groupSecurity.Controls.Add(this.txtConfirmPassword);
            this.groupSecurity.Controls.Add(this.lblPassword);
            this.groupSecurity.Controls.Add(this.txtPassword);
            this.groupSecurity.Controls.Add(this.lblConfirmPassword);
            this.groupSecurity.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSecurity.Location = new System.Drawing.Point(536, 116);
            this.groupSecurity.Name = "groupSecurity";
            this.groupSecurity.Size = new System.Drawing.Size(392, 161);
            this.groupSecurity.TabIndex = 44;
            this.groupSecurity.TabStop = false;
            this.groupSecurity.Text = "Security";
            // 
            // lblPasswordMessage
            // 
            this.lblPasswordMessage.AutoSize = true;
            this.lblPasswordMessage.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordMessage.Location = new System.Drawing.Point(18, 131);
            this.lblPasswordMessage.Name = "lblPasswordMessage";
            this.lblPasswordMessage.Size = new System.Drawing.Size(0, 13);
            this.lblPasswordMessage.TabIndex = 5;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(21, 100);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(352, 23);
            this.txtConfirmPassword.TabIndex = 11;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(18, 38);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 15);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(21, 56);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(352, 23);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(18, 82);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(112, 15);
            this.lblConfirmPassword.TabIndex = 3;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtPosition
            // 
            this.txtPosition.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosition.Location = new System.Drawing.Point(16, 45);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(487, 23);
            this.txtPosition.TabIndex = 0;
            this.txtPosition.Text = "Adviser";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(13, 27);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(53, 15);
            this.lblPosition.TabIndex = 16;
            this.lblPosition.Text = "Position";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(13, 120);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(70, 15);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAddress.Location = new System.Drawing.Point(290, 182);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(213, 23);
            this.txtEmailAddress.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(16, 138);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(213, 23);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.Location = new System.Drawing.Point(287, 164);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(89, 15);
            this.lblEmailAddress.TabIndex = 14;
            this.lblEmailAddress.Text = "Email Address";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleName.Location = new System.Drawing.Point(13, 164);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(83, 15);
            this.lblMiddleName.TabIndex = 3;
            this.lblMiddleName.Text = "Middle Name";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(290, 138);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(213, 23);
            this.txtContactNo.TabIndex = 6;
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMiddleName.Location = new System.Drawing.Point(16, 182);
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.Size = new System.Drawing.Size(213, 23);
            this.txtMiddleName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(13, 208);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(70, 15);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(287, 217);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(48, 15);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Gender";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(16, 226);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(213, 23);
            this.txtLastName.TabIndex = 4;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(536, 284);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(392, 41);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.Location = new System.Drawing.Point(287, 120);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(100, 15);
            this.lblContactNo.TabIndex = 12;
            this.lblContactNo.Text = "Contact Number";
            // 
            // rbnFemale
            // 
            this.rbnFemale.AutoSize = true;
            this.rbnFemale.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnFemale.Location = new System.Drawing.Point(349, 239);
            this.rbnFemale.Name = "rbnFemale";
            this.rbnFemale.Size = new System.Drawing.Size(68, 19);
            this.rbnFemale.TabIndex = 9;
            this.rbnFemale.TabStop = true;
            this.rbnFemale.Text = "Female";
            this.rbnFemale.UseVisualStyleBackColor = true;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(13, 252);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(54, 15);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address";
            // 
            // rbnMale
            // 
            this.rbnMale.AutoSize = true;
            this.rbnMale.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnMale.Location = new System.Drawing.Point(290, 239);
            this.rbnMale.Name = "rbnMale";
            this.rbnMale.Size = new System.Drawing.Size(53, 19);
            this.rbnMale.TabIndex = 8;
            this.rbnMale.TabStop = true;
            this.rbnMale.Text = "Male";
            this.rbnMale.UseVisualStyleBackColor = true;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(16, 270);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(487, 56);
            this.txtAddress.TabIndex = 5;
            // 
            // groupPersonalInfo
            // 
            this.groupPersonalInfo.Controls.Add(this.lblIDNo);
            this.groupPersonalInfo.Controls.Add(this.txtIDNo);
            this.groupPersonalInfo.Controls.Add(this.txtPosition);
            this.groupPersonalInfo.Controls.Add(this.lblPosition);
            this.groupPersonalInfo.Controls.Add(this.lblFirstName);
            this.groupPersonalInfo.Controls.Add(this.txtEmailAddress);
            this.groupPersonalInfo.Controls.Add(this.txtFirstName);
            this.groupPersonalInfo.Controls.Add(this.lblEmailAddress);
            this.groupPersonalInfo.Controls.Add(this.lblMiddleName);
            this.groupPersonalInfo.Controls.Add(this.txtContactNo);
            this.groupPersonalInfo.Controls.Add(this.txtMiddleName);
            this.groupPersonalInfo.Controls.Add(this.lblContactNo);
            this.groupPersonalInfo.Controls.Add(this.lblLastName);
            this.groupPersonalInfo.Controls.Add(this.lblGender);
            this.groupPersonalInfo.Controls.Add(this.txtLastName);
            this.groupPersonalInfo.Controls.Add(this.rbnFemale);
            this.groupPersonalInfo.Controls.Add(this.lblAddress);
            this.groupPersonalInfo.Controls.Add(this.rbnMale);
            this.groupPersonalInfo.Controls.Add(this.txtAddress);
            this.groupPersonalInfo.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPersonalInfo.Location = new System.Drawing.Point(12, 45);
            this.groupPersonalInfo.Name = "groupPersonalInfo";
            this.groupPersonalInfo.Size = new System.Drawing.Size(518, 340);
            this.groupPersonalInfo.TabIndex = 42;
            this.groupPersonalInfo.TabStop = false;
            this.groupPersonalInfo.Text = "Personal Information";
            // 
            // lblIDNo
            // 
            this.lblIDNo.AutoSize = true;
            this.lblIDNo.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNo.Location = new System.Drawing.Point(15, 71);
            this.lblIDNo.Name = "lblIDNo";
            this.lblIDNo.Size = new System.Drawing.Size(68, 15);
            this.lblIDNo.TabIndex = 47;
            this.lblIDNo.Text = "ID Number";
            // 
            // txtIDNo
            // 
            this.txtIDNo.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNo.Location = new System.Drawing.Point(18, 89);
            this.txtIDNo.Name = "txtIDNo";
            this.txtIDNo.Size = new System.Drawing.Size(485, 23);
            this.txtIDNo.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DarkOrange;
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(940, 30);
            this.panelTop.TabIndex = 41;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(150, 19);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Adviser Registration";
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(917, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 30);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmAdviserRegistration
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 397);
            this.Controls.Add(this.groupSecurity);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.groupPersonalInfo);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdviserRegistration";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdviserRegistration";
            this.Load += new System.EventHandler(this.FrmAdviserRegistration_Load);
            this.groupSecurity.ResumeLayout(false);
            this.groupSecurity.PerformLayout();
            this.groupPersonalInfo.ResumeLayout(false);
            this.groupPersonalInfo.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSecurity;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblMiddleName;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtMiddleName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.RadioButton rbnFemale;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.RadioButton rbnMale;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.GroupBox groupPersonalInfo;
        private System.Windows.Forms.Label lblIDNo;
        private System.Windows.Forms.TextBox txtIDNo;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPasswordMessage;
        private System.Windows.Forms.Button btnClose;
    }
}