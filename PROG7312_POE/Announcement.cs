using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE
{
    public class Announcement
    {
        public int CountdownDays {  get; set; }
        public Event Event { get; set; }
        public Announcement(int countdownDays, Event e)
        {
            CountdownDays = countdownDays;
            Event = e;
        }
    }
}
