using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE
{
    public class Event
    {
        //variables
        private DateTime eventDate;
        private DateTime eventTime;
        private string eventName;
        private string eventCategory;
        private string eventDescription;
        //initializer
        public Event() { }
        public Event(DateTime date, DateTime time, string name, string category, string description)
        {
            this.eventDate = date;
            this.eventTime = time;
            this.eventName = name;
            this.eventCategory = category;
            this.eventDescription = description;
        }
        //getters
        public DateTime getEventDate() { return this.eventDate.Date; }
        public DateTime getEventTime() { return this.eventTime; }
        public string getEventName() { return this.eventName; }
        public string getEventCategory() { return this.eventCategory; }
        public string getEventDescription() { return this.eventDescription; }

    }
}
