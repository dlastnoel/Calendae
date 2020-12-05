using System;
using System.Collections.Generic;
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

        private DatabaseHelper dbHelper;

        // Constructor
        public Guest()
        {
            dbHelper = new DatabaseHelper();
        }

        // Load guest data on DataGridView
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

        // Search and load guest data on DataGridView
        public void searchGuests(string name, DataGridView myDataGridView)
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
                    "events.id = guests.event_id " +
                "WHERE first_name LIKE CONCAT('%',@name,'%') " +
                "OR middle_name LIKE CONCAT('%',@name,'%') " +
                "OR last_name LIKE CONCAT('%',@name,'%');");
            dbHelper.bindParam("@name", name);
            dbHelper.populateDataGridView(myDataGridView);
        }

        //Selects guest by id
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

        // Generate guest check code
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

        // Get all inactivate guests
        // Returns result as string List (guest_id)
        public List<string> getInactiveGuestIds()
        {
            dbHelper.createQuery("SELECT * FROM guests WHERE is_activated = 0;");
            return dbHelper.getResultList("id");
        }

        // Count guest registration (active/inactive)
        // Returns result as int
        public int countGuestRegistration(int is_activated)
        {
            dbHelper.createQuery("SELECT COUNT(*) FROM guests WHERE is_activated = @is_activated;");
            dbHelper.bindParam("@is_activated", is_activated);
            return dbHelper.getCount();
        }

        // Add guest
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

        // Updates guest activation (activate/deactivate)
        public void guestActivation(int guest_id, int is_activated)
        {
            dbHelper.createQuery("UPDATE guests SET is_activated = @is_activated WHERE " +
                "id = @guest_id;");
            dbHelper.bindParam("@is_activated", is_activated);
            dbHelper.bindParam("@guest_id", guest_id);

            dbHelper.executeQuery();
        }

        // Reads query
        // Returns result as string
        public string getGuestData(string item)
        {
            return dbHelper.getFromReader(item);
        }

        // Gets the last id inserted
        // Returns result as int
        public int getLastGuestID()
        {
            return dbHelper.getLastId();
        }

        // Updates guest
        public void updateGuest(int guest_id)
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
            dbHelper.bindParam("@event_id", event_id);
            dbHelper.bindParam("@id", guest_id);


            dbHelper.executeQuery();
        }

        // Deletes guest
        public void deleteGuest(int guest_id)
        {
            dbHelper.createQuery("DELETE FROM guests WHERE id = @id;");
            dbHelper.bindParam("@id", guest_id);

            dbHelper.executeQuery();
        }
    }
}
