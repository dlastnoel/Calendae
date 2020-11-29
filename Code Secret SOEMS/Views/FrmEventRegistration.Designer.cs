namespace Code_Secret_SOEMS.Views
{
    partial class FrmEventRegistration
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEventRegistration));
            this.jDragControl1 = new JDragControl.JDragControl(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelLeft = new XanderUI.XUIGradientPanel();
            this.btnTheme = new FontAwesome.Sharp.IconButton();
            this.btnAbout = new FontAwesome.Sharp.IconButton();
            this.pictureBoxCalendae = new System.Windows.Forms.PictureBox();
            this.cmbEvents = new System.Windows.Forms.ComboBox();
            this.lblEvent = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.panelEvents = new System.Windows.Forms.Panel();
            this.txtEventDetails = new System.Windows.Forms.TextBox();
            this.lblEventDetails = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusSchoolName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelStudentRegistration = new System.Windows.Forms.Panel();
            this.lblStudentRegistrationFee = new System.Windows.Forms.Label();
            this.lblStudentSlots = new System.Windows.Forms.Label();
            this.btnStudentRegister = new System.Windows.Forms.Button();
            this.lblIDNo = new System.Windows.Forms.Label();
            this.btnCheckStudentRegistration = new System.Windows.Forms.Button();
            this.txtIDNo = new System.Windows.Forms.TextBox();
            this.lblStudentRegistration = new System.Windows.Forms.Label();
            this.panelGuestRegistration = new System.Windows.Forms.Panel();
            this.lblGuestRegistrationFee = new System.Windows.Forms.Label();
            this.lblGuestSlots = new System.Windows.Forms.Label();
            this.btnGuestRegister = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.btnCheckGuestRegistration = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblGuestRegistration = new System.Windows.Forms.Label();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.btnClear = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalendae)).BeginInit();
            this.panelEvents.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.panelStudentRegistration.SuspendLayout();
            this.panelGuestRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // jDragControl1
            // 
            this.jDragControl1.GetForm = this;
            this.jDragControl1.TargetControl = this.panelTop;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(300, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(980, 30);
            this.panelTop.TabIndex = 19;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(6, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(140, 20);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Event Registration";
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(957, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 30);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelLeft
            // 
            this.panelLeft.BottomLeft = System.Drawing.Color.Red;
            this.panelLeft.BottomRight = System.Drawing.Color.Gold;
            this.panelLeft.Controls.Add(this.btnTheme);
            this.panelLeft.Controls.Add(this.btnAbout);
            this.panelLeft.Controls.Add(this.pictureBoxCalendae);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.PrimerColor = System.Drawing.Color.Transparent;
            this.panelLeft.Size = new System.Drawing.Size(300, 720);
            this.panelLeft.Style = XanderUI.XUIGradientPanel.GradientStyle.Corners;
            this.panelLeft.TabIndex = 13;
            this.panelLeft.TopLeft = System.Drawing.Color.Gold;
            this.panelLeft.TopRight = System.Drawing.Color.Red;
            // 
            // btnTheme
            // 
            this.btnTheme.BackColor = System.Drawing.Color.Transparent;
            this.btnTheme.FlatAppearance.BorderSize = 0;
            this.btnTheme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheme.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTheme.ForeColor = System.Drawing.Color.Black;
            this.btnTheme.IconChar = FontAwesome.Sharp.IconChar.Palette;
            this.btnTheme.IconColor = System.Drawing.Color.White;
            this.btnTheme.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTheme.IconSize = 25;
            this.btnTheme.Location = new System.Drawing.Point(270, 690);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Rotation = 0D;
            this.btnTheme.Size = new System.Drawing.Size(30, 30);
            this.btnTheme.TabIndex = 4;
            this.btnTheme.UseVisualStyleBackColor = false;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(125)))), ((int)(((byte)(0)))));
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAbout.ForeColor = System.Drawing.Color.Black;
            this.btnAbout.IconChar = FontAwesome.Sharp.IconChar.Code;
            this.btnAbout.IconColor = System.Drawing.Color.White;
            this.btnAbout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbout.IconSize = 25;
            this.btnAbout.Location = new System.Drawing.Point(0, 690);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Rotation = 0D;
            this.btnAbout.Size = new System.Drawing.Size(30, 30);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.UseVisualStyleBackColor = false;
            // 
            // pictureBoxCalendae
            // 
            this.pictureBoxCalendae.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCalendae.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCalendae.Image")));
            this.pictureBoxCalendae.Location = new System.Drawing.Point(50, 260);
            this.pictureBoxCalendae.Name = "pictureBoxCalendae";
            this.pictureBoxCalendae.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxCalendae.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCalendae.TabIndex = 0;
            this.pictureBoxCalendae.TabStop = false;
            // 
            // cmbEvents
            // 
            this.cmbEvents.BackColor = System.Drawing.Color.White;
            this.cmbEvents.FormattingEnabled = true;
            this.cmbEvents.Location = new System.Drawing.Point(333, 83);
            this.cmbEvents.Name = "cmbEvents";
            this.cmbEvents.Size = new System.Drawing.Size(283, 21);
            this.cmbEvents.TabIndex = 49;
            this.cmbEvents.SelectedIndexChanged += new System.EventHandler(this.cmbEvents_SelectedIndexChanged);
            // 
            // lblEvent
            // 
            this.lblEvent.AutoSize = true;
            this.lblEvent.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent.Location = new System.Drawing.Point(330, 62);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(91, 18);
            this.lblEvent.TabIndex = 50;
            this.lblEvent.Text = "Select Event";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(241, 12);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(89, 18);
            this.lblEventName.TabIndex = 51;
            this.lblEventName.Text = "Event Name";
            // 
            // panelEvents
            // 
            this.panelEvents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEvents.Controls.Add(this.txtEventDetails);
            this.panelEvents.Controls.Add(this.lblEventDetails);
            this.panelEvents.Controls.Add(this.lblTime);
            this.panelEvents.Controls.Add(this.lblDate);
            this.panelEvents.Controls.Add(this.lblVenue);
            this.panelEvents.Controls.Add(this.lblEventName);
            this.panelEvents.Location = new System.Drawing.Point(333, 120);
            this.panelEvents.Name = "panelEvents";
            this.panelEvents.Size = new System.Drawing.Size(586, 542);
            this.panelEvents.TabIndex = 52;
            // 
            // txtEventDetails
            // 
            this.txtEventDetails.BackColor = System.Drawing.Color.White;
            this.txtEventDetails.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventDetails.Location = new System.Drawing.Point(23, 182);
            this.txtEventDetails.Multiline = true;
            this.txtEventDetails.Name = "txtEventDetails";
            this.txtEventDetails.ReadOnly = true;
            this.txtEventDetails.Size = new System.Drawing.Size(540, 341);
            this.txtEventDetails.TabIndex = 56;
            // 
            // lblEventDetails
            // 
            this.lblEventDetails.AutoSize = true;
            this.lblEventDetails.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDetails.Location = new System.Drawing.Point(20, 161);
            this.lblEventDetails.Name = "lblEventDetails";
            this.lblEventDetails.Size = new System.Drawing.Size(96, 18);
            this.lblEventDetails.TabIndex = 55;
            this.lblEventDetails.Text = "Event Details";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(20, 126);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(50, 18);
            this.lblTime.TabIndex = 54;
            this.lblTime.Text = "Time: ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(20, 94);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(43, 18);
            this.lblDate.TabIndex = 53;
            this.lblDate.Text = "Date:";
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.Location = new System.Drawing.Point(20, 59);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(54, 18);
            this.lblVenue.TabIndex = 52;
            this.lblVenue.Text = "Venue:";
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusSchoolName,
            this.toolStripStatusDate,
            this.toolStripStatusTime});
            this.statusStripMain.Location = new System.Drawing.Point(300, 695);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStripMain.Size = new System.Drawing.Size(980, 25);
            this.statusStripMain.TabIndex = 53;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusSchoolName
            // 
            this.toolStripStatusSchoolName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusSchoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusSchoolName.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusSchoolName.Image")));
            this.toolStripStatusSchoolName.Name = "toolStripStatusSchoolName";
            this.toolStripStatusSchoolName.Size = new System.Drawing.Size(115, 20);
            this.toolStripStatusSchoolName.Text = "SCHOOL NAME";
            // 
            // toolStripStatusDate
            // 
            this.toolStripStatusDate.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusDate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusDate.Image")));
            this.toolStripStatusDate.Name = "toolStripStatusDate";
            this.toolStripStatusDate.Size = new System.Drawing.Size(53, 20);
            this.toolStripStatusDate.Text = "Date";
            // 
            // toolStripStatusTime
            // 
            this.toolStripStatusTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusTime.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusTime.Image")));
            this.toolStripStatusTime.Name = "toolStripStatusTime";
            this.toolStripStatusTime.Size = new System.Drawing.Size(51, 20);
            this.toolStripStatusTime.Text = "Time";
            // 
            // panelStudentRegistration
            // 
            this.panelStudentRegistration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStudentRegistration.Controls.Add(this.lblStudentRegistrationFee);
            this.panelStudentRegistration.Controls.Add(this.lblStudentSlots);
            this.panelStudentRegistration.Controls.Add(this.btnStudentRegister);
            this.panelStudentRegistration.Controls.Add(this.lblIDNo);
            this.panelStudentRegistration.Controls.Add(this.btnCheckStudentRegistration);
            this.panelStudentRegistration.Controls.Add(this.txtIDNo);
            this.panelStudentRegistration.Controls.Add(this.lblStudentRegistration);
            this.panelStudentRegistration.Enabled = false;
            this.panelStudentRegistration.Location = new System.Drawing.Point(925, 121);
            this.panelStudentRegistration.Name = "panelStudentRegistration";
            this.panelStudentRegistration.Size = new System.Drawing.Size(343, 263);
            this.panelStudentRegistration.TabIndex = 54;
            // 
            // lblStudentRegistrationFee
            // 
            this.lblStudentRegistrationFee.AutoSize = true;
            this.lblStudentRegistrationFee.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentRegistrationFee.Location = new System.Drawing.Point(15, 71);
            this.lblStudentRegistrationFee.Name = "lblStudentRegistrationFee";
            this.lblStudentRegistrationFee.Size = new System.Drawing.Size(102, 15);
            this.lblStudentRegistrationFee.TabIndex = 59;
            this.lblStudentRegistrationFee.Text = "Registration Fee:";
            // 
            // lblStudentSlots
            // 
            this.lblStudentSlots.AutoSize = true;
            this.lblStudentSlots.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentSlots.Location = new System.Drawing.Point(15, 52);
            this.lblStudentSlots.Name = "lblStudentSlots";
            this.lblStudentSlots.Size = new System.Drawing.Size(64, 15);
            this.lblStudentSlots.TabIndex = 57;
            this.lblStudentSlots.Text = "Slots Left:";
            // 
            // btnStudentRegister
            // 
            this.btnStudentRegister.BackColor = System.Drawing.Color.DarkOrange;
            this.btnStudentRegister.FlatAppearance.BorderSize = 0;
            this.btnStudentRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentRegister.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentRegister.ForeColor = System.Drawing.Color.White;
            this.btnStudentRegister.Location = new System.Drawing.Point(18, 195);
            this.btnStudentRegister.Name = "btnStudentRegister";
            this.btnStudentRegister.Size = new System.Drawing.Size(308, 39);
            this.btnStudentRegister.TabIndex = 58;
            this.btnStudentRegister.Text = "Register";
            this.btnStudentRegister.UseVisualStyleBackColor = false;
            // 
            // lblIDNo
            // 
            this.lblIDNo.AutoSize = true;
            this.lblIDNo.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDNo.Location = new System.Drawing.Point(15, 103);
            this.lblIDNo.Name = "lblIDNo";
            this.lblIDNo.Size = new System.Drawing.Size(68, 15);
            this.lblIDNo.TabIndex = 56;
            this.lblIDNo.Text = "ID Number";
            // 
            // btnCheckStudentRegistration
            // 
            this.btnCheckStudentRegistration.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCheckStudentRegistration.FlatAppearance.BorderSize = 0;
            this.btnCheckStudentRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckStudentRegistration.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckStudentRegistration.ForeColor = System.Drawing.Color.White;
            this.btnCheckStudentRegistration.Location = new System.Drawing.Point(18, 150);
            this.btnCheckStudentRegistration.Name = "btnCheckStudentRegistration";
            this.btnCheckStudentRegistration.Size = new System.Drawing.Size(308, 39);
            this.btnCheckStudentRegistration.TabIndex = 56;
            this.btnCheckStudentRegistration.Text = "Check Registration";
            this.btnCheckStudentRegistration.UseVisualStyleBackColor = false;
            // 
            // txtIDNo
            // 
            this.txtIDNo.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDNo.Location = new System.Drawing.Point(18, 121);
            this.txtIDNo.Name = "txtIDNo";
            this.txtIDNo.Size = new System.Drawing.Size(308, 23);
            this.txtIDNo.TabIndex = 57;
            // 
            // lblStudentRegistration
            // 
            this.lblStudentRegistration.AutoSize = true;
            this.lblStudentRegistration.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentRegistration.Location = new System.Drawing.Point(100, 12);
            this.lblStudentRegistration.Name = "lblStudentRegistration";
            this.lblStudentRegistration.Size = new System.Drawing.Size(145, 18);
            this.lblStudentRegistration.TabIndex = 57;
            this.lblStudentRegistration.Text = "Student Registration";
            // 
            // panelGuestRegistration
            // 
            this.panelGuestRegistration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGuestRegistration.Controls.Add(this.lblGuestRegistrationFee);
            this.panelGuestRegistration.Controls.Add(this.lblGuestSlots);
            this.panelGuestRegistration.Controls.Add(this.btnGuestRegister);
            this.panelGuestRegistration.Controls.Add(this.lblCode);
            this.panelGuestRegistration.Controls.Add(this.btnCheckGuestRegistration);
            this.panelGuestRegistration.Controls.Add(this.txtCode);
            this.panelGuestRegistration.Controls.Add(this.lblGuestRegistration);
            this.panelGuestRegistration.Enabled = false;
            this.panelGuestRegistration.Location = new System.Drawing.Point(925, 396);
            this.panelGuestRegistration.Name = "panelGuestRegistration";
            this.panelGuestRegistration.Size = new System.Drawing.Size(343, 263);
            this.panelGuestRegistration.TabIndex = 55;
            // 
            // lblGuestRegistrationFee
            // 
            this.lblGuestRegistrationFee.AutoSize = true;
            this.lblGuestRegistrationFee.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestRegistrationFee.Location = new System.Drawing.Point(15, 70);
            this.lblGuestRegistrationFee.Name = "lblGuestRegistrationFee";
            this.lblGuestRegistrationFee.Size = new System.Drawing.Size(102, 15);
            this.lblGuestRegistrationFee.TabIndex = 65;
            this.lblGuestRegistrationFee.Text = "Registration Fee:";
            // 
            // lblGuestSlots
            // 
            this.lblGuestSlots.AutoSize = true;
            this.lblGuestSlots.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestSlots.Location = new System.Drawing.Point(15, 51);
            this.lblGuestSlots.Name = "lblGuestSlots";
            this.lblGuestSlots.Size = new System.Drawing.Size(64, 15);
            this.lblGuestSlots.TabIndex = 62;
            this.lblGuestSlots.Text = "Slots Left:";
            // 
            // btnGuestRegister
            // 
            this.btnGuestRegister.BackColor = System.Drawing.Color.DarkOrange;
            this.btnGuestRegister.FlatAppearance.BorderSize = 0;
            this.btnGuestRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuestRegister.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuestRegister.ForeColor = System.Drawing.Color.White;
            this.btnGuestRegister.Location = new System.Drawing.Point(18, 194);
            this.btnGuestRegister.Name = "btnGuestRegister";
            this.btnGuestRegister.Size = new System.Drawing.Size(308, 39);
            this.btnGuestRegister.TabIndex = 64;
            this.btnGuestRegister.Text = "Register";
            this.btnGuestRegister.UseVisualStyleBackColor = false;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.Location = new System.Drawing.Point(15, 102);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(36, 15);
            this.lblCode.TabIndex = 60;
            this.lblCode.Text = "Code";
            // 
            // btnCheckGuestRegistration
            // 
            this.btnCheckGuestRegistration.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCheckGuestRegistration.FlatAppearance.BorderSize = 0;
            this.btnCheckGuestRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckGuestRegistration.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckGuestRegistration.ForeColor = System.Drawing.Color.White;
            this.btnCheckGuestRegistration.Location = new System.Drawing.Point(18, 149);
            this.btnCheckGuestRegistration.Name = "btnCheckGuestRegistration";
            this.btnCheckGuestRegistration.Size = new System.Drawing.Size(308, 39);
            this.btnCheckGuestRegistration.TabIndex = 61;
            this.btnCheckGuestRegistration.Text = "Check Registration";
            this.btnCheckGuestRegistration.UseVisualStyleBackColor = false;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(18, 120);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(308, 23);
            this.txtCode.TabIndex = 63;
            // 
            // lblGuestRegistration
            // 
            this.lblGuestRegistration.AutoSize = true;
            this.lblGuestRegistration.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuestRegistration.Location = new System.Drawing.Point(100, 12);
            this.lblGuestRegistration.Name = "lblGuestRegistration";
            this.lblGuestRegistration.Size = new System.Drawing.Size(133, 18);
            this.lblGuestRegistration.TabIndex = 58;
            this.lblGuestRegistration.Text = "Guest Registration";
            // 
            // tmrMain
            // 
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkOrange;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(631, 83);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 21);
            this.btnClear.TabIndex = 60;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FrmEventRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panelGuestRegistration);
            this.Controls.Add(this.panelStudentRegistration);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.panelEvents);
            this.Controls.Add(this.lblEvent);
            this.Controls.Add(this.cmbEvents);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEventRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEventRegistration";
            this.Load += new System.EventHandler(this.FrmEventRegistration_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCalendae)).EndInit();
            this.panelEvents.ResumeLayout(false);
            this.panelEvents.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.panelStudentRegistration.ResumeLayout(false);
            this.panelStudentRegistration.PerformLayout();
            this.panelGuestRegistration.ResumeLayout(false);
            this.panelGuestRegistration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JDragControl.JDragControl jDragControl1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private XanderUI.XUIGradientPanel panelLeft;
        private FontAwesome.Sharp.IconButton btnAbout;
        private System.Windows.Forms.PictureBox pictureBoxCalendae;
        private FontAwesome.Sharp.IconButton btnTheme;
        private System.Windows.Forms.ComboBox cmbEvents;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Panel panelEvents;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusSchoolName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.TextBox txtEventDetails;
        private System.Windows.Forms.Label lblEventDetails;
        private System.Windows.Forms.Panel panelStudentRegistration;
        private System.Windows.Forms.Label lblStudentRegistration;
        private System.Windows.Forms.Panel panelGuestRegistration;
        private System.Windows.Forms.Button btnCheckStudentRegistration;
        private System.Windows.Forms.Label lblGuestRegistration;
        private System.Windows.Forms.Button btnStudentRegister;
        private System.Windows.Forms.Label lblIDNo;
        private System.Windows.Forms.TextBox txtIDNo;
        private System.Windows.Forms.Label lblStudentRegistrationFee;
        private System.Windows.Forms.Label lblStudentSlots;
        private System.Windows.Forms.Label lblGuestRegistrationFee;
        private System.Windows.Forms.Label lblGuestSlots;
        private System.Windows.Forms.Button btnGuestRegister;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Button btnCheckGuestRegistration;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Button btnClear;
    }
}