using System;
using System.Drawing;
using System.Windows.Forms;
using Code_Secret_SOEMS.Presenters;
using Code_Secret_SOEMS.Helpers;

namespace Code_Secret_SOEMS.Views
{
    public partial class CtrlEventDetails : UserControl
    {
        private EventDetailsPresenter eventDetailsPresenter;
        private GuestPresenter guestPresenter;
        private ThemeHelper th = new ThemeHelper();
        private int event_id;
        public CtrlEventDetails(int event_id)
        {
            InitializeComponent();
            this.event_id = event_id;
        }

        private void CtrlEventDetails_Load(object sender, EventArgs e)
        {
            eventDetailsPresenter = new EventDetailsPresenter();
            guestPresenter = new GuestPresenter();
            th.setLabelColor(lblEventName);
            th.setLabelColor(lblDateAndTime);
            th.setLabelColor(lblStudentSlots);
            th.setLabelColor(lblStudentRegistrationFee);
            th.setLabelColor(lblGuestSlots);
            th.setLabelColor(lblGuestRegistrationFee);

            eventDetailsPresenter.populateEventDetails(event_id, this, lblEventName, lblDateAndTime, lblStudentSlots,
                lblStudentRegistrationFee, lblGuestSlots, lblGuestRegistrationFee);
            loadData();
            
            triggerFormChange();

        }

        private void CtrlEventDetails_SizeChanged(object sender, EventArgs e)
        {
            triggerFormChange();
        }

        private void dataStudentRegistrations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow dataGridViewRow = dataStudentRegistrations.Rows[indexRow];
            DialogResult prompt = MessageBox.Show("Do you want to unregister " + dataGridViewRow.Cells[1].Value.ToString() + " " +
                dataGridViewRow.Cells[2].Value.ToString() + " " + dataGridViewRow.Cells[3].Value.ToString() + " from " + lblEventName.Text + 
                "?", "Event Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(prompt == DialogResult.Yes)
            {
                eventDetailsPresenter.unregisterStudent(event_id, dataGridViewRow.Cells[0].Value.ToString());
                MessageBox.Show(dataGridViewRow.Cells[1].Value.ToString() + " " + dataGridViewRow.Cells[2].Value.ToString() + " " +
                    dataGridViewRow.Cells[3].Value.ToString() + " successfully unregistered from " + lblEventName.Text, "Event Details",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                eventDetailsPresenter.unregisterStudent(event_id, dataGridViewRow.Cells[0].Value.ToString());
                loadData();
            }
        }

        private void dataGuestRegistrations_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow dataGridViewRow = dataGuestRegistrations.Rows[indexRow];
            DialogResult prompt = MessageBox.Show("Do you want to unregister " + dataGridViewRow.Cells[2].Value.ToString() + " " +
            dataGridViewRow.Cells[3].Value.ToString() + " "+ dataGridViewRow.Cells[4].Value.ToString() + " from " + lblEventName.Text + 
            "?", "Event Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (prompt == DialogResult.Yes)
            {
                MessageBox.Show(dataGridViewRow.Cells[2].Value.ToString() + " " + dataGridViewRow.Cells[3].Value.ToString() + " " +
                dataGridViewRow.Cells[4].Value.ToString() + " successfully unregistered from " + lblEventName.Text, "Event Details",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                eventDetailsPresenter.unregisterGuest(int.Parse(dataGridViewRow.Cells[0].Value.ToString()));
                loadData();
            }
        }

        private void triggerFormChange()
        {
            if (this.Size == new Size(940, 614))
            {
                dataStudentRegistrations.Size = new Size(878, 231);
                dataGuestRegistrations.Size = new Size(878, 231);
                dataGuestRegistrations.Location = new Point(26, 366);
                lblGuestSlots.Location = new Point(24, 345);
                lblGuestRegistrationFee.Location = new Point(266, 345);

                lblEventName.Left = (940 - lblEventName.Width) / 2;
                lblDateAndTime.Left = (940 - lblDateAndTime.Width) / 2;
            }
            else
            {
                dataStudentRegistrations.Size = new Size(747, 823);
                dataGuestRegistrations.Size = new Size(747, 823);
                dataGuestRegistrations.Location = new Point(798, 97);
                lblGuestSlots.Location = new Point(795, 76);
                lblGuestRegistrationFee.Location = new Point(1038, 76);

                lblEventName.Left = (1576 - lblEventName.Width) / 2;
                lblDateAndTime.Left = (1576 - lblDateAndTime.Width) / 2;
            }
        }

        private void loadData()
        {
            eventDetailsPresenter.loadStudentRegistrations(event_id, dataStudentRegistrations);
            eventDetailsPresenter.loadGuestRegistrations(event_id, dataGuestRegistrations);
        }
    }
}
