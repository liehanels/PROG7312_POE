using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_POE
{
    public partial class formMain : Form
    {
        //initial program load
        public formMain()
        {
            InitializeComponent();
            //sets the position of the form to the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        //opens the events and announcements dialogue
        private void btnEventsAndAnnouncements_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature coming soon!");
        }
        //opens the service request status dialogue
        private void btnServiceReqStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature coming soon!");
        }
        //opens the report issues dialogue
        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            formReportIssue formReportIssue = new formReportIssue();
            //sets the position of the form to the center of the parent
            formReportIssue.StartPosition = FormStartPosition.CenterParent;
            formReportIssue.ShowDialog();
        }
    }
}
