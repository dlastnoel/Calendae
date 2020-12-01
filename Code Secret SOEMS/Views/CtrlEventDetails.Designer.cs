namespace Code_Secret_SOEMS.Views
{
    partial class CtrlEventDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblDateAndTime = new System.Windows.Forms.Label();
            this.lblStudentSlots = new System.Windows.Forms.Label();
            this.lblStudentRegistrationFee = new System.Windows.Forms.Label();
            this.lblGuestRegistrationFee = new System.Windows.Forms.Label();
            this.lblGuestSlots = new System.Windows.Forms.Label();
            this.dataGuestRegistrations = new System.Windows.Forms.DataGridView();
            this.dataStudentRegistrations = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGuestRegistrations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudentRegistrations)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(747, 0);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(89, 18);
            this.lblEventName.TabIndex = 52;
            this.lblEventName.Text = "Event Name";
            // 
            // lblDateAndTime
            // 
            this.lblDateAndTime.AutoSize = true;
            this.lblDateAndTime.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateAndTime.Location = new System.Drawing.Point(719, 18);
            this.lblDateAndTime.Name = "lblDateAndTime";
            this.lblDateAndTime.Size = new System.Drawing.Size(146, 18);
            this.lblDateAndTime.TabIndex = 53;
            this.lblDateAndTime.Text = "Event Date and Time";
            // 
            // lblStudentSlots
            // 
            this.lblStudentSlots.AutoSize = true;
            this.lblStudentSlots.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentSlots.Location = new System.Drawing.Point(24, 76);
            this.lblStudentSlots.Name = "lblStudentSlots";
            this.lblStudentSlots.Size = new System.Drawing.Size(76, 18);
            this.lblStudentSlots.TabIndex = 54;
            this.lblStudentSlots.Text = "Slots Left:";
            // 
            // lblStudentRegistrationFee
            // 
            this.lblStudentRegistrationFee.AutoSize = true;
            this.lblStudentRegistrationFee.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentRegistrationFee.Location = new System.Drawing.Point(266, 76);
            this.lblStudentRegistrationFee.Name = "lblStudentRegistrationFee";
            this.lblStudentRegistrationFee.Size = new System.Drawing.Size(122, 18);
            this.lblStudentRegistrationFee.TabIndex = 55;
            this.lblStudentRegistrationFee.Text = "Registration Fee:";
            // 
            // lblGuestRegistrationFee
            // 
            this.lblGuestRegistrationFee.AutoSize = true;
            this.lblGuestRegistrationFee.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestRegistrationFee.Location = new System.Drawing.Point(1038, 76);
            this.lblGuestRegistrationFee.Name = "lblGuestRegistrationFee";
            this.lblGuestRegistrationFee.Size = new System.Drawing.Size(122, 18);
            this.lblGuestRegistrationFee.TabIndex = 57;
            this.lblGuestRegistrationFee.Text = "Registration Fee:";
            // 
            // lblGuestSlots
            // 
            this.lblGuestSlots.AutoSize = true;
            this.lblGuestSlots.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestSlots.Location = new System.Drawing.Point(795, 76);
            this.lblGuestSlots.Name = "lblGuestSlots";
            this.lblGuestSlots.Size = new System.Drawing.Size(76, 18);
            this.lblGuestSlots.TabIndex = 56;
            this.lblGuestSlots.Text = "Slots Left:";
            // 
            // dataGuestRegistrations
            // 
            this.dataGuestRegistrations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGuestRegistrations.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGuestRegistrations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGuestRegistrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGuestRegistrations.Location = new System.Drawing.Point(798, 97);
            this.dataGuestRegistrations.Name = "dataGuestRegistrations";
            this.dataGuestRegistrations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGuestRegistrations.Size = new System.Drawing.Size(747, 823);
            this.dataGuestRegistrations.TabIndex = 32;
            this.dataGuestRegistrations.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGuestRegistrations_CellDoubleClick);
            // 
            // dataStudentRegistrations
            // 
            this.dataStudentRegistrations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataStudentRegistrations.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataStudentRegistrations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataStudentRegistrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStudentRegistrations.Location = new System.Drawing.Point(27, 97);
            this.dataStudentRegistrations.Name = "dataStudentRegistrations";
            this.dataStudentRegistrations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataStudentRegistrations.Size = new System.Drawing.Size(747, 823);
            this.dataStudentRegistrations.TabIndex = 31;
            this.dataStudentRegistrations.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataStudentRegistrations_CellDoubleClick);
            // 
            // CtrlEventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblGuestRegistrationFee);
            this.Controls.Add(this.lblGuestSlots);
            this.Controls.Add(this.lblStudentRegistrationFee);
            this.Controls.Add(this.lblStudentSlots);
            this.Controls.Add(this.lblDateAndTime);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.dataGuestRegistrations);
            this.Controls.Add(this.dataStudentRegistrations);
            this.Name = "CtrlEventDetails";
            this.Size = new System.Drawing.Size(1576, 956);
            this.Load += new System.EventHandler(this.CtrlEventDetails_Load);
            this.SizeChanged += new System.EventHandler(this.CtrlEventDetails_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dataGuestRegistrations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudentRegistrations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblDateAndTime;
        private System.Windows.Forms.Label lblStudentSlots;
        private System.Windows.Forms.Label lblStudentRegistrationFee;
        private System.Windows.Forms.Label lblGuestRegistrationFee;
        private System.Windows.Forms.Label lblGuestSlots;
        private System.Windows.Forms.DataGridView dataGuestRegistrations;
        private System.Windows.Forms.DataGridView dataStudentRegistrations;
    }
}
