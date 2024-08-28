using Microsoft.VisualBasic;
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
        //code attribute:
        //Title              : 
        //Author             : 
        //Date               : 
        //Version            : 
        //Availability(link) : 
        Dictionary<int,ReportedIssue> issues = new Dictionary<int,ReportedIssue>();
        List<Image> images = new List<Image>();
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
                MessageBox.Show("Insufficient information supplied for LOCATION","Location");
                canSubmit = false;
            }
            if (cmbxCategories.Text.Length < 1)
            {
                MessageBox.Show("Please select a CATEGORY","Category");
                canSubmit = false;
            }
            if (rtxtDescription.Text.Equals(null) || rtxtDescription.Text.Length < 20)
            {
                MessageBox.Show("Please supply enough information in the DESCRIPTION field","Description");
                canSubmit = false;
            }
            if (picBox.Image == null)
            {
                var result = MessageBox.Show("No IMAGE added. Are you sure you want to continue?","Image",MessageBoxButtons.YesNo);
                if(result == DialogResult.No) { canSubmit = false; }
            }
            //if canSubmit remains true will submit the information to the dictionary
            if (canSubmit)
            {
                //creates new issue instance of ReportedIssue
                ReportedIssue issue = new ReportedIssue();
                //adds information to new instance
                issue.setLocation(txtLocation.Text);
                issue.setCategory(cmbxCategories.Text);
                issue.setDescription(rtxtDescription.Text);
                //adds all the images
                foreach(Image img in images)
                {
                    issue.attachUserFile(img);
                }
                //adds the instance to the dictionary
                issues.Add(amountIssues, issue);
                
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
                //code attribute:
                //Title              : ImageList Class
                //Author             : Microsoft Learn
                //Date               : 27 Aug 2024
                //Version            : 4.8.1
                //Availability(link) : https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.imagelist?view=windowsdesktop-8.0

                //code attribute:
                //Title              : OpenFileDialog.Multiselect Property
                //Author             : Microsoft Learn
                //Date               : 27 Aug 2024
                //Version            : 4.8.1
                //Availability(link) : https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.openfiledialog.multiselect?view=windowsdesktop-8.0

                //sets the explorer filter
                ofd.Filter = "Image Files|*.jpg; *.jpeg; *.png; *.dcim;";
                ofd.Multiselect = true;
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
                            MessageBox.Show("Files exceeds size limit");
                        }
                        else
                        //creates a new image based on filename
                        {
                            foreach (var file in ofd.FileNames)
                            {
                                images.Add(new Bitmap(file));
                            }
                            //Sets the first image to the picture box
                            var destImg = images[0].GetThumbnailImage(picBox.Width, picBox.Height, () => false, IntPtr.Zero);
                            picBox.Image = destImg;
                            //enables the picture box to be clicked
                            picBox.Enabled = true;
                            //changes button text to remove image
                            btnAddFiles.Text = "Remove Pictures";
                            lblClickImage.Visible = true;
                        }
                    }
                    //ifi file cant be read
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error reading files: {ex.Message}");
                    }
                }
            }
            //if there is an image loaded, removes it and resets the button
            else
            {
                picBox.Image = null;
                images.Clear();
                picBox.Enabled = false;
                btnAddFiles.Text = "Add Pictures";
                lblClickImage.Visible = false;
            }
        }
        //enlarge/view picture
        private void picBox_Click(object sender, EventArgs e)
        {
            imgList imageList = new imgList(images);
            imageList.StartPosition = FormStartPosition.CenterParent;
            imageList.ShowDialog();
        }
        //checks text length and adjusts the loading bar
        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            if (txtLocation.Text.Length <= 10) { progress = txtLocation.Text.Length * 10; }
            progressBar.Value = progress;
            //updates the label to reflect chars
            lblLocationChars.Text = $"{10-(progress/10)} Chars";
        }
        //checks text length and adjusts the loading bar
        private void rtxtDescription_TextChanged(object sender, EventArgs e)
        {
            if (rtxtDescription.Text.Length <= 20) { progress = rtxtDescription.Text.Length * 5; }
            progressBar.Value = progress;
            //updates the label to reflect chars
            lblDescriptionChars.Text = $"{20 - (progress / 5)} Chars";
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
            images.Clear();
            btnAddFiles.Text = "Add Pictures";
            lblClickImage.Visible = false;
        }

        private void cmbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

            //adds a new category
            if(cmbxCategories.Text.Equals("Other Services"))
            {
                //prompts user for category
                string category = Interaction.InputBox("What CATEGORY are you submitting?");
                //checks if a valid input is received
                if (category.Length > 0)
                {
                    //adds the category
                    cmbxCategories.Items.Add(category);
                    cmbxCategories.SelectedItem = category;
                }
                else
                {
                    //error message if no category is entered
                    MessageBox.Show("Please enter a valid CATEGORY", "Category");
                }
            }
        }
    }
}
