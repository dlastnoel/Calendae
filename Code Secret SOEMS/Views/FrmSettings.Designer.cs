namespace Code_Secret_SOEMS
{
    partial class FrmSettings
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.checkLoginLock = new System.Windows.Forms.CheckBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnSecurityApply = new System.Windows.Forms.Button();
            this.groupSecurity = new System.Windows.Forms.GroupBox();
            this.groupTheme = new System.Windows.Forms.GroupBox();
            this.checkDarkMode = new System.Windows.Forms.CheckBox();
            this.cmbTheme = new System.Windows.Forms.ComboBox();
            this.btnThemeApply = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.groupSecurity.SuspendLayout();
            this.groupTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DarkOrange;
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(481, 30);
            this.panelTop.TabIndex = 41;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(458, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 30);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(84, 19);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "SETTINGS";
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(16, 82);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(429, 23);
            this.txtTime.TabIndex = 45;
            // 
            // checkLoginLock
            // 
            this.checkLoginLock.AutoSize = true;
            this.checkLoginLock.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLoginLock.Location = new System.Drawing.Point(16, 42);
            this.checkLoginLock.Name = "checkLoginLock";
            this.checkLoginLock.Size = new System.Drawing.Size(87, 19);
            this.checkLoginLock.TabIndex = 0;
            this.checkLoginLock.Text = "Login Lock";
            this.checkLoginLock.UseVisualStyleBackColor = true;
            this.checkLoginLock.CheckedChanged += new System.EventHandler(this.checkLoginLock_CheckedChanged);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(13, 64);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(130, 15);
            this.lblTime.TabIndex = 44;
            this.lblTime.Text = "Set Time (in minutes)";
            // 
            // btnSecurityApply
            // 
            this.btnSecurityApply.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSecurityApply.FlatAppearance.BorderSize = 0;
            this.btnSecurityApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecurityApply.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecurityApply.ForeColor = System.Drawing.Color.White;
            this.btnSecurityApply.Location = new System.Drawing.Point(306, 111);
            this.btnSecurityApply.Name = "btnSecurityApply";
            this.btnSecurityApply.Size = new System.Drawing.Size(139, 30);
            this.btnSecurityApply.TabIndex = 44;
            this.btnSecurityApply.Text = "Apply";
            this.btnSecurityApply.UseVisualStyleBackColor = false;
            this.btnSecurityApply.Click += new System.EventHandler(this.btnSecurityApply_Click);
            // 
            // groupSecurity
            // 
            this.groupSecurity.Controls.Add(this.btnSecurityApply);
            this.groupSecurity.Controls.Add(this.lblTime);
            this.groupSecurity.Controls.Add(this.checkLoginLock);
            this.groupSecurity.Controls.Add(this.txtTime);
            this.groupSecurity.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSecurity.Location = new System.Drawing.Point(12, 36);
            this.groupSecurity.Name = "groupSecurity";
            this.groupSecurity.Size = new System.Drawing.Size(456, 168);
            this.groupSecurity.TabIndex = 44;
            this.groupSecurity.TabStop = false;
            this.groupSecurity.Text = "Security";
            // 
            // groupTheme
            // 
            this.groupTheme.Controls.Add(this.checkDarkMode);
            this.groupTheme.Controls.Add(this.cmbTheme);
            this.groupTheme.Controls.Add(this.btnThemeApply);
            this.groupTheme.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTheme.Location = new System.Drawing.Point(10, 210);
            this.groupTheme.Name = "groupTheme";
            this.groupTheme.Size = new System.Drawing.Size(456, 168);
            this.groupTheme.TabIndex = 46;
            this.groupTheme.TabStop = false;
            this.groupTheme.Text = "Theme";
            // 
            // checkDarkMode
            // 
            this.checkDarkMode.AutoSize = true;
            this.checkDarkMode.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDarkMode.Location = new System.Drawing.Point(18, 53);
            this.checkDarkMode.Name = "checkDarkMode";
            this.checkDarkMode.Size = new System.Drawing.Size(84, 19);
            this.checkDarkMode.TabIndex = 46;
            this.checkDarkMode.Text = "DarkMode";
            this.checkDarkMode.UseVisualStyleBackColor = true;
            // 
            // cmbTheme
            // 
            this.cmbTheme.BackColor = System.Drawing.Color.White;
            this.cmbTheme.FormattingEnabled = true;
            this.cmbTheme.Items.AddRange(new object[] {
            "Dark Orange",
            "Cool Blue",
            "Hot Pink",
            "Mint Green",
            "Peru",
            "Candy Red"});
            this.cmbTheme.Location = new System.Drawing.Point(18, 78);
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.Size = new System.Drawing.Size(427, 26);
            this.cmbTheme.TabIndex = 45;
            // 
            // btnThemeApply
            // 
            this.btnThemeApply.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThemeApply.FlatAppearance.BorderSize = 0;
            this.btnThemeApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemeApply.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemeApply.ForeColor = System.Drawing.Color.White;
            this.btnThemeApply.Location = new System.Drawing.Point(306, 110);
            this.btnThemeApply.Name = "btnThemeApply";
            this.btnThemeApply.Size = new System.Drawing.Size(139, 30);
            this.btnThemeApply.TabIndex = 44;
            this.btnThemeApply.Text = "Apply";
            this.btnThemeApply.UseVisualStyleBackColor = false;
            this.btnThemeApply.Click += new System.EventHandler(this.btnThemeApply_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 395);
            this.Controls.Add(this.groupTheme);
            this.Controls.Add(this.groupSecurity);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSettings";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.groupSecurity.ResumeLayout(false);
            this.groupSecurity.PerformLayout();
            this.groupTheme.ResumeLayout(false);
            this.groupTheme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.CheckBox checkLoginLock;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnSecurityApply;
        private System.Windows.Forms.GroupBox groupSecurity;
        private System.Windows.Forms.GroupBox groupTheme;
        private System.Windows.Forms.Button btnThemeApply;
        private System.Windows.Forms.ComboBox cmbTheme;
        private System.Windows.Forms.CheckBox checkDarkMode;
    }
}