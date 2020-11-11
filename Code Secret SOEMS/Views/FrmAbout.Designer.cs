namespace Code_Secret_SOEMS
{
    partial class FrmAbout
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
            this.panelLeft = new XanderUI.XUIGradientPanel();
            this.lblAbout1 = new System.Windows.Forms.Label();
            this.lblAbout2 = new System.Windows.Forms.Label();
            this.lblAbout3 = new System.Windows.Forms.Label();
            this.pictureBoxCodeSecret = new System.Windows.Forms.PictureBox();
            this.pictureBoxCalendae = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCodeSecret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalendae)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.btnBack);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(300, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(500, 30);
            this.panelTop.TabIndex = 19;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(6, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(51, 19);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "About";
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(477, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(23, 30);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "←";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BottomLeft = System.Drawing.Color.Red;
            this.panelLeft.BottomRight = System.Drawing.Color.Gold;
            this.panelLeft.Controls.Add(this.pictureBoxCalendae);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.PrimerColor = System.Drawing.Color.Transparent;
            this.panelLeft.Size = new System.Drawing.Size(300, 520);
            this.panelLeft.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.panelLeft.TabIndex = 13;
            this.panelLeft.TopLeft = System.Drawing.Color.Gold;
            this.panelLeft.TopRight = System.Drawing.Color.Red;
            // 
            // lblAbout1
            // 
            this.lblAbout1.AutoSize = true;
            this.lblAbout1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout1.Location = new System.Drawing.Point(379, 268);
            this.lblAbout1.Name = "lblAbout1";
            this.lblAbout1.Size = new System.Drawing.Size(324, 19);
            this.lblAbout1.TabIndex = 20;
            this.lblAbout1.Text = "This software was developed by Code Secret";
            // 
            // lblAbout2
            // 
            this.lblAbout2.AutoSize = true;
            this.lblAbout2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout2.Location = new System.Drawing.Point(379, 297);
            this.lblAbout2.Name = "lblAbout2";
            this.lblAbout2.Size = new System.Drawing.Size(169, 95);
            this.lblAbout2.TabIndex = 21;
            this.lblAbout2.Text = "Team Members\r\nIris P. Lagasca\r\nIan Justin B. Salazar\r\nNoel Xavier M. Ulpindo\r\nIsi" +
    "ah Neil Villanueva";
            // 
            // lblAbout3
            // 
            this.lblAbout3.AutoSize = true;
            this.lblAbout3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout3.Location = new System.Drawing.Point(379, 403);
            this.lblAbout3.Name = "lblAbout3";
            this.lblAbout3.Size = new System.Drawing.Size(321, 38);
            this.lblAbout3.TabIndex = 22;
            this.lblAbout3.Text = "In partial fulfillment for the subject ITPC 104\r\nEvent Driven Programming";
            // 
            // pictureBoxCodeSecret
            // 
            this.pictureBoxCodeSecret.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCodeSecret.Image = global::Code_Secret_SOEMS.Properties.Resources.code_secret;
            this.pictureBoxCodeSecret.Location = new System.Drawing.Point(441, 47);
            this.pictureBoxCodeSecret.Name = "pictureBoxCodeSecret";
            this.pictureBoxCodeSecret.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxCodeSecret.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCodeSecret.TabIndex = 2;
            this.pictureBoxCodeSecret.TabStop = false;
            // 
            // pictureBoxCalendae
            // 
            this.pictureBoxCalendae.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCalendae.Image = global::Code_Secret_SOEMS.Properties.Resources.calendae;
            this.pictureBoxCalendae.Location = new System.Drawing.Point(55, 121);
            this.pictureBoxCalendae.Name = "pictureBoxCalendae";
            this.pictureBoxCalendae.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxCalendae.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCalendae.TabIndex = 0;
            this.pictureBoxCalendae.TabStop = false;
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.pictureBoxCodeSecret);
            this.Controls.Add(this.lblAbout3);
            this.Controls.Add(this.lblAbout2);
            this.Controls.Add(this.lblAbout1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAbout";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAbout";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCodeSecret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalendae)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;
        private XanderUI.XUIGradientPanel panelLeft;
        private System.Windows.Forms.PictureBox pictureBoxCalendae;
        private System.Windows.Forms.Label lblAbout1;
        private System.Windows.Forms.Label lblAbout2;
        private System.Windows.Forms.Label lblAbout3;
        private System.Windows.Forms.PictureBox pictureBoxCodeSecret;
    }
}