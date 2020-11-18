using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS.Models;

namespace Code_Secret_SOEMS.Presenters
{
    class EventPresenter
    {
        Event _event = new Event();

        public void loadEvents(DataGridView mydataGridView)
        {
            _event.loadEvents(mydataGridView);
        }
    }

}
