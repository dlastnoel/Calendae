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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupCourses = new System.Windows.Forms.GroupBox();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.dataCourses = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblCourse = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkLoginLock = new System.Windows.Forms.CheckBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnSecurityApply = new System.Windows.Forms.Button();
            this.groupSecurity = new System.Windows.Forms.GroupBox();
            this.groupTheme = new System.Windows.Forms.GroupBox();
            this.checkDarkMode = new System.Windows.Forms.CheckBox();
            this.cmbTheme = new System.Windows.Forms.ComboBox();
            this.btnThemeApply = new System.Windows.Forms.Button();
            this.groupCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.groupSecurity.SuspendLayout();
            this.groupTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupCourses
            // 
            this.groupCourses.Controls.Add(this.lblInfo1);
            this.groupCourses.Controls.Add(this.dataCourses);
            this.groupCourses.Controls.Add(this.btnDelete);
            this.groupCourses.Controls.Add(this.btnUpdate);
            this.groupCourses.Controls.Add(this.lblCourse);
            this.groupCourses.Controls.Add(this.textBox1);
            this.groupCourses.Controls.Add(this.btnAdd);
            this.groupCourses.Controls.Add(this.dataGridView1);
            this.groupCourses.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCourses.Location = new System.Drawing.Point(12, 36);
            this.groupCourses.Name = "groupCourses";
            this.groupCourses.Size = new System.Drawing.Size(456, 342);
            this.groupCourses.TabIndex = 40;
            this.groupCourses.TabStop = false;
            this.groupCourses.Text = "Manage Courses";
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.ForeColor = System.Drawing.Color.Black;
            this.lblInfo1.Location = new System.Drawing.Point(13, 309);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(235, 13);
            this.lblInfo1.TabIndex = 43;
            this.lblInfo1.Text = "Course list will be used by students in registration";
            // 
            // dataCourses
            // 
            this.dataCourses.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCourses.Location = new System.Drawing.Point(16, 35);
            this.dataCourses.Name = "dataCourses";
            this.dataCourses.Size = new System.Drawing.Size(429, 178);
            this.dataCourses.TabIndex = 42;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(306, 263);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 30);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(161, 263);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 30);
            this.btnUpdate.TabIndex = 36;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(13, 216);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(47, 15);
            this.lblCourse.TabIndex = 34;
            this.lblCourse.Text = "Course";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(16, 234);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(429, 23);
            this.textBox1.TabIndex = 35;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(16, 263);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 30);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(429, 31);
            this.dataGridView1.TabIndex = 31;
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
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(917, 0);
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
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(16, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(429, 23);
            this.textBox2.TabIndex = 45;
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
            // 
            // groupSecurity
            // 
            this.groupSecurity.Controls.Add(this.btnSecurityApply);
            this.groupSecurity.Controls.Add(this.lblTime);
            this.groupSecurity.Controls.Add(this.checkLoginLock);
            this.groupSecurity.Controls.Add(this.textBox2);
            this.groupSecurity.Font = new System.Drawing.Font("Roboto Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupSecurity.Location = new System.Drawing.Point(474, 36);
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
            this.groupTheme.Location = new System.Drawing.Point(472, 210);
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
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(940, 395);
            this.Controls.Add(this.groupTheme);
            this.Controls.Add(this.groupSecurity);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.groupCourses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSettings";
            this.groupCourses.ResumeLayout(false);
            this.groupCourses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.groupSecurity.ResumeLayout(false);
            this.groupSecurity.PerformLayout();
            this.groupTheme.ResumeLayout(false);
            this.groupTheme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupCourses;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataCourses;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox textBox2;
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