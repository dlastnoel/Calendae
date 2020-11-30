using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS.Presenters;
using Code_Secret_SOEMS.Helpers;

namespace Code_Secret_SOEMS.Views
{
    public partial class FrmEventRegistration : Form
    {
        ThemeHelper th;
        EventRegistrationPresenter eventRegistrationPresenter;
        int student_slots;
        int guest_slots;
        bool change = false;

        private void clearFields()
        {
            cmbEvents.SelectedIndex = -1;
            lblEventName.Text = "Event Name";
            lblVenue.Text = "Venue:";
            lblDate.Text = "Date:";
            lblTime.Text = "Time:";
            txtEventDetails.Clear();
            lblStudentSlots.Text = "Slots Left";
            lblStudentRegistrationFee.Text = "Registration Fee:";
            lblGuestSlots.Text = "Slots Left";
            lblGuestRegistrationFee.Text = "Registration Fee";
            panelStudentRegistration.Enabled = false;
            panelGuestRegistration.Enabled = false;
        }

        private void setFormTheme()
        {
            th = new ThemeHelper();
            th.setFormColor(this);
            th.setCalendae(pictureBoxCalendae);
            th.setGradientPanelColor(panelLeft);
            th.setLabelColor(lblTitle);
            th.setDragPanelColor(panelTop);
            th.setControlButtonColor(btnClose);
            th.setIconButtonColor(btnTheme);
            th.setIconButtonColor(btnAbout);
            th.setLabelColor(lblEvent);
            th.setLabelColor(lblEventName);
            th.setLabelColor(lblVenue);
            th.setLabelColor(lblDate);
            th.setLabelColor(lblTime);
            th.setLabelColor(lblEventDetails);
            th.setLabelColor(lblStudentRegistration);
            th.setLabelColor(lblIDNo);
            th.setLabelColor(lblStudentSlots);
            th.setLabelColor(lblStudentRegistrationFee);
            th.setLabelColor(lblGuestRegistration);
            th.setLabelColor(lblCode);
            th.setLabelColor(lblGuestSlots);
            th.setLabelColor(lblGuestRegistrationFee);
            th.setButtonColor(btnClear);
            th.setButtonColor(btnCheckStudentRegistration);
            th.setButtonColor(btnStudentRegister);
            th.setButtonColor(btnCheckGuestRegistration);
            th.setButtonColor(btnGuestRegister);
            th.setToolStripStatusLabelColor(toolStripStatusSchoolName);
            th.setToolStripStatusLabelColor(toolStripStatusDate);
            th.setToolStripStatusLabelColor(toolStripStatusTime);
            th.setStripStatusColor(statusStripMain);

        }
        public FrmEventRegistration(string mode)
        {
            InitializeComponent();
            setFormTheme();
            eventRegistrationPresenter = new EventRegistrationPresenter();
            toolStripStatusSchoolName.Text = eventRegistrationPresenter.getSchoolName();
            eventRegistrationPresenter.setEvents(cmbEvents);
            if(String.IsNullOrEmpty(mode))
            {
                btnClose.Text = "←";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(btnClose.Text == "X")
            {
                this.Close();
            } else
            {
                this.Close();
                new FrmLogin().Show();
            }
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            toolStripStatusTime.Text = DateTime.Now.ToString("T");
            if(!change)
            {
                change = true;
            }
        }

        private void FrmEventRegistration_Load(object sender, EventArgs e)
        {
            toolStripStatusDate.Text = DateTime.Now.ToString("dddd, MMMM d, yyyy");
            tmrMain.Start();
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            new FrmTheme().ShowDialog();
            setFormTheme();
        }

        private void cmbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(change)
            {
                if(cmbEvents.SelectedIndex != -1)
                {
                    eventRegistrationPresenter.prepareEvent(cmbEvents, panelEvents, lblEventName, lblVenue, lblDate, lblTime, txtEventDetails,
                        panelStudentRegistration, lblStudentSlots, lblStudentRegistrationFee, panelGuestRegistration, lblGuestSlots, lblGuestRegistrationFee);
                    student_slots = eventRegistrationPresenter.getStudentSlots();
                    guest_slots = eventRegistrationPresenter.getGuestSlots();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if(cmbEvents.SelectedIndex != -1)
            {
                clearFields();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new FrmAbout().ShowDialog();
        }

        private void btnStudentRegister_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtIDNo.Text))
            {
                if (eventRegistrationPresenter.registerStudent(txtIDNo.Text) == 1)
                {
                    MessageBox.Show("You have successfully registered to " + cmbEvents.Text, "Event Registration",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else if(eventRegistrationPresenter.registerStudent(txtIDNo.Text) == 2)
                {
                    MessageBox.Show("You are already registered to " + cmbEvents.Text, "Event Registration",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else if (eventRegistrationPresenter.registerStudent(txtIDNo.Text) == 3)
                {
                    MessageBox.Show("Registration unsuccessful, your acount is not yet activated", "Event Registration", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("ID No. cannot be empty", "Event Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCheckStudentRegistration_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtIDNo.Text))
            {

            }
            else
            {
                MessageBox.Show("ID No. cannot be empty", "Event Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuestRegister_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCode.Text))
            {

            }
            else
            {
                MessageBox.Show("Guest code cannot be empty", "Event Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
