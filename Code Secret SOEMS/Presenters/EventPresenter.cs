using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Code_Secret_SOEMS.Models;

namespace Code_Secret_SOEMS.Presenters
{
    class EventPresenter
    {
        Event _event = new Event();

        public void loadEvents(DataGridView mydataGridView)
        {
            _event.loadEvents(mydataGridView);
        }

        public void setEvent(string event_name, string venue, string date_from, string date_to, string time,
            int student_registration, int student_slots, byte allow_guests, int guest_registration, int guest_slots, byte is_activated)
        {
            _event.event_name = event_name;
            _event.venue = venue;
            _event.date_from = date_from;
            _event.date_to = date_to;
            _event.time = time;
            _event.student_registration = student_registration;
            _event.student_slots = student_slots;
            _event.allow_guests = allow_guests;
            _event.guest_registration = guest_registration;
            _event.guest_registration = guest_slots;
            _event.is_activated = is_activated;
        }

        public void addEvent()
        {
            _event.addEvent();
        }
    }

}
