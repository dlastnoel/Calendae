using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS.Models;

namespace Code_Secret_SOEMS.Presenters
{
    class OfficerPresenter
    {
        Officer _officer = new Officer();

        public void loadOfficers(DataGridView myDataGridview)
        {
            _officer.loadOfficers(myDataGridview);
        }
    }
}
