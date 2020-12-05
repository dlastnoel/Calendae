using System;
using System.Windows.Forms;
using Code_Secret_SOEMS.Presenters;
using Code_Secret_SOEMS.Helpers;

namespace Code_Secret_SOEMS.Views
{
    public partial class FrmEventRegistration : Form
    {
        private ThemeHelper th;
        private EventRegistrationPresenter eventRegistrationPresenter;
        int student_slots;
        int guest_slots;
        bool change = false;

        private void clearFields()
        {
            txtCode.Clear();
            txtIDNo.Clear();
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
            th.setIconButtonBackColor(btnTheme);
            th.setIconButtonBackColor(btnAbout);
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
                populateEventDetails();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
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
            eventRegistrationPresenter.setEvents(cmbEvents);
            cmbEvents.SelectedIndex = -1;
            clearFields();
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
                    clearFields();
                    populateEventDetails();
                } else if(eventRegistrationPresenter.registerStudent(txtIDNo.Text) == 2)
                {
                    MessageBox.Show("You are already registered to " + cmbEvents.Text, "Event Registration",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult prompt = MessageBox.Show("Do you want to unregister from " + cmbEvents.Text + "?",
                        "Event Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(prompt ==  DialogResult.Yes)
                    {
                        eventRegistrationPresenter.unregisterStudent(txtIDNo.Text);
                        MessageBox.Show("You have successfully unregistered from " + cmbEvents.Text, "Event Registration",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIDNo.Clear();
                    }
                    clearFields();
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

        private void btnGuestRegister_Click(object sender, EventArgs e)
        {
            new FrmGuests(lblEventName.Text, 0).ShowDialog();
            clearFields();
            populateEventDetails();
        }

        private void btnCheckGuestRegistration_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCode.Text))
            {
                // 0 - code not found
                // 1 - event not found
                // 2 - guest approved
                // 3 - guest pending
                if (eventRegistrationPresenter.checkGuestRegistration(txtCode.Text) == 3)
                {
                    MessageBox.Show("The registration of " + eventRegistrationPresenter.getGuestFullName() +
                        " is still pending", "Event Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else if (eventRegistrationPresenter.checkGuestRegistration(txtCode.Text) == 2)
                {
                    MessageBox.Show("The registration of " + eventRegistrationPresenter.getGuestFullName() +
                        " was already approved. See you there! ", "Event Registration", MessageBoxButtons.OK, 
                        MessageBoxIcon.Information);
                } else
                {
                    MessageBox.Show("Registration not found", "Event Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtCode.Clear();
            }
            else
            {
                MessageBox.Show("Guest code cannot be empty", "Event Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void populateEventDetails()
        {
            if (cmbEvents.SelectedIndex != -1)
            {
                eventRegistrationPresenter.prepareEvent(cmbEvents, panelEvents, lblEventName, lblVenue, lblDate, lblTime, txtEventDetails,
                    panelStudentRegistration, lblStudentSlots, lblStudentRegistrationFee, panelGuestRegistration, lblGuestSlots, lblGuestRegistrationFee);
                student_slots = eventRegistrationPresenter.getStudentSlots();
                guest_slots = eventRegistrationPresenter.getGuestSlots();
            }
        }
    }
}
