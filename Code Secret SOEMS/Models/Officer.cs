using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS.Helpers;

namespace Code_Secret_SOEMS.Models
{
    class Officer
    {
        public string id { get; set; }
        public string position { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public string address { get; set; }
        public string contact { get; set; }
        public string email { get; set; }
        public char gender { get; set; }
        public string course { get; set; }
        public string year_and_section { get; set; }
        public string password { get; set; }

        private DatabaseHelper dbHelper;
        private PasswordHelper ph;

        public Officer()
        {
            dbHelper = new DatabaseHelper();
            ph = new PasswordHelper();
        }
        

        // DISPLAYING DATA
        public void loadOfficers(DataGridView myDataGridView)
        {
            dbHelper.createQuery(
                "SELECT " +
                    "id AS 'ID No.', " +
                    "position AS 'Position', " +
                    "first_name AS 'First Name', " +
                    "middle_name AS 'Middle Name', " +
                    "last_name AS 'Last Name', " +
                    "address AS 'Address', " +
                    "contact AS 'Contact No.', " +
                    "email AS 'Email Address', " +
                    "gender AS 'Gender', " +
                    "course AS 'Course', " +
                    "year_and_section AS 'Year and Section' " +
                "FROM officers WHERE " +
                    "position != 'Adviser';");
            dbHelper.populateDataGridView(myDataGridView);
        }

        public void addOfficer()
        {
            dbHelper.createQuery("INSERT INTO officers (id, position, first_name, middle_name, last_name, " +
                "address, contact, email, gender, course, year_and_section, password) VALUES (" +
                "@id, @position, @first_name, @middle_name, @last_name, @address, @contact, @email, @gender, " +
                "@course, @year_and_seciton, @password); ");

            password = ph.hashPassword(password);

            dbHelper.bindParam("@id", id);
            dbHelper.bindParam("@position", position);
            dbHelper.bindParam("@first_name", first_name);
            dbHelper.bindParam("@middle_name", middle_name);
            dbHelper.bindParam("@last_name", last_name);
            dbHelper.bindParam("@address", address);
            dbHelper.bindParam("@contact", contact);
            dbHelper.bindParam("@email", email);
            dbHelper.bindParam("@gender", gender);
            dbHelper.bindParam("@course", course);
            dbHelper.bindParam("@year_and_seciton", year_and_section);
            dbHelper.bindParam("@password", password);

            dbHelper.executeQuery();
        }

        public bool loginOfficer(string id, string userPassword)
        {
            string hashPassword;
            dbHelper.createQuery("SELECT * FROM officers WHERE id = @id;");
            dbHelper.bindParam("@id", id);

            if(dbHelper.executeReader())
            {
                hashPassword = dbHelper.getFromReader("password");

                if(ph.IsValidPassword(userPassword, hashPassword))
                {
                    // correct password
                    return true;
                }
                else
                {
                    // incorrect password
                    return false;
                }
            } else
            {
                // no user found
                return false;
            }
        }

        public string getLoggedInOfficer(string item)
        {
            return dbHelper.getFromReader(item);
        }

        public void selectOfficer(string id)
        {
            dbHelper.createQuery("SELECT * FROM officers WHERE id = @id;");
            dbHelper.bindParam("@id", id);
        }

        public void updateOfficer(string currentIDNo)
        {
            dbHelper.createQuery(
                "UPDATE officers SET " +
                    "id = @id, " +
                    "position = @position," +
                    "first_name = @first_name, " +
                    "middle_name = @middle_name, " +
                    "last_name = @last_name, " +
                    "address = @address, " +
                    "contact = @contact," +
                    "email = @email, " +
                    "gender = @gender, " +
                    "course = @course, " +
                    "year_and_section = @year_and_section, " +
                    "password = @password " +
                 "WHERE id = @current_id;"
                );

            password = ph.hashPassword(password);

            dbHelper.bindParam("@id", id);
            dbHelper.bindParam("@position", position);
            dbHelper.bindParam("@first_name", first_name);
            dbHelper.bindParam("@middle_name", middle_name);
            dbHelper.bindParam("@last_name", last_name);
            dbHelper.bindParam("@address", address);
            dbHelper.bindParam("@contact", contact);
            dbHelper.bindParam("@email", email);
            dbHelper.bindParam("@gender", gender);
            dbHelper.bindParam("@course", course);
            dbHelper.bindParam("@year_and_section", year_and_section);
            dbHelper.bindParam("@password", password);
            dbHelper.bindParam("@current_id", currentIDNo);

            dbHelper.executeQuery();

        }

        public void deleteOfficer(string currentIDNo)
        {
            dbHelper.createQuery("DELETE FROM officers WHERE id = @id;");
            dbHelper.bindParam("@id", currentIDNo);

            dbHelper.executeQuery();
        }

        public string getOfficerDetails(string item)
        {
            return dbHelper.getFromReader(item);
        }

    }
}
