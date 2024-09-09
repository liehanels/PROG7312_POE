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
        public string getEventTime() 
        {
            string time = this.eventTime.Hour + "h" + this.eventTime.Minute;
            if (this.eventTime.Minute < 9)
            {
                time = this.eventTime.Hour + "h0" + this.eventTime.Minute;
            }
            return time;
        }
        public string getEventName() { return this.eventName; }
        public string getEventCategory() { return this.eventCategory; }
        public string getEventDescription() { return this.eventDescription; }

    }
}
