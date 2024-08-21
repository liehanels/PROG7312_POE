using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            listView.View = View.Details;
            listView.Columns.Add("", 50, HorizontalAlignment.Center);
            listView.Columns.Add("Location", 150, HorizontalAlignment.Center);
            listView.Columns.Add("Category", 150, HorizontalAlignment.Center);
            listView.Columns.Add("Description", 300, HorizontalAlignment.Center);
            listView.Columns.Add("Attached Image", 150, HorizontalAlignment.Center);
            foreach (var issue in issues)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(issue.Value.getLocation());
                item.SubItems.Add(issue.Value.getCategory());
                item.SubItems.Add(issue.Value.getDescription());
                item.SubItems.Add(issue.Value.getAttachedFile()+"");
                listView.Items.Add(item);
            }
        }
    }
}
