using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XanderUI;
using Code_Secret_SOEMS.Presenters;
using Code_Secret_SOEMS.Helpers;

namespace Code_Secret_SOEMS.Views
{
    public partial class FrmStudentRequests : Form
    {
        StudentRequestPresenter studentRequestPresenter;
        ThemeHelper th;
        public FrmStudentRequests()
        {
            InitializeComponent();
            studentRequestPresenter = new StudentRequestPresenter(flowLayoutPanelStudent);
            th = new ThemeHelper();
            th.setPanelColor(panelTop);
        }

        public void createStudentGroup()
        {
            Label lblStudentIDNo = new Label();
            lblStudentIDNo.AutoSize = true;
            lblStudentIDNo.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblStudentIDNo.Location = new Point(9, 5);
            lblStudentIDNo.Name = "lblStudentIDNo";
            lblStudentIDNo.Size = new Size(41, 15);
            lblStudentIDNo.Text = "ID No.:";

            Label lblFullName = new Label();
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblFullName.Location = new Point(9, 25);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(68, 15);
            lblFullName.Text = "Full Name:";

            Label lblGender = new Label();
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblGender.Location = new Point(9, 45);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(57, 15);
            lblGender.Text = "Gender:";

            Label lblAddress = new Label();
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblAddress.Location = new Point(8, 65);
            lblAddress.Name = "lblGender";
            lblAddress.Size = new Size(51, 15);
            lblAddress.Text = "Address:";

            Label lblContactNo = new Label();
            lblContactNo.AutoSize = true;
            lblContactNo.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblContactNo.Location = new Point(9, 85);
            lblContactNo.Name = "lblContactNo";
            lblContactNo.Size = new Size(103, 15);
            lblContactNo.Text = "Contact Number:";

            Label lblEmailAddress = new Label();
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblEmailAddress.Location = new Point(9, 105);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(92, 15);
            lblEmailAddress.Text = "Email Address:";

            Label lblCourse = new Label();
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblCourse.Location = new Point(8, 125);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(38, 15);
            lblCourse.Text = "Course:";

            Label lblYearAndSection = new Label();
            lblYearAndSection.AutoSize = true;
            lblYearAndSection.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            lblYearAndSection.Location = new Point(8, 145);
            lblYearAndSection.Name = "lblYearAndSection";
            lblYearAndSection.Size = new Size(38, 15);
            lblYearAndSection.Text = "Year and Section:";

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

            Panel panelGuest = new Panel();
            panelGuest.Controls.Add(lblSwitchStatus);
            panelGuest.Controls.Add(lblStudentIDNo);
            panelGuest.Controls.Add(switchIsActivated);
            panelGuest.Controls.Add(lblCourse);
            panelGuest.Controls.Add(lblYearAndSection);
            panelGuest.Controls.Add(lblAddress);
            panelGuest.Controls.Add(lblEmailAddress);
            panelGuest.Controls.Add(lblContactNo);
            panelGuest.Controls.Add(lblFullName);
            panelGuest.Controls.Add(lblGender);
            panelGuest.Location = new Point(3, 3);
            panelGuest.Name = "panelGuest";
            panelGuest.BorderStyle = BorderStyle.FixedSingle;
            panelGuest.Size = new Size(458, 166);

            flowLayoutPanelStudent.Controls.Add(panelGuest);
        }

        private void FrmStudentRequests_Load(object sender, EventArgs e)
        {
            studentRequestPresenter.setStudentRequests();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
