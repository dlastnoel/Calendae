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
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name{ get; set; }
        public string  address { get; set; }
        public string contact { get; set; }
        public string email { get; set; }
        public char gender { get; set; }
        public string school_name { get; set; }
        public string course { get; set; }
        public string year { get; set; }
        public string works_at { get; set; }
        public string position { get; set; }
        public string code { get; set; }
        public bool is_activated { get; set; }
        public int event_id { get; set; }

        DatabaseHelper dbHelper = new DatabaseHelper();

        public void generateCode()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] stringChars = new char[8];
            Random random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            String finalString = new String(stringChars);
            code = finalString;
        }

        public void loadGuests(DataGridView myDataGridView)
        {
            dbHelper.createQuery(
                "SELECT " +
                    "guests.id AS 'ID', " +
                    "IF(guests.is_activated = 1, 'Activated', 'Deactivated') AS 'Status', " +
                    "event_name AS 'Event Name', " +
                    "code AS 'Guest Code', " +
                    "first_name AS 'First Name', " +
                    "last_name AS 'Last Name', " +
                    "address AS 'Address', " +
                    "contact AS 'Contact No', " +
                    "email AS 'Email Address' " +
                "FROM guests " +
                "INNER JOIN events ON " +
                    "events.id = guests.event_id; ");
            dbHelper.populateDataGridView(myDataGridView);
        }

        public void addGuest()
        {
            dbHelper.createQuery("INSERT INTO guests (first_name, middle_name, last_name, address, contact, email, gender, " +
                "school_name, course, year, works_at, position, code, is_activated, event_id) VALUES (@first_name, @middle_name, " +
                "@last_name, @address, @contact, @email, @gender, @school_name, @course, @year, @works_at, @position, @code, " +
                "@is_activated, @event_id);");

            generateCode();

            dbHelper.bindParam("@first_name", first_name);
            dbHelper.bindParam("@middle_name", middle_name);
            dbHelper.bindParam("@last_name", last_name);
            dbHelper.bindParam("@address", address);
            dbHelper.bindParam("@contact", contact);
            dbHelper.bindParam("@email", email);
            dbHelper.bindParam("@gender", gender);
            dbHelper.bindParam("@school_name", school_name);
            dbHelper.bindParam("@course", course);
            dbHelper.bindParam("@year", year);
            dbHelper.bindParam("@works_at", works_at);
            dbHelper.bindParam("@position", position);
            dbHelper.bindParam("@code", code);
            dbHelper.bindParam("@is_activated", is_activated);
            dbHelper.bindParam("@event_id", event_id);

            dbHelper.executeQuery();
        }

        public void selectGuest(int currentID)
        {
            dbHelper.createQuery(
                "SELECT " +
                    "guests.id, first_name, middle_name, last_name, " +
                    "address, contact, email, gender, school_name, " +
                    "course, year, works_at, position, code, guests.is_activated, " +
                    "event_id, event_name " +
                "FROM guests " +
                "INNER JOIN events ON " +
                    "events.id = guests.event_id " +
                "WHERE guests.id = @id; ");
            dbHelper.bindParam("@id", currentID);
        }

        public string getGuestDetails(string item)
        {
            return dbHelper.getFromReader(item);
        }

        public int getLastGuestID()
        {
            return dbHelper.getLastID();
        }

        public void updateGuest(int currentID)
        {
            dbHelper.createQuery(
                "UPDATE guests SET " +
                    "first_name = @first_name, " +
                    "middle_name = @middle_name, " +
                    "last_name = @last_name, " +
                    "address = @address, " +
                    "contact = @contact, " +
                    "email = @email, " +
                    "gender = @gender, " +
                    "school_name = @school_name, " +
                    "course = @course, " +
                    "year = @year, " +
                    "works_at = @works_at, " +
                    "position = @position, " +
                    "is_activated = @is_activated, " +
                    "event_id = @event_id " +
                "WHERE id = @id;") ;

            dbHelper.bindParam("@first_name", first_name);
            dbHelper.bindParam("@middle_name", middle_name);
            dbHelper.bindParam("@last_name", last_name);
            dbHelper.bindParam("@address", address);
            dbHelper.bindParam("@contact", contact);
            dbHelper.bindParam("@email", email);
            dbHelper.bindParam("@gender", gender);
            dbHelper.bindParam("@school_name", school_name);
            dbHelper.bindParam("@course", course);
            dbHelper.bindParam("@year", year);
            dbHelper.bindParam("@works_at", works_at);
            dbHelper.bindParam("@position", position);
            dbHelper.bindParam("@is_activated", is_activated);
            dbHelper.bindParam("@event_id", event_id);
            dbHelper.bindParam("@id", currentID);


            dbHelper.executeQuery();
        }

        public void deleteGuest(int currentID)
        {
            dbHelper.createQuery("DELETE FROM guests WHERE id = @id;");
            dbHelper.bindParam("@id", currentID);

            dbHelper.executeQuery();
        }
    }
}
