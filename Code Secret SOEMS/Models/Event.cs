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
        public string date_from { get; set; }
        public string date_to { get; set; }
        public string time { get; set; }
        public int student_registration { get; set; }
        public int student_slots { get; set; }
        public int allow_guests { get; set; }
        public int guest_registration { get; set; }
        public int guest_slots { get; set; }
        public int is_activated { get; set; }

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
                    "event_name AS 'Event Name', " +
                    "CONCAT(date_from, ' - ', date_to) AS 'Date', " +
                    "time AS 'Time', " +
                    "student_registration AS 'Student Registration', " +
                    "IF(student_slots = 0, 'Open', student_slots) AS 'Student Slots', " +
                    "IF(allow_guests = 1, 'Yes', 'No') AS 'Allow Guests', " +
                    "guest_registration AS 'Guest Registration', " +
                    "IF(allow_guests = 1 && guest_slots = 0, 'Open', guest_slots) AS 'Guest Slots', " +
                    "IF(is_locked = 1, 'Locked', 'Open') AS 'Status'" +
                "FROM events;");
            dbHelper.populateDataGridView(myDataGridView);
        }

        public void addEvent()
        {
            dbHelper.createQuery("INSERT INTO events (event_name, venue, date_from, date_to, time, student_registration, " +
                "student_slots, allow_guests, guest_registration, guest_slots, is_activated) VALUES (@event_name, @venue, @date_from, " +
                "@date_to, @time, @student_registration, @student_slots, @allow_guests, @guest_registration, @guest_slots, @is_activated);");

            dbHelper.bindParam("@event_name", event_name);
            dbHelper.bindParam("@venue", venue);
            dbHelper.bindParam("@date_from", date_from);
            dbHelper.bindParam("@date_to", date_to);
            dbHelper.bindParam("@time", time);
            dbHelper.bindParam("@student_registration", student_registration);
            dbHelper.bindParam("@student_slots", student_slots);
            dbHelper.bindParam("@allow_guests", allow_guests);
            dbHelper.bindParam("@guest_registration", guest_registration);
            dbHelper.bindParam("@is_activated", is_activated);

            dbHelper.executeQuery();
        }

        public void updateEvent(int currentID)
        {
            dbHelper.createQuery(
                "UPDATE events SET " +
                    "event_name = @event_name, " +
                    "venue = @venue, " +
                    "date_from = @date_from, " +
                    "date_to = @date_to, " +
                    "time = @time, " +
                    "student_registration = @student_registration, " +
                    "student_slots = @student_slots, " +
                    "allow_guests = @allow_guests, " +
                    "guest_registration = @guest_registration, " +
                    "guest_slots = @guest_slots " +
                "WHERE id = @id");

            dbHelper.bindParam("@event_name", event_name);
            dbHelper.bindParam("@venue", venue);
            dbHelper.bindParam("@date_from", date_from);
            dbHelper.bindParam("@date_to", date_to);
            dbHelper.bindParam("@time", time);
            dbHelper.bindParam("@student_registration", student_registration);
            dbHelper.bindParam("@student_slots", student_slots);
            dbHelper.bindParam("@allow_guests", allow_guests);
            dbHelper.bindParam("@guest_registration", guest_registration);
            dbHelper.bindParam("@is_activated", is_activated);
            dbHelper.bindParam("@iid", currentID);

            dbHelper.executeQuery();
        }

        public void deleteEvent(int currentID)
        {
            dbHelper.createQuery("DELETE FROM officers WHERE id = @id;");
            dbHelper.bindParam("@id", currentID);

            dbHelper.executeQuery();
        }
    }
}
