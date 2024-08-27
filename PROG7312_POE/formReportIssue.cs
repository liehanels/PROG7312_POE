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
        //declare global vars
        OpenFileDialog ofd = new OpenFileDialog();
        Dictionary<int,ReportedIssue> issues = new Dictionary<int,ReportedIssue>();
        DbHandler dbHandler = new DbHandler();
        int amountIssues = 0;
        int progress = 0;
        //inital load of form
        public formReportIssue()
        {
            InitializeComponent();
            picBox.Enabled = false;
        }
        //close the form and return to home screen
        private void btnReturnToHome_Click(object sender, EventArgs e)
        {
            DialogResult quit = MessageBox.Show("Are you sure you want to return to main menu? Any unsaved changes will be lost.","Return to main menu?", MessageBoxButtons.YesNo);
            if(quit == DialogResult.Yes) { this.Close(); }
        }
        //submit form click
        private void btnSubmitForm_Click(object sender, EventArgs e)
        {
            //assumes form is correct and validates information
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
            //if canSubmit remains true will submit the information to the dictionary
            if (canSubmit)
            {
                //creates new issue instance
                ReportedIssue issue = new ReportedIssue();
                //adds information to new instance
                issue.setLocation(txtLocation.Text);
                issue.setCategory(cmbxCategories.Text);
                issue.setDescription(rtxtDescription.Text);
                issue.attachUserFile(picBox.Image);
                //adds the instance to the dictionary
                issues.Add(amountIssues, issue);
                
                //adds the instance to db
                //dbHandler.InsertIntoDb(issue);

                //increments the amount of issues var
                amountIssues++;
                //asks user to if they want to view their request
                DialogResult review = MessageBox.Show("Request submitted. Would you like to view your request?","Form Submitted",MessageBoxButtons.YesNo);
                //if no reset form
                if(review == DialogResult.No)
                {
                    resetForm();
                }
                //if yes reset form and open listIssues dialogue
                if(review == DialogResult.Yes)
                {
                    resetForm();
                    ViewIssues viewIssues = new ViewIssues(issues);
                    viewIssues.StartPosition = FormStartPosition.CenterParent;
                    viewIssues.ShowDialog();
                }
            }
        }
        //add files to request
        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            //if there is no image selected
            if(picBox.Image == null)
            {
                //sets the explrer filter
                ofd.Filter = "Image Files|*.jpg; *.jpeg; *.png; *.dcim;";
                //sets the max size of an image
                long maxSizeInBytes = 2048 * 2048;
                //once the user selected an image and presses okay
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //tries to read the file
                    try
                    {
                        FileInfo info = new FileInfo(ofd.FileName);
                        //check file size
                        if (info.Length > maxSizeInBytes)
                        {
                            MessageBox.Show("File exceeds size limit");
                        }
                        else
                        //creates a new image based on filename
                        {
                            Image image = new Bitmap(ofd.FileName);
                            //Not using because it distorts the image
                            //var destImg = image.GetThumbnailImage(picBox.Width, picBox.Height, () => false, IntPtr.Zero);
                            picBox.Image = image;
                            //enables the picture box to be clicked
                            picBox.Enabled = true;
                            //changes button text to remove image
                            btnAddFiles.Text = "Remove Picture";
                        }
                    }
                    //ifi file cant be read
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error reading file: {ex.Message}");
                    }
                }
            }
            //if there is an image loaded, removes it and resets the button
            else
            {
                picBox.Image = null;
                picBox.Enabled = false;
                btnAddFiles.Text = "Add Picture";
            }
        }
        //enlarge/view picture
        private void picBox_Click(object sender, EventArgs e)
        {
            //opens the picture in a larger view
            ViewImage viewImage = new ViewImage(picBox.Image);
            //centres picture box on parent
            viewImage.StartPosition = FormStartPosition.CenterParent;
            viewImage.Size = picBox.Image.Size;
            viewImage.ShowDialog();
        }
        //checks text length and adjusts the loading bar
        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            if (txtLocation.Text.Length <= 10) { progress = txtLocation.Text.Length * 10; }
            progressBar.Value = progress;
        }
        //checks text length and adjusts the loading bar
        private void rtxtDescription_TextChanged(object sender, EventArgs e)
        {
            if (rtxtDescription.Text.Length <= 20) { progress = rtxtDescription.Text.Length * 5; }
            progressBar.Value = progress;
        }
        //viewIssues click opens the listview to view issues
        private void btnViewIssues_Click(object sender, EventArgs e)
        {
            ViewIssues viewIssues = new ViewIssues(issues);
            viewIssues.ShowDialog();
        }
        //method to reset the form to it's native state
        private void resetForm()
        {
            txtLocation.Text = "";
            cmbxCategories.Text = null;
            rtxtDescription.Text = "";
            progress = 0;
            progressBar.Value = progress;
            picBox.Enabled = false;
            picBox.Image = null;
            btnAddFiles.Text = "Add Picture";
        }
    }
}
