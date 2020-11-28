using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Code_Secret_SOEMS.Helpers;

namespace Code_Secret_SOEMS.Models
{
    class Event
    {
        public string event_name { get; set; }
        public string venue { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public int student_registration { get; set; }
        public int student_slots { get; set; }
        public string event_details { get; set; }
        public bool allow_guests { get; set; }
        public int guest_registration { get; set; }
        public int guest_slots { get; set; }
        public bool is_activated { get; set; }

        private DatabaseHelper dbHelper;

        public Event()
        {
            dbHelper = new DatabaseHelper();
        }
        public void loadEvents(DataGridView myDataGridView)
        {
            dbHelper.createQuery(
                "SELECT " +
                    "id AS 'ID', " +
                    "IF(is_activated = 1, 'Activated', 'Deactivated') AS 'Status', " +
                    "event_name AS 'Event Name', " +
                    "date AS 'Date', " +
                    "time AS 'Time', " +
                    "student_registration AS 'Student Registration', " +
                    "IF(student_slots = 0, 'Open', student_slots) AS 'Student Slots', " +
                    "IF(allow_guests = 1, 'Yes', 'No') AS 'Allow Guests', " +
                    "guest_registration AS 'Guest Registration', " +
                    "IF(allow_guests = 1 && guest_slots = 0, 'Open', guest_slots) AS 'Guest Slots' " +
                "FROM events;");
            dbHelper.populateDataGridView(myDataGridView);
        }

        public void selectEvent(int id)
        {
            dbHelper.createQuery("SELECT * FROM events WHERE id = @id;");
            dbHelper.bindParam("@id", id);
        }
        public string getEventItems(string item)
        {
            return dbHelper.getFromReader(item);
        }

        public void addEvent()
        {
            dbHelper.createQuery("INSERT INTO events (event_name, venue, date, time, student_registration, " +
                "student_slots, event_details, allow_guests, guest_registration, guest_slots, is_activated) VALUES (@event_name, @venue, @date, " +
                "@time, @student_registration, @student_slots, @event_details, @allow_guests, @guest_registration, @guest_slots, @is_activated);");

            dbHelper.bindParam("@event_name", event_name);
            dbHelper.bindParam("@venue", venue);
            dbHelper.bindParam("@date", date);
            dbHelper.bindParam("@time", time);
            dbHelper.bindParam("@student_registration", student_registration);
            dbHelper.bindParam("@student_slots", student_slots);
            dbHelper.bindParam("@event_details", event_details);
            dbHelper.bindParam("@allow_guests", allow_guests);
            dbHelper.bindParam("@guest_registration", guest_registration);
            dbHelper.bindParam("@guest_slots", guest_slots);
            dbHelper.bindParam("@is_activated", is_activated);

            dbHelper.executeQuery();
        }

        public void updateEvent(int currentID)
        {
            dbHelper.createQuery(
                "UPDATE events SET " +
                    "event_name = @event_name, " +
                    "venue = @venue, " +
                    "date = @date, " +
                    "time = @time, " +
                    "student_registration = @student_registration, " +
                    "student_slots = @student_slots, " +
                    "event_details = @event_details, " +
                    "allow_guests = @allow_guests, " +
                    "guest_registration = @guest_registration, " +
                    "guest_slots = @guest_slots, " +
                    "is_activated = @is_activated " +
                "WHERE id = @id");

            dbHelper.bindParam("@event_name", event_name);
            dbHelper.bindParam("@venue", venue);
            dbHelper.bindParam("@date", date);
            dbHelper.bindParam("@time", time);
            dbHelper.bindParam("@student_registration", student_registration);
            dbHelper.bindParam("@student_slots", student_slots);
            dbHelper.bindParam("@event_details", event_details);
            dbHelper.bindParam("@allow_guests", allow_guests);
            dbHelper.bindParam("@guest_registration", guest_registration);
            dbHelper.bindParam("@guest_slots", guest_slots);
            dbHelper.bindParam("@is_activated", is_activated);
            dbHelper.bindParam("@id", currentID);

            dbHelper.executeQuery();
        }

        public void deleteEvent(int currentID)
        {
            dbHelper.createQuery("DELETE FROM events WHERE id = @id;");
            dbHelper.bindParam("@id", currentID);

            dbHelper.executeQuery();
        }
    }
}
