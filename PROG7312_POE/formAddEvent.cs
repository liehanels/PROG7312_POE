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
            //code attribute:
            //Title              : How to handle null values in C#
            //Author             : Joydip Kanjilal
            //Date               : Jul 20 2023
            //Version            : 1
            //Availability(link) : https://www.infoworld.com/article/2338796/how-to-handle-null-values-in-c-sharp.html

            //gets the form data and checks for null values
            string eventName = txtEventName?.Text ?? string.Empty;
            DateTime eventDate = dpEventDate?.Value ?? DateTime.Now;
            DateTime eventTime = dpEventTime?.Value ?? DateTime.Now;
            string eventCategory = cmbxEventCategory?.Text ?? string.Empty;
            string eventDescription = txtEventDescription?.Text ?? string.Empty;
            //displays an error and returns if there's null values
            if (string.IsNullOrEmpty(eventName) || eventDate == DateTime.MinValue || eventTime == DateTime.MinValue ||
                string.IsNullOrEmpty(eventCategory) || string.IsNullOrEmpty(eventDescription))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }
            if (eventDate.CompareTo(DateTime.Now) < 0)
            {
                MessageBox.Show("Event cannot be today or in the past.");
            }
            else if (eventDate.CompareTo(DateTime.Now) > 1 && eventTime.CompareTo(DateTime.Now) < 0)
            {
                MessageBox.Show("Please fill in a valid time.");
            }
            else
            {
                //creates a new event instance
                Event newEvent = new Event(eventDate, eventTime, eventName, eventCategory, eventDescription);
                //creates a parent form interaction variable
                var parentForm = Application.OpenForms.OfType<formEventsAndAnnouncements>().FirstOrDefault();
                //if the parent exists, sends the data through and informs the user
                if (parentForm != null)
                {
                    parentForm.SharedObject = newEvent;
                    MessageBox.Show("Event added!");
                    //resets the form for more data entry
                    txtEventName.Text = "";
                    txtEventDescription.Text = "";
                    cmbxEventCategory.Text = "";
                }
            }
        }
    }
}
