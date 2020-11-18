using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS.Helpers;
using Code_Secret_SOEMS.Presenters;

namespace Code_Secret_SOEMS
{
    public partial class CtrlEvents : UserControl
    {
        private EventPresenter eventPresenter = new EventPresenter();
        public CtrlEvents()
        {
            InitializeComponent();
        }

        private void checkGuests_CheckedChanged(object sender, EventArgs e)
        {
            if(checkGuests.CheckState == CheckState.Checked)
            {
                groupGuests.Enabled = true;
            } else
            {
                groupGuests.Enabled = false;
            }
        }

        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            new FrmEvents().ShowDialog();
        }

        private void CtrlEvents_SizeChanged(object sender, EventArgs e)
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

        private void CtrlEvents_Load(object sender, EventArgs e)
        {
            ThemeHelper th = new ThemeHelper();
            th.setUserControlColor(this);
            th.setGroupBoxColor(groupEventInfo);
            th.setGroupBoxColor(groupGuests);
            th.setCheckBoxColor(checkGuests);
            th.setButtonColor(btnOpenForm);
            th.setButtonColor(btnAdd);
            th.setButtonColor(btnUpdate);
            th.setButtonColor(btnDelete);

            th.setLabelColor(lblEventName);
            th.setLabelColor(lblVenue);
            th.setLabelColor(lblDate);
            th.setLabelColor(lblTime);
            th.setLabelColor(lblStudentRegistrationFee);
            th.setLabelColor(lblStudentSlots);
            th.setLabelColor(lblGuestRegistrationFee);
            th.setLabelColor(lblGuestSlots);

            th.setLabelColor(lblInfo1);
            th.setLabelColor(lblInfo2);
            th.setLabelColor(lblInfo3);
            th.setLabelColor(lblInfo4);

            eventPresenter.loadEvents(dataEvents);
        }
    }
}
