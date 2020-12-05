using System;
using System.Drawing;
using System.Windows.Forms;
using Code_Secret_SOEMS.Helpers;
using Code_Secret_SOEMS.Presenters;

namespace Code_Secret_SOEMS
{
    public partial class CtrlStudents : UserControl
    {
        private StudentPresenter studentPresenter;
        private ThemeHelper th;
        private string student_id;
        private bool activation;

        public CtrlStudents()
        {
            InitializeComponent();
            studentPresenter = new StudentPresenter();
            th = new ThemeHelper();

            btnUpdate.Enabled = false;
            btnUpdate.FlatStyle = FlatStyle.Standard;
            btnDelete.Enabled = false;
            btnDelete.FlatStyle = FlatStyle.Standard;
        }

        private void CtrlStudents_SizeChanged(object sender, EventArgs e)
        {
            if (this.Size == new Size(940, 614))
            {
                btnOpenForm.Show();
            }
            else
            {
                btnOpenForm.Hide();
            }
        }

        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            new FrmStudentRegistration("form","").ShowDialog();
            studentPresenter.loadStudents(dataStudents);
        }

        private void CtrlStudents_Load(object sender, EventArgs e)
        {
            th.setUserControlColor(this);
            th.setGroupBoxColor(groupPersonalInfo);
            th.setGroupBoxColor(groupSchoolInfo);
            th.setButtonColor(btnOpenForm);
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

            studentPresenter.loadStudents(dataStudents);
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
                    clearFields();
                    studentPresenter.loadStudents(dataStudents);
                }
                else
                {
                    MessageBox.Show("Please fill up the form correctly", "Students", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                }
            } else
            {
                clearFields();
            }
        }

        private void dataStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow dataGridViewRow = dataStudents.Rows[indexRow];
            student_id = dataGridViewRow.Cells[0].Value.ToString();

            if (this.Size == new Size(1576, 956))
            {
                populateFields();
                studentPresenter.loadStudents(dataStudents);
                txtSearch.Text = "Search";
                txtSearch.ForeColor = Color.Gray;

            }
            else
            {
                FrmStudentRegistration frmStudentRegistration = new FrmStudentRegistration("form", student_id);
                frmStudentRegistration.ShowDialog();
                studentPresenter.loadStudents(dataStudents);
                txtSearch.Text = "Search";
                txtSearch.ForeColor = Color.Gray;
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
                studentPresenter.updateStudent(student_id);

                MessageBox.Show("Student successfully updated", "Students", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                clearFields();
                studentPresenter.loadStudents(dataStudents);
            }
            else
            {
                MessageBox.Show("Please fill up the form correctly", "Students", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            studentPresenter.deleteStudent(student_id);
            MessageBox.Show("Student successfully deleted", "Student", MessageBoxButtons.OK, MessageBoxIcon.Information);

            studentPresenter.loadStudents(dataStudents);
        }

        private void switchIsActivated_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(student_id))
            {
                studentPresenter.studentActivation(student_id, switchIsActivated, lblSwitchStatus);
                if (switchIsActivated.SwitchState == XanderUI.XUISwitch.State.On)
                {
                    lblSwitchStatus.Text = "Activated";
                }
                else
                {
                    lblSwitchStatus.Text = "Deactivated";
                }
                studentPresenter.loadStudents(dataStudents);
            } else
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
            btnAdd.Text = "Cancel";
            btnUpdate.Enabled = true;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnDelete.Enabled = true;
            btnDelete.FlatStyle = FlatStyle.Flat;
            studentPresenter.prepareStudent(student_id, txtFirstName, txtMiddleName, txtLastName, txtAddress, txtContactNo,
                txtEmailAddress, rbnMale, rbnFemale, txtIDNo, txtCourse, txtYearAndSection, switchIsActivated, lblSwitchStatus);
        }

        private void clearFields()
        {
            student_id = "";
            txtIDNo.Clear();
            txtFirstName.Clear();
            txtMiddleName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtContactNo.Clear();
            txtEmailAddress.Clear();
            rbnMale.Checked = false;
            rbnFemale.Checked = false;
            txtCourse.Clear();
            txtYearAndSection.Clear();

            btnAdd.Text = "Add";
            btnUpdate.Enabled = false;
            btnUpdate.FlatStyle = FlatStyle.Standard;
            btnDelete.Enabled = false;
            btnDelete.FlatStyle = FlatStyle.Standard;

            txtSearch.Text = "Search";
            txtSearch.ForeColor = Color.Gray;
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSearch.Text))
            {
                studentPresenter.searchStudents(txtSearch.Text, dataStudents);
            }
            else
            {
                studentPresenter.loadStudents(dataStudents);
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Clear();
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearch.Text))
            {
                txtSearch.Text = "Search";
                txtSearch.ForeColor = Color.Gray;
            }
        }
    }
}
