using System;
using System.Drawing;
using System.Windows.Forms;
using Code_Secret_SOEMS.Presenters;
using Code_Secret_SOEMS.Helpers;

namespace Code_Secret_SOEMS
{
    public partial class FrmStudentRegistration : Form
    {
        private StudentPresenter studentPresenter;
        private string currentID;
        private bool activation;

        public FrmStudentRegistration(string mode, string id)
        {
            InitializeComponent();
            studentPresenter = new StudentPresenter();
            ThemeHelper th = new ThemeHelper();
            th.setFormColor(this);
            th.setPanelColor(panelTop);
            th.setGroupBoxColor(groupPersonalInfo);
            th.setGroupBoxColor(groupSchoolInfo);
            th.setButtonColor(btnAdd);
            th.setButtonColor(btnUpdate);
            th.setButtonColor(btnDelete);

            th.setRadioButtonColor(rbnMale);
            th.setRadioButtonColor(rbnFemale);

            th.setLabelColor(lblFirstName);
            th.setLabelColor(lblMiddleName);
            th.setLabelColor(lblLastName);
            th.setLabelColor(lblAddress);
            th.setLabelColor(lblContactNo);
            th.setLabelColor(lblEmailAddress);
            th.setLabelColor(lblIDNo);
            th.setLabelColor(lblCourse);
            th.setLabelColor(lblYearAndSection);

            if(mode == "form")
            {
                btnAdd.Text = "Add";
                lblTitle.Text = "STUDENT FORM";
                this.Text = lblTitle.Text;
                if (!String.IsNullOrEmpty(id))
                {
                    currentID = id;
                    btnAdd.Text = "Cancel";
                    btnUpdate.Enabled = true;
                    btnUpdate.FlatStyle = FlatStyle.Flat;
                    btnDelete.Enabled = true;
                    btnDelete.FlatStyle = FlatStyle.Flat;
                    populateFields();
                }
                else
                {
                    btnUpdate.Enabled = false;
                    btnUpdate.FlatStyle = FlatStyle.Standard;
                    btnDelete.Enabled = false;
                }
            } else
            {
                lblStatus.Hide();
                switchIsActivated.Hide();
                lblSwitchStatus.Hide();
                activation = false;
                this.Size = new Size(661, 563);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(btnAdd.Text == "Add")
            {
                if (!String.IsNullOrEmpty(txtIDNo.Text) && !String.IsNullOrEmpty(txtFirstName.Text) &&
                !String.IsNullOrEmpty(txtMiddleName.Text) && !String.IsNullOrEmpty(txtLastName.Text) &&
                !String.IsNullOrEmpty(txtAddress.Text) && !String.IsNullOrEmpty(txtContactNo.Text) &&
                !String.IsNullOrEmpty(txtEmailAddress.Text) && (rbnMale.Checked == true || rbnFemale.Checked == true))
                {
                    setStudent();
                    studentPresenter.addStudent();

                    MessageBox.Show("Student successfully added", "Students", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please fill up the form correctly", "Students", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }
            } else
            {
                if (!String.IsNullOrEmpty(txtIDNo.Text) && !String.IsNullOrEmpty(txtFirstName.Text) &&
                !String.IsNullOrEmpty(txtMiddleName.Text) && !String.IsNullOrEmpty(txtLastName.Text) &&
                !String.IsNullOrEmpty(txtAddress.Text) && !String.IsNullOrEmpty(txtContactNo.Text) &&
                !String.IsNullOrEmpty(txtEmailAddress.Text) && (rbnMale.Checked == true || rbnFemale.Checked == true))
                {
                    setStudent();
                    studentPresenter.addStudent();

                    MessageBox.Show("Account successfully added and is pending for approval", "Student Registration", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Please fill up the form correctly", "Students", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtIDNo.Text) && !String.IsNullOrEmpty(txtFirstName.Text) &&
                !String.IsNullOrEmpty(txtMiddleName.Text) && !String.IsNullOrEmpty(txtLastName.Text) &&
                !String.IsNullOrEmpty(txtAddress.Text) && !String.IsNullOrEmpty(txtContactNo.Text) &&
                !String.IsNullOrEmpty(txtEmailAddress.Text) && (rbnMale.Checked == true || rbnFemale.Checked == true))
            {
                setStudent();
                studentPresenter.updateStudent(currentID);

                MessageBox.Show("Student successfully updated", "Students", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill up the form correctly", "Students", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            studentPresenter.deleteStudent(currentID);
            MessageBox.Show("Student successfully deleted", "Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void switchIsActivated_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(currentID))
            {
                studentPresenter.studentActivation(currentID, switchIsActivated, lblSwitchStatus);
            } else if(this.Size == new Size(661, 563))
            {
                if (switchIsActivated.SwitchState == XanderUI.XUISwitch.State.On)
                {
                    activation = true;
                    lblSwitchStatus.Text = "Activated";
                }
                else
                {
                    activation = false;
                    lblSwitchStatus.Text = "Deactivated";
                }
            }
        }

        private void populateFields()
        {
            btnAdd.Enabled = false;
            btnAdd.FlatStyle = FlatStyle.Standard;
            btnUpdate.Enabled = true;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnDelete.Enabled = true;
            btnDelete.FlatStyle = FlatStyle.Flat;
            studentPresenter.prepareStudent(currentID, txtFirstName, txtMiddleName, txtLastName, txtAddress, txtContactNo,
                txtEmailAddress, rbnMale, rbnFemale, txtIDNo, txtCourse, txtYearAndSection, switchIsActivated, lblSwitchStatus);
        }

        private void setStudent()
        {

            char gender;
            if (rbnMale.Checked)
            {
                gender = 'M';
            }
            else
            {
                gender = 'F';
            }

            studentPresenter.setStudent(txtIDNo.Text, txtFirstName.Text, txtMiddleName.Text, txtLastName.Text,
                txtAddress.Text, txtContactNo.Text, txtEmailAddress.Text, gender, txtCourse.Text, txtYearAndSection.Text, activation);
        }
    }
}
