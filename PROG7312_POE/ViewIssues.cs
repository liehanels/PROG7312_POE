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
    public partial class ViewIssues : Form
    {
        public ViewIssues(Dictionary<int, ReportedIssue> issues)
        {
            InitializeComponent();
            foreach (var issue in issues)
            {
                listView.Items.Add(issue.Value.getLocation());
                listView.Items.Add(issue.Value.getCategory());
                listView.Items.Add(issue.Value.getDescription());
                listView.Items.Add(issue.Value.getAttachedFile());
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
