using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS.Models;

namespace Code_Secret_SOEMS.Presenters
{
    class GuestPresenter
    {
        Guest _guest = new Guest();

        public void loadStudents(DataGridView mydataGridView)
        {
            _guest.loadGuests(mydataGridView);
        }
    }
}
