using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS.Helpers;


namespace Code_Secret_SOEMS.Models
{
    class EventDetails
    {
        public int event_id { get; set; }
        public string student_id { get; set; }
        public int guest_id { get; set; }

        DatabaseHelper dbHelper = new DatabaseHelper();

        public void loadStudentRegistrations(int event_id, DataGridView myDataGridView)
        {
            dbHelper.createQuery(
                "SELECT " +
                    "students.id AS 'Student ID No.', " +
                    "first_name AS 'First Name', " +
                    "middle_name AS 'Middle Name', " +
                    "last_name AS 'Last Name', " +
                    "contact AS 'Contact No', " +
                    "email AS 'Email Address', " +
                    "course AS 'Course', " +
                    "year_and_section AS 'Year and Section' " +
                "FROM students " +
                "INNER JOIN student_registrations ON " +
                    "student_registrations.student_id = students.id " +
                "WHERE student_registrations.event_id = @id;");
            dbHelper.bindParam("@id", event_id);
            dbHelper.populateDataGridView(myDataGridView);
        }

        public void loadGuestRegistrations(int event_id, DataGridView myDataGridView)
        {
            dbHelper.createQuery(
                "SELECT " +
                    "guests.id AS 'ID', " +
                    "code AS 'Code', " +
                    "first_name AS 'First Name', " +
                    "middle_name AS 'Middle Name', " +
                    "last_name AS 'Last Name', " +
                    "contact AS 'Contact No', " +
                    "email AS 'Email Address' " +
                "FROM guests " +
                "INNER JOIN guest_registrations ON " +
                    "guest_registrations.guest_id = guests.id " +
                "WHERE guest_registrations.event_id = 8;");
            dbHelper.bindParam("@id", event_id);
            dbHelper.populateDataGridView(myDataGridView);
        }
    }
}
