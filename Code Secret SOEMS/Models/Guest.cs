using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS.Helpers;

namespace Code_Secret_SOEMS.Models
{
    class Guest
    {


        DatabaseHelper dbHelper = new DatabaseHelper();

        public void loadGuests(DataGridView myDataGridView)
        {
            dbHelper.createQuery("SELECT * FROM guests");
            dbHelper.populateDataGridView(myDataGridView);
        }
    }
}
