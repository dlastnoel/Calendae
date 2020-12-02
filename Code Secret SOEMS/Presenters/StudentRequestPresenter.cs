using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS.Models;
using XanderUI;
using Code_Secret_SOEMS.Helpers;

namespace Code_Secret_SOEMS.Presenters
{
    class StudentRequestPresenter
    {
        Student _student;
        List<string> listStudentId;
        FlowLayoutPanel flowLayoutStudent;
        ThemeHelper th = new ThemeHelper();

        public StudentRequestPresenter(FlowLayoutPanel myFlowLayoutPanel)
        {
            _student = new Student();
            listStudentId = _student.getInactiveStudentIds();
            flowLayoutStudent = myFlowLayoutPanel;
            th = new ThemeHelper();
        }

        public void setStudentRequests()
        {
            foreach(var studentId in listStudentId)
            {
                Label lblStudentIDNo = new Label();
                lblStudentIDNo.AutoSize = true;
                lblStudentIDNo.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblStudentIDNo.Location = new Point(9, 5);
                lblStudentIDNo.Name = "lblStudentIDNo";
                lblStudentIDNo.Size = new Size(41, 15);
                lblStudentIDNo.Text = "ID No.: " + _student.getStudentDetails("id");

                Label lblFullName = new Label();
                lblFullName.AutoSize = true;
                lblFullName.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblFullName.Location = new Point(9, 25);
                lblFullName.Name = "lblFullName";
                lblFullName.Size = new Size(68, 15);
                lblFullName.Text = "Full Name: " + _student.getStudentDetails("first_name") + " " + 
                    _student.getStudentDetails("middle_name") + " " + _student.getStudentDetails("last_name");

                Label lblGender = new Label();
                lblGender.AutoSize = true;
                lblGender.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblGender.Location = new Point(9, 45);
                lblGender.Name = "lblGender";
                lblGender.Size = new Size(57, 15);
                if(_student.getStudentDetails("gender") == "M")
                {
                    lblGender.Text = "Gender: Male";
                } else
                {
                    lblGender.Text = "Gender: Female";
                }

                Label lblAddress = new Label();
                lblAddress.AutoSize = true;
                lblAddress.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblAddress.Location = new Point(8, 65);
                lblAddress.Name = "lblGender";
                lblAddress.Size = new Size(51, 15);
                lblAddress.Text = "Address: " + _student.getStudentDetails("address");

                Label lblContactNo = new Label();
                lblContactNo.AutoSize = true;
                lblContactNo.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblContactNo.Location = new Point(9, 85);
                lblContactNo.Name = "lblContactNo";
                lblContactNo.Size = new Size(103, 15);
                lblContactNo.Text = "Contact Number: " + _student.getStudentDetails("contact");

                Label lblEmailAddress = new Label();
                lblEmailAddress.AutoSize = true;
                lblEmailAddress.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblEmailAddress.Location = new Point(9, 105);
                lblEmailAddress.Name = "lblEmailAddress";
                lblEmailAddress.Size = new Size(92, 15);
                lblEmailAddress.Text = "Email Address: " + _student.getStudentDetails("email");

                Label lblCourse = new Label();
                lblCourse.AutoSize = true;
                lblCourse.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblCourse.Location = new Point(8, 125);
                lblCourse.Name = "lblCourse";
                lblCourse.Size = new Size(38, 15);
                lblCourse.Text = "Course: " + _student.getStudentDetails("course");

                Label lblYearAndSection = new Label();
                lblYearAndSection.AutoSize = true;
                lblYearAndSection.Font = new Font("Roboto Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblYearAndSection.Location = new Point(8, 145);
                lblYearAndSection.Name = "lblYearAndSection";
                lblYearAndSection.Size = new Size(38, 15);
                lblYearAndSection.Text = "Year and Section: " + _student.getStudentDetails("year_and_section");

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
                switchIsActivated.Click += (s, e) => {
                    Student s1 = new Student();
                    if (switchIsActivated.SwitchState == XUISwitch.State.Off)
                    {
                        s1.deactivateStudent(studentId);
                        lblSwitchStatus.Text = "Deactivated";
                    }
                    else
                    {
                        s1.activateStudent(studentId);
                        lblSwitchStatus.Text = "Activated";
                    }
                };

                Panel panelStudent = new Panel();
                panelStudent.Controls.Add(lblSwitchStatus);
                panelStudent.Controls.Add(lblStudentIDNo);
                panelStudent.Controls.Add(switchIsActivated);
                panelStudent.Controls.Add(lblCourse);
                panelStudent.Controls.Add(lblYearAndSection);
                panelStudent.Controls.Add(lblAddress);
                panelStudent.Controls.Add(lblEmailAddress);
                panelStudent.Controls.Add(lblContactNo);
                panelStudent.Controls.Add(lblFullName);
                panelStudent.Controls.Add(lblGender);
                panelStudent.Location = new Point(3, 3);
                panelStudent.Name = "panelStudent";
                panelStudent.BorderStyle = BorderStyle.FixedSingle;
                panelStudent.Size = new Size(458, 166);

                th.setLabelColor(lblStudentIDNo);
                th.setLabelColor(lblFullName);
                th.setLabelColor(lblGender);
                th.setLabelColor(lblAddress);
                th.setLabelColor(lblContactNo);
                th.setLabelColor(lblEmailAddress);
                th.setLabelColor(lblCourse);
                th.setLabelColor(lblYearAndSection);
                th.setLabelColor(lblSwitchStatus);

                flowLayoutStudent.Controls.Add(panelStudent);
            }
        }
    }
}
