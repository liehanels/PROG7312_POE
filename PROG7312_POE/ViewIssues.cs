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
            ListView listView = new ListView();
            listView.View = View.Details;
            listView.Columns.Add("Location", 200, HorizontalAlignment.Center);
            listView.Columns.Add("Category", 200, HorizontalAlignment.Center);
            listView.Columns.Add("Description", 200, HorizontalAlignment.Center);
            foreach (var issue in issues)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(issue.Value.getLocation());
                item.SubItems.Add(issue.Value.getCategory());
                item.SubItems.Add(issue.Value.getDescription());
                listView.Items.Add(item);
            }
        }
        private void listView_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
