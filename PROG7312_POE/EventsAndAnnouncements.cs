﻿using System;
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
        Dictionary<int, Event> Events = new Dictionary<int, Event>();
        int key = 0;
        private Event _sharedObject;
        public Event SharedObject
        {
            get { return _sharedObject; }
            set
            {
                _sharedObject = value;
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
            listVEvents.View = View.Details;
            listVEvents.Items.Clear();
            foreach(var Event in Events)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add("");
                item.SubItems.Add(Event.Value.getEventName());
                item.SubItems.Add(Event.Value.getEventDate() + "");
                item.SubItems.Add(Event.Value.getEventTime() + "");
                item.SubItems.Add(Event.Value.getEventCategory());
                item.SubItems.Add(Event.Value.getEventDescription());
                listVEvents.Items.Add(item);
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
