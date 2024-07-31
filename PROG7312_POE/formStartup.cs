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
        public formMain()
        {
            InitializeComponent();
        }

        private void btnEventsAndAnnouncements_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature coming soon!");
        }

        private void btnServiceReqStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature coming soon!");
        }

        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            formReportIssue formReportIssue = new formReportIssue();
            formReportIssue.ShowDialog();
        }
    }
}
