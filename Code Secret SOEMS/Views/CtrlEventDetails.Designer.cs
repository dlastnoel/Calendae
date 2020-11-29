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
            this.dataStudentRegistrations = new System.Windows.Forms.DataGridView();
            this.dataGuestRegistrations = new System.Windows.Forms.DataGridView();
            this.panelStudents = new System.Windows.Forms.Panel();
            this.panelGuests = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudentRegistrations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGuestRegistrations)).BeginInit();
            this.SuspendLayout();
            // 
            // dataStudentRegistrations
            // 
            this.dataStudentRegistrations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataStudentRegistrations.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataStudentRegistrations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataStudentRegistrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStudentRegistrations.Location = new System.Drawing.Point(27, 42);
            this.dataStudentRegistrations.Name = "dataStudentRegistrations";
            this.dataStudentRegistrations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataStudentRegistrations.Size = new System.Drawing.Size(747, 715);
            this.dataStudentRegistrations.TabIndex = 31;
            // 
            // dataGuestRegistrations
            // 
            this.dataGuestRegistrations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGuestRegistrations.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGuestRegistrations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGuestRegistrations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGuestRegistrations.Location = new System.Drawing.Point(798, 42);
            this.dataGuestRegistrations.Name = "dataGuestRegistrations";
            this.dataGuestRegistrations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGuestRegistrations.Size = new System.Drawing.Size(747, 715);
            this.dataGuestRegistrations.TabIndex = 32;
            // 
            // panelStudents
            // 
            this.panelStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStudents.Location = new System.Drawing.Point(27, 763);
            this.panelStudents.Name = "panelStudents";
            this.panelStudents.Size = new System.Drawing.Size(747, 157);
            this.panelStudents.TabIndex = 33;
            // 
            // panelGuests
            // 
            this.panelGuests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGuests.Location = new System.Drawing.Point(798, 763);
            this.panelGuests.Name = "panelGuests";
            this.panelGuests.Size = new System.Drawing.Size(747, 157);
            this.panelGuests.TabIndex = 34;
            // 
            // CtrlEventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelGuests);
            this.Controls.Add(this.panelStudents);
            this.Controls.Add(this.dataGuestRegistrations);
            this.Controls.Add(this.dataStudentRegistrations);
            this.Name = "CtrlEventDetails";
            this.Size = new System.Drawing.Size(1576, 956);
            this.Load += new System.EventHandler(this.CtrlEventDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataStudentRegistrations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGuestRegistrations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataStudentRegistrations;
        private System.Windows.Forms.DataGridView dataGuestRegistrations;
        private System.Windows.Forms.Panel panelStudents;
        private System.Windows.Forms.Panel panelGuests;
    }
}
