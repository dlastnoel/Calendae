using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS.Presenters;

namespace Code_Secret_SOEMS.Views
{
    public partial class CtrlEventDetails : UserControl
    {
        EventDetailsPresenter eventDetailsPresenter = new EventDetailsPresenter();
        int event_id;
        public CtrlEventDetails(int event_id)
        {
            InitializeComponent();
            this.event_id = event_id;
        }

        private void CtrlEventDetails_Load(object sender, EventArgs e)
        {
            eventDetailsPresenter.loadStudentRegistrations(event_id, dataStudentRegistrations);
            eventDetailsPresenter.loadGuestRegistrations(event_id, dataGuestRegistrations);
            eventDetailsPresenter.populateEventDetails(event_id, lblEventName, lblDateAndTime, lblStudentSlots,
                lblStudentRegistrationFee, lblGuestSlots, lblGuestRegistrationFee);
        }
    }
}
