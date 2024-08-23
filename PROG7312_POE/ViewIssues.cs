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
        Dictionary<int, ReportedIssue> _issues;
        public ViewIssues(Dictionary<int, ReportedIssue> issues)
        {
            InitializeComponent();
            _issues = issues;
            listView.View = View.Details;
            listView.Columns.Add("Image", 50, HorizontalAlignment.Center);
            listView.Columns.Add("Has Image", 100, HorizontalAlignment.Center);
            listView.Columns.Add("Location", 150, HorizontalAlignment.Center);
            listView.Columns.Add("Category", 150, HorizontalAlignment.Center);
            listView.Columns.Add("Description", 300, HorizontalAlignment.Center);
            listView.Columns.Add("Key", 50, HorizontalAlignment.Center);
            foreach (var issue in issues)
            {
                ListViewItem item = new ListViewItem();
                if (issue.Value.getAttachedFile() != null) { item.SubItems.Add("True"); } else { item.SubItems.Add("False"); }
                item.SubItems.Add(issue.Value.getLocation());
                item.SubItems.Add(issue.Value.getCategory());
                item.SubItems.Add(issue.Value.getDescription());
                item.SubItems.Add(issue.Key +"");
                listView.Items.Add(item);
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView == null)
            {
                MessageBox.Show("List view is not initialized.");
                return;
            }

            if (listView.SelectedItems.Count > 0)
            {
                ListViewItem item = listView.SelectedItems[0];

                if (item.SubItems.Count > 5 && int.TryParse(item.SubItems[5].Text, out int key))
                {
                    if (_issues.ContainsKey(key))
                    {
                        var attachedFile = _issues[key].getAttachedFile();
                        if (attachedFile != null)
                        {
                            ViewImage viewImage = new ViewImage(attachedFile);
                            viewImage.StartPosition = FormStartPosition.CenterParent;
                            viewImage.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("No image attached.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Key not found in issues.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid key in subitem.");
                }
            }
            else
            {
                return;
            }
        }

    }
}
