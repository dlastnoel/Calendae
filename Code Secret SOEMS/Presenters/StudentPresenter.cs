using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS.Models;

namespace Code_Secret_SOEMS.Presenters
{
    class StudentPresenter
    {
        Student _student = new Student();

        public void loadStudents(DataGridView mydataGridView)
        {
            _student.loadStudents(mydataGridView);
        }
    }
}
