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
                    "students.id AS 'ID', " +
                    "first_name AS 'First Name', " +
                    "middle_name AS 'Middle Name', " +
                    "last_name AS 'Last Name', " +
                    "contact AS 'Contact No', " +
                    "course AS 'Course', " +
                    "year_and_section AS 'Year/Section' " +
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
                "WHERE guest_registrations.event_id = @id AND guests.is_activated = @is_activated;");
            dbHelper.bindParam("@id", event_id);
            dbHelper.bindParam("@is_activated", 1);
            dbHelper.populateDataGridView(myDataGridView);
        }

        public bool addGuestParticipant()
        {
            dbHelper.createQuery("SELECT COUNT(*) FROM guest_registrations WHERE event_id = @event_id AND " +
                "guest_id = @guest_id;");
            dbHelper.bindParam("@event_id", event_id);
            dbHelper.bindParam("@guest_id", guest_id);
            if (dbHelper.getCount() > 0)
            {
                return false;
            } else
            {
                dbHelper.createQuery("INSERT INTO guest_registrations (event_id, guest_id) VALUES (@event_id, @guest_id);");
                dbHelper.bindParam("@event_id", event_id);
                dbHelper.bindParam("@guest_id", guest_id);

                dbHelper.executeQuery();
                return true;
            }
        }

        public int addStudentParticipant()
        {
            // 0 - not found
            // 1 - successfuly registered
            // 2 - already registered
            // 3 - not active


            dbHelper.createQuery("SELECT COUNT(*) FROM students WHERE id = @student_id;");
            dbHelper.bindParam("@student_id", student_id);
            if (dbHelper.getCount() > 0)
            {
                // Student found
                dbHelper.createQuery("SELECT COUNT(*) FROM students WHERE id = @student_id AND is_activated = @is_activated;");
                dbHelper.bindParam("@student_id", student_id);
                dbHelper.bindParam("@is_activated", 0);
                if (dbHelper.getCount() > 0)
                {
                    // Student not activated
                    return 3;
                } else
                {
                    dbHelper.createQuery("SELECT COUNT(*) FROM student_registrations WHERE event_id = @event_id AND " +
                    "student_id = @student_id;");
                    dbHelper.bindParam("@event_id", event_id);
                    dbHelper.bindParam("@student_id", student_id);
                    if (dbHelper.getCount() > 0)
                    {
                        // Student already registered
                        return 2;
                    }
                    else
                    {
                        // Student successfully registered
                        dbHelper.createQuery("INSERT INTO student_registrations (event_id, student_id) VALUES (@event_id, @student_id);");
                        dbHelper.bindParam("@event_id", event_id);
                        dbHelper.bindParam("@student_id", student_id);

                        dbHelper.executeQuery();
                        return 1;
                    }
                }
            }
            else
            {
                // Student not found
                return 0;
            }
        }
        public int selectGuestByCode(string code)
        {
            // 0 - code not found
            // 1 - event not found
            // 2 - guest approved
            // 3 - guest pending
            dbHelper.createQuery("SELECT COUNT(*) FROM guests WHERE code = @code");
            dbHelper.bindParam("@code", code);
            if (dbHelper.getCount() > 0)
            {
                // Code found
                dbHelper.createQuery("SELECT COUNT(*) FROM guests WHERE event_id = @event_id " +
                "AND code = @code;");
                dbHelper.bindParam("@event_id", event_id);
                dbHelper.bindParam("@code", code);
                if (dbHelper.getCount() > 0)
                {
                    dbHelper.createQuery("SELECT COUNT(*) FROM guests WHERE event_id = @event_id " +
                    "AND code = @code AND is_activated = @is_activated;");
                    dbHelper.bindParam("@event_id", event_id);
                    dbHelper.bindParam("@code", code);
                    dbHelper.bindParam("@is_activated", 1);
                    if(dbHelper.getCount() > 0)
                    {
                        dbHelper.createQuery("SELECT * FROM guests WHERE event_id = @event_id " +
                        "AND code = @code AND is_activated = @is_activated;");
                        dbHelper.bindParam("@event_id", event_id);
                        dbHelper.bindParam("@code", code);
                        dbHelper.bindParam("@is_activated", 1);
                        // Guest approved
                        return 2;
                    } else
                    {
                        dbHelper.createQuery("SELECT * FROM guests WHERE event_id = @event_id " +
                        "AND code = @code;");
                        dbHelper.bindParam("@event_id", event_id);
                        dbHelper.bindParam("@code", code);
                        // Guest pending
                        return 3;
                    }
                }
                else
                {
                    // Event not found
                    return 1;
                }
            } else
            {
                // Code not found
                return 0;
            }

            
        }
        public string getEventDetails(string item)
        {
            return dbHelper.getFromReader(item);
        }

        public void removeStudentParticipant(int event_id, string student_id)
        {
            dbHelper.createQuery("DELETE FROM student_registrations WHERE " +
                "event_id = @event_id AND student_id = @student_id;");
            dbHelper.bindParam("@event_id", event_id);
            dbHelper.bindParam("@student_id", student_id);

            dbHelper.executeQuery();
        }

        public void removeGuestParticipant(int guest_id)
        {
            dbHelper.createQuery("UPDATE guests SET is_activated = @is_activated WHERE id = @guest_id;");
            dbHelper.bindParam("@is_activated", 0);
            dbHelper.bindParam("@guest_id", guest_id);

            dbHelper.executeQuery();
        }

        public int getRegisteredStudents(int event_id)
        {
            dbHelper.createQuery("SELECT COUNT(*) FROM student_registrations WHERE event_id = @event_id;");
            dbHelper.bindParam("@event_id", event_id);
            return dbHelper.getCount();
        }
        public int getRegisteredGuests(int event_id)
        {
            dbHelper.createQuery("SELECT COUNT(*) FROM guest_registrations WHERE event_id = @event_id");
            dbHelper.bindParam("@event_id", event_id);
            return dbHelper.getCount();
        }
    }
}
