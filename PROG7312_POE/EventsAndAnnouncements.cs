using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PROG7312_POE
{
    public partial class formEventsAndAnnouncements : Form
    {
        SortedDictionary<int, Event> Events = new SortedDictionary<int, Event>();
        Stack<Announcement> Announcements = new Stack<Announcement>();
        int key = 0;
        public Event SharedObject
        {
            set
            {
                Events.Add(key, value);
                //check the date values for spans that could be over a year
                int startDate = Events[key].getEventDate().DayOfYear;
                int nowDate = DateTime.Now.DayOfYear;
                int countdownDays = 0;
                if (startDate - nowDate < 0)
                {
                    countdownDays = (365 + (startDate - nowDate));
                    countdownDays = countdownDays + startDate;
                }
                else { countdownDays = startDate - nowDate; }
                Announcements.Push(new Announcement(countdownDays, Events[key]));
                key++;
            }
        }
        public formEventsAndAnnouncements()
        {
            InitializeComponent();
        }

        private void btnEventFilter_Click(object sender, EventArgs e)
        {
            //sort the dictionary by date
            //code attribute:
            //Title              : How do you sort a dictionary by value?
            //Author             : E_net4
            //Date               : 25 Feb 2022
            //Version            : 3?
            //Availability(link) : https://stackoverflow.com/questions/289/how-do-you-sort-a-dictionary-by-value?noredirect=1
            var sortedEvents = Events.OrderBy(x => x.Value.getEventDate()).ToDictionary(x => x.Key, x => x.Value);
            //gets any filter parameters
            string categoryFilter = cmbxEventCategory.Text;
            string dateFilter = eventDateTime.Value.Date.ToShortDateString();
            //creates the list view
            listVEvents.View = View.Details;
            listVEvents.Items.Clear();
            if (listVEvents.Columns.Count == 0)
            {
                listVEvents.Columns.Add("", 10);
                listVEvents.Columns.Add("Event Name", 200);
                listVEvents.Columns.Add("Event Date", 300);
                listVEvents.Columns.Add("Event Time", 200);
                listVEvents.Columns.Add("Event Category", 200);
                listVEvents.Columns.Add("Event Description", 300);
            }
            //populates the list view
            foreach (var Event in sortedEvents)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(Event.Value.getEventName());
                item.SubItems.Add(Event.Value.getEventDate().Date.ToLongDateString());
                item.SubItems.Add(Event.Value.getEventTime().TimeOfDay + "");
                item.SubItems.Add(Event.Value.getEventCategory());
                item.SubItems.Add(Event.Value.getEventDescription());
                //checks for filters before adding to the list
                if (chbxEventDateCheck.Checked && dateFilter.Equals(Event.Value.getEventDate().ToShortDateString()))
                {
                    if (categoryFilter.Equals("All Events"))
                    {
                        listVEvents.Items.Add(item);
                    }
                    else if (Event.Value.getEventCategory().Equals(categoryFilter))
                    {
                        listVEvents.Items.Add(item);
                    }
                }
                else if (!chbxEventDateCheck.Checked)
                {
                    if (categoryFilter.Equals("All Events"))
                    {
                        listVEvents.Items.Add(item);
                    }
                    else if (Event.Value.getEventCategory().Equals(categoryFilter))
                    {
                        listVEvents.Items.Add(item);
                    }
                }
            }
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            formAddEvent formAddEvent = new formAddEvent();
            formAddEvent.StartPosition = FormStartPosition.CenterParent;
            formAddEvent.ShowDialog();
        }

        private Stack<Announcement> sortStack(Stack<Announcement> input)
        {
            Stack<Announcement> sortedStack = new Stack<Announcement>();

            while (input.Count > 0)
            {
                // Pop an element from the input stack
                Announcement temp = input.Pop();

                // While the sorted stack is not empty and the top element is less than temp
                while (sortedStack.Count > 0 && sortedStack.Peek().CountdownDays < temp.CountdownDays)
                {
                    // Pop from sorted stack and push it back to the input stack
                    input.Push(sortedStack.Pop());
                }

                // Push temp into the sorted stack
                sortedStack.Push(temp);
            }

            return sortedStack;
        }


        private void btnRefreshAnnouncements_Click(object sender, EventArgs e)
        {
            var sortedAnnouncements = sortStack(Announcements);
            listVAnnouncements.View = View.Details;
            listVAnnouncements.Items.Clear();
            if (listVAnnouncements.Columns.Count == 0)
            {
                listVAnnouncements.Columns.Add("", 10);
                listVAnnouncements.Columns.Add("Countdown Days", 300);
                listVAnnouncements.Columns.Add("Event Name", 300);
            }
            foreach (var announcement in sortedAnnouncements)
            {
                ListViewItem item = new ListViewItem("");
                item.SubItems.Add(announcement.CountdownDays + " days remaining!");
                item.SubItems.Add(announcement.Event.getEventName());
                listVAnnouncements.Items.Add(item);
            }
            listVAnnouncements.Refresh();
        }

    }
}
