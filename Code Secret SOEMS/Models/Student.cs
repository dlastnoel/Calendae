using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS.Helpers;

namespace Code_Secret_SOEMS.Models
{
    class Student
    {
        public string id { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public string address { get; set; }
        public string contact { get; set; }
        public string email { get; set; }
        public char gender { get; set; }
        public string course { get; set; }
        public string year_and_section { get; set; }
        public int is_activated { get; set; }

        DatabaseHelper dbHelper = new DatabaseHelper();

        public Student()
        {
            dbHelper = new DatabaseHelper();
        }

        public void loadStudents(DataGridView myDataGridView)
        {
            dbHelper.createQuery(
                "SELECT " +
                    "id AS 'Student ID No.', " +
                    "IF(is_activated = 1, 'Activated', 'Deactivated') AS 'Status', " +
                    "first_name AS 'First Name', " +
                    "middle_name AS 'Middle Name', " +
                    "last_name AS 'Last Name', " +
                    "address AS 'Address', " +
                    "contact AS 'Contact No.', " +
                    "email AS 'Email Address', " +
                    "gender AS 'Gender', " +
                    "course AS 'Course', " +
                    "year_and_section AS 'Year and Section' " +
                "FROM students;");
            dbHelper.populateDataGridView(myDataGridView);
        }

        public int countAllStudents()
        {
            dbHelper.createQuery("SELECT COUNT(*) FROM students;");
            return dbHelper.getCount();
        }

        public int countAllInactiveStudents()
        {
            dbHelper.createQuery("SELECT COUNT(*) FROM students WHERE is_activated = @is_activated");
            dbHelper.bindParam("@is_activated", 0);
            return dbHelper.getCount();
        }
        
        public List<string> getInactiveStudentIds()
        {
            dbHelper.createQuery("SELECT * FROM students WHERE is_activated = 0;");
            return dbHelper.getResultList("id");
        }

        public void activateStudent(string student_id)
        {
            dbHelper.createQuery("UPDATE students SET is_activated = @is_activated WHERE " +
                "id = @student_id;");
            dbHelper.bindParam("@is_activated", 1);
            dbHelper.bindParam("@student_id", student_id);

            dbHelper.executeQuery();
        }
        public void deactivateStudent(string student_id)
        {
            dbHelper.createQuery("UPDATE students SET is_activated = @is_activated WHERE " +
                "id = @student_id;");
            dbHelper.bindParam("@is_activated", 0);
            dbHelper.bindParam("@student_id", student_id);

            dbHelper.executeQuery();
        }

        public void addStudent()
        {
            dbHelper.createQuery("INSERT INTO students (id, first_name, middle_name, last_name, address, contact, email, gender, " +
                "course, year_and_section, is_activated) VALUES (@id, @first_name, @middle_name, @last_name, @address, @contact, " +
                "@email, @gender, @course, @year_and_section, @is_activated);");

            dbHelper.bindParam("@id", id);
            dbHelper.bindParam("@first_name", first_name);
            dbHelper.bindParam("@middle_name", middle_name);
            dbHelper.bindParam("@last_name", last_name);
            dbHelper.bindParam("@address", address);
            dbHelper.bindParam("@contact", contact);
            dbHelper.bindParam("@email", email);
            dbHelper.bindParam("@gender", gender);
            dbHelper.bindParam("@course", course);
            dbHelper.bindParam("@year_and_section", year_and_section);
            dbHelper.bindParam("@is_activated", is_activated);

            dbHelper.executeQuery();
        }

        public void selectStudent(string id)
        {
            dbHelper.createQuery("SELECT * FROM students WHERE id = @id");
            dbHelper.bindParam("@id", id);
        }

        public void updateStudent(string currentID)
        {
            dbHelper.createQuery(
                "UPDATE students SET " +
                    "id = @id, " +
                    "first_name = @first_name, " +
                    "middle_name = @middle_name, " +
                    "last_name = @last_name, " +
                    "address = @address, " +
                    "contact = @contact," +
                    "email = @email, " +
                    "gender = @gender, " +
                    "course = @course, " +
                    "year_and_section = @year_and_section, " +
                    "is_activated = @is_activated " +
                 "WHERE id = @current_id;"
                );

            dbHelper.bindParam("@id", id);
            dbHelper.bindParam("@first_name", first_name);
            dbHelper.bindParam("@middle_name", middle_name);
            dbHelper.bindParam("@last_name", last_name);
            dbHelper.bindParam("@address", address);
            dbHelper.bindParam("@contact", contact);
            dbHelper.bindParam("@email", email);
            dbHelper.bindParam("@gender", gender);
            dbHelper.bindParam("@course", course);
            dbHelper.bindParam("@year_and_section", year_and_section);
            dbHelper.bindParam("@is_activated", is_activated);
            dbHelper.bindParam("@current_id", currentID);

            dbHelper.executeQuery();
        }

        public void deleteStudent(string id)
        {
            dbHelper.createQuery("DELETE FROM students WHERE id = @id");
            dbHelper.bindParam("@id", id);

            dbHelper.executeQuery();
        }

        public string getStudentDetails(string item)
        {
            return dbHelper.getFromReader(item);
        }
    }
}
