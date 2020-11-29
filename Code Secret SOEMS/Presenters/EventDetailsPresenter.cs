using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS.Models;

namespace Code_Secret_SOEMS.Presenters
{
    class EventDetailsPresenter
    {
        EventDetails _eventDetails = new EventDetails();

        public void loadStudentRegistrations(int event_id, DataGridView myDataGridview)
        {
            _eventDetails.loadStudentRegistrations(event_id, myDataGridview);
        }

        public void loadGuestRegistrations(int event_id, DataGridView myDataGridview)
        {
            _eventDetails.loadGuestRegistrations(event_id, myDataGridview);
        }
    }
}
