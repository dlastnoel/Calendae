using System.Collections.Generic;
using System.Windows.Forms;
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
        public string event_details { get; set; }
        public bool allow_guests { get; set; }
        public int guest_registration { get; set; }
        public int guest_slots { get; set; }
        public bool is_activated { get; set; }

        private DatabaseHelper dbHelper;

        // Constructor
        public Event()
        {
            dbHelper = new DatabaseHelper();
        }

        // Load event data on DataGridView
        public void loadEvents(DataGridView myDataGridView)
        {
            dbHelper.createQuery(
                "SELECT " +
                    "id AS 'ID', " +
                    "IF(is_activated = 1, 'Activated', 'Deactivated') AS 'Status', " +
                    "event_name AS 'Event Name', " +
                    "venue AS 'Venue', " +
                    "CONCAT(date_from, ' ', date_to)  AS 'Date', " +
                    "time AS 'Time', " +
                    "student_registration AS 'Student Registration', " +
                    "IF(student_slots = 0, 'Open', student_slots) AS 'Student Slots', " +
                    "IF(allow_guests = 1, 'Yes', 'No') AS 'Allow Guests', " +
                    "guest_registration AS 'Guest Registration', " +
                    "IF(allow_guests = 1 && guest_slots = 0, 'Open', guest_slots) AS 'Guest Slots' " +
                "FROM events;");
            dbHelper.populateDataGridView(myDataGridView);
        }

        // Search and load event data on DataGridView
        public void searchEvents(string event_name, DataGridView myDataGridView)
        {
            dbHelper.createQuery(
                "SELECT " +
                    "id AS 'ID', " +
                    "IF(is_activated = 1, 'Activated', 'Deactivated') AS 'Status', " +
                    "event_name AS 'Event Name', " +
                    "venue AS 'Venue', " +
                    "CONCAT(date_from, ' ', date_to)  AS 'Date', " +
                    "time AS 'Time', " +
                    "student_registration AS 'Student Registration', " +
                    "IF(student_slots = 0, 'Open', student_slots) AS 'Student Slots', " +
                    "IF(allow_guests = 1, 'Yes', 'No') AS 'Allow Guests', " +
                    "guest_registration AS 'Guest Registration', " +
                    "IF(allow_guests = 1 && guest_slots = 0, 'Open', guest_slots) AS 'Guest Slots' " +
                "FROM events " +
                "WHERE event_name LIKE CONCAT('%',@event_name,'%');");
            dbHelper.bindParam("@event_name", event_name);
            dbHelper.populateDataGridView(myDataGridView);
        }

        // Selects event by id
        public void selectEvent(int event_id)
        {
            dbHelper.createQuery("SELECT * FROM events WHERE id = @id;");
            dbHelper.bindParam("@id", event_id);
        }

        //Selects event by name
        public void selectEventByName(string event_name)
        {
            dbHelper.createQuery("SELECT * FROM events WHERE event_name = @event_name");
            dbHelper.bindParam("@event_name", event_name);
        }

        // Counts events (active/inactive)
        public int countEvents(int is_activated)
        {
            dbHelper.createQuery("SELECT COUNT(*) FROM events WHERE is_activated = @is_activated");
            dbHelper.bindParam("@is_activated", is_activated);
            return dbHelper.getCount();
        }

        // Gets all active events
        // Returns result as string List (event_name)
        public List<string> getAllActiveEvents()
        {
            dbHelper.createQuery("SELECT * FROM events WHERE is_activated = 1");
            return dbHelper.getResultList("event_name");
        }

        // Gets all active events which allows guests
        // Returns resut as string List (event_name)
        public List<string> getAllGuestAllowedActiveEvents()
        {
            dbHelper.createQuery("SELECT * FROM events WHERE allow_guests = @allow_guests AND is_activated = @is_activated");
            dbHelper.bindParam("@allow_guests", 1);
            dbHelper.bindParam("@is_activated", 1);
            return dbHelper.getResultList("event_name");
        }

        // Get all inactive events
        // Returns result as string List (event_id)
        public List<string> getInactiveEventIds()
        {
            dbHelper.createQuery("SELECT * FROM events WHERE is_activated = 0;");
            return dbHelper.getResultList("id");
        }

        // Reads query
        // Returns result as string
        public string getEventData(string item)
        {
            return dbHelper.getFromReader(item);
        }


        // Add event
        public void addEvent()
        {
            dbHelper.createQuery("INSERT INTO events (event_name, venue, date_from, date_to, time, student_registration, " +
                "student_slots, event_details, allow_guests, guest_registration, guest_slots, is_activated) VALUES " +
                "(@event_name, @venue, @date_from, @date_to, @time, @student_registration, " +
                "@student_slots, @event_details, @allow_guests, @guest_registration, @guest_slots, @is_activated);");

            dbHelper.bindParam("@event_name", event_name);
            dbHelper.bindParam("@venue", venue);
            dbHelper.bindParam("@date_from", date_from);
            dbHelper.bindParam("@date_to", date_to);
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

        //Update event
        public void updateEvent(int event_id)
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
                    "event_details = @event_details, " +
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
            dbHelper.bindParam("@event_details", event_details);
            dbHelper.bindParam("@allow_guests", allow_guests);
            dbHelper.bindParam("@guest_registration", guest_registration);
            dbHelper.bindParam("@guest_slots", guest_slots);
            dbHelper.bindParam("@is_activated", is_activated);
            dbHelper.bindParam("@id", event_id);

            dbHelper.executeQuery();
        }

        // Updates event activation (activate/deactivate)
        public void eventActivation(int event_id, int is_activated)
        {
            dbHelper.createQuery("UPDATE events SET is_activated = @is_activated WHERE " +
                "id = @event_id");
            dbHelper.bindParam("@is_activated", is_activated);
            dbHelper.bindParam("@event_id", event_id);

            dbHelper.executeQuery();
        }

        // Deletes event
        public void deleteEvent(int event_id)
        {
            dbHelper.createQuery("DELETE FROM events WHERE id = @id;");
            dbHelper.bindParam("@id", event_id);

            dbHelper.executeQuery();
        }
    }
}
