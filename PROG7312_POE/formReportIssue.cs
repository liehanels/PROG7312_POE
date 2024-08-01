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
    public partial class formReportIssue : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        ReportedIssue issue = new ReportedIssue();
        int progress = 0;
        bool hasLocation, hasCategory, hasDescription, hasFile = false;
        public formReportIssue()
        {
            InitializeComponent();
        }

        private void btnReturnToHome_Click(object sender, EventArgs e)
        {
            DialogResult quit = MessageBox.Show("Are you sure you want to return to main menu? Any unsaved changes will be lost.","Return to main menu?", MessageBoxButtons.YesNo);
            if(quit == DialogResult.Yes) { this.Close(); }
        }

        private void btnSubmitForm_Click(object sender, EventArgs e)
        {
            bool canSubmit = true;
            if (txtLocation.Text.Equals(null) || txtLocation.Text.Length < 10)
            {
                MessageBox.Show("Insufficient information supplied for LOCATION");
                canSubmit = false;
            }
            if (cmbxCategories.Text.Length < 1)
            {
                MessageBox.Show("Please select a CATEGORY");
                canSubmit = false;
            }
            if (rtxtDescription.Text.Equals(null) || rtxtDescription.Text.Length < 20)
            {
                MessageBox.Show("Please supply enough information in the DESCRIPTION field");
                canSubmit = false;
            }
            if (canSubmit)
            {
                issue.setLocation(txtLocation.Text);
                issue.setCategory(cmbxCategories.Text);
                issue.setDescription(rtxtDescription.Text);
                DialogResult review = MessageBox.Show("Request submitted. Would you like to view your request?","Form Submitted",MessageBoxButtons.YesNo);
                if(review == DialogResult.No)
                {
                    txtLocation.Text = "";
                    cmbxCategories.Text = null;
                    rtxtDescription.Text = "";
                    progress = 0;
                    progressBar.Value = progress;
                }
            }
        }

        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(ofd.FileName);
                    btnAddFiles.Text = ofd.FileName;
                    issue.attachUserFile(ofd.FileName);
                    if (!hasFile) { progress += 25; }
                    hasFile = true;
                    progressBar.Value = progress;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading file: {ex.Message}");
                    throw;
                }
            }
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            if (!hasLocation) { progress += 25; }
            hasLocation = true;
            progressBar.Value = progress;
        }

        private void cmbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!hasCategory) { progress += 25; }
            hasCategory = true;
            progressBar.Value = progress;
        }

        private void rtxtDescription_TextChanged(object sender, EventArgs e)
        {
            if (!hasDescription) { progress += 25; }
            hasDescription = true;
            progressBar.Value = progress;
        }
    }
}
