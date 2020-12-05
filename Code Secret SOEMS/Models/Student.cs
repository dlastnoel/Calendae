using System.Collections.Generic;
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
        public bool is_activated { get; set; }

        private DatabaseHelper dbHelper;

        // Construcor
        public Student()
        {
            dbHelper = new DatabaseHelper();
        }

        // Load student data on DataGridView
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

        // Search and load student data on DataGridView
        public void searchStudents(string search, DataGridView myDataGridView)
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
                "FROM students " +
                "WHERE id LIKE CONCAT('%',@search,'%') " +
                "OR id LIKE CONCAT('%',@search,'%') " +
                "OR first_name LIKE CONCAT('%',@search,'%') " +
                "OR middle_name LIKE CONCAT('%',@search,'%') " +
                "OR last_name LIKE CONCAT('%',@search,'%') ;");
            dbHelper.bindParam("@search", search);
            dbHelper.populateDataGridView(myDataGridView);
        }

        // Count all students (active/inactive/both)
        public int countAllStudents(int? is_activated)
        {
            if(is_activated != null)
            {
                dbHelper.createQuery("SELECT COUNT(*) FROM students WHERE is_activated = @is_activated");
                dbHelper.bindParam("@is_activated", is_activated);
            } else
            {
                dbHelper.createQuery("SELECT COUNT(*) FROM students;");
            }
            return dbHelper.getCount();

        }
        
        // Gets all inactive students
        // Returns result as string List (student_id)
        public List<string> getInactiveStudentIds()
        {
            dbHelper.createQuery("SELECT * FROM students WHERE is_activated = 0;");
            return dbHelper.getResultList("id");
        }

        // Updates student activation (activate/deactivate)
        public void studentActivation(string student_id, int is_activated)
        {
            dbHelper.createQuery("UPDATE students SET is_activated = @is_activated WHERE " +
                "id = @student_id;");
            dbHelper.bindParam("@is_activated", is_activated);
            dbHelper.bindParam("@student_id", student_id);

            dbHelper.executeQuery();
        }

        // Add student
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

        // Select student by id
        public void selectStudent(string id)
        {
            dbHelper.createQuery("SELECT * FROM students WHERE id = @id");
            dbHelper.bindParam("@id", id);
        }

        // Updates student
        public void updateStudent(string student_id)
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
                    "year_and_section = @year_and_section " +
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
            dbHelper.bindParam("@current_id", student_id);

            dbHelper.executeQuery();
        }

        // Deletes student
        public void deleteStudent(string student_id)
        {
            dbHelper.createQuery("DELETE FROM students WHERE id = @id");
            dbHelper.bindParam("@id", student_id);

            dbHelper.executeQuery();
        }

        // Reads query
        // Returns result as string
        public string getStudentData(string item)
        {
            return dbHelper.getFromReader(item);
        }
    }
}
