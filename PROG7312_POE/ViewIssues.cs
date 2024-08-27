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
using static System.Net.Mime.MediaTypeNames;

namespace PROG7312_POE
{
    public partial class ViewIssues : Form
    {
        //creates an empty dictionary
        Dictionary<int, ReportedIssue> _issues;
        public ViewIssues(Dictionary<int, ReportedIssue> issues)
        {
            //inital load
            InitializeComponent();
            //populates the empty dictionary with paramater value
            _issues = issues;
            //creates the list columns
            listView.View = View.Details;
            listView.Columns.Add("Image", 50, HorizontalAlignment.Center);
            listView.Columns.Add("Has Image", 100, HorizontalAlignment.Center);
            listView.Columns.Add("Location", 150, HorizontalAlignment.Center);
            listView.Columns.Add("Category", 150, HorizontalAlignment.Center);
            listView.Columns.Add("Description", 300, HorizontalAlignment.Center);
            listView.Columns.Add("Key", 50, HorizontalAlignment.Center);
            //for each value in the dictionary adds a row to list view
            foreach (var issue in issues)
            {
                ListViewItem item = new ListViewItem();
                //checks if image exists in current intiration
                if (issue.Value.getAttachedFiles() != null) { item.SubItems.Add("True"); } else { item.SubItems.Add("False"); }
                item.SubItems.Add(issue.Value.getLocation());
                item.SubItems.Add(issue.Value.getCategory());
                item.SubItems.Add(issue.Value.getDescription());
                item.SubItems.Add(issue.Key +"");
                listView.Items.Add(item);
            }
        }
        //allows user to view images if they exist
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checks if the list view exists
            if (listView == null)
            {
                MessageBox.Show("List view is not initialized.");
                return;
            }
            //checks if there are records in the listView
            if (listView.SelectedItems.Count > 0)
            {
                //gets the current selected item
                ListViewItem item = listView.SelectedItems[0];
                //checks if the correct column is selected to retrieve key
                if (item.SubItems.Count > 5 && int.TryParse(item.SubItems[5].Text, out int key))
                {
                    //finds the list item by key
                    if (_issues.ContainsKey(key))
                    {
                        //if file exists at position, gets it
                        var attachedFiles = _issues[key].getAttachedFiles();
                        if (attachedFiles != null)
                        {
                            imgList imageList = new imgList(attachedFiles);
                            imageList.StartPosition = FormStartPosition.CenterParent;
                            imageList.ShowDialog();
                        }
                        //if no image exist display to user
                        else
                        {
                            MessageBox.Show("No image attached.");
                        }
                    }
                    //if key is not found
                    else
                    {
                        MessageBox.Show("Key not found in issues.");
                    }
                }
                //if incorrect column is selected
                else
                {
                    MessageBox.Show("Invalid key in subitem.");
                }
            }
            //default action
            else
            {
                return;
            }
        }

    }
}
