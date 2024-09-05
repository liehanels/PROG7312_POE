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
        int key = 0;
        public Event SharedObject
        {
            set
            {
                Events.Add(key, value);
                key++;
            }
        }
        public formEventsAndAnnouncements()
        {
            InitializeComponent();
        }

        private void btnEventFilter_Click(object sender, EventArgs e)
        {
            string categoryFilter = cmbxEventCategory.Text;
            string dateFilter = eventDateTime.Value.Date.ToShortDateString();
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
            foreach (var Event in Events)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(Event.Value.getEventName());
                item.SubItems.Add(Event.Value.getEventDate().Date.ToLongDateString());
                item.SubItems.Add(Event.Value.getEventTime().TimeOfDay + "");
                item.SubItems.Add(Event.Value.getEventCategory());
                item.SubItems.Add(Event.Value.getEventDescription());
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
    }
}
