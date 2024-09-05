using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PROG7312_POE
{
    public partial class formAddEvent : Form
    {
        public formAddEvent()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            var response = MessageBox.Show("Return to previous menu?", "Confirm Return", MessageBoxButtons.YesNo);
            if (response == DialogResult.Yes) { this.Close(); }
        }

        private void btnSaveEvent_Click(object sender, EventArgs e)
        {
            string eventName = txtEventName.Text;
            DateTime eventDate = dpEventDate.Value;
            DateTime eventTime = dpEventTime.Value;
            string eventCategory = cmbxEventCategory.Text;
            string eventDescription = txtEventDescription.Text;
            Event newEvent = new Event(eventDate, eventTime, eventName, eventCategory, eventDescription);
            var parentForm = Application.OpenForms.OfType<formEventsAndAnnouncements>().FirstOrDefault();
            if (parentForm != null)
            {
                parentForm.SharedObject = newEvent;
                MessageBox.Show("Event added!");
                txtEventName.Text = "";
                txtEventDescription.Text = "";
                cmbxEventCategory.Text = "";
            }
        }
    }
}
