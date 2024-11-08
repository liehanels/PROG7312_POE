﻿using Microsoft.VisualBasic;
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
    //code attribute:
    //Title              : 
    //Author             : 
    //Date               : 
    //Version            : 
    //Availability(link) : 
    public partial class formReportIssue : Form
    {
        //declare global vars
        OpenFileDialog ofd = new OpenFileDialog();
        Dictionary<int,ReportedIssue> issues = new Dictionary<int,ReportedIssue>();
        List<Image> images = new List<Image>();
        int amountIssues = 0;
        int lProgress, cProgress, iProgress = 0;
        double dProgress = 0;
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
                            //calls a function to set the image to the first one
                            Image destImg = setImg(0);
                            picBox.Image = destImg;
                            //enables the picture box to be clicked
                            picBox.Enabled = true;
                            //changes button text to remove image
                            btnAddFiles.Text = "Remove Pictures";
                            lblClickImage.Visible = true;
                            iProgress = 5;
                            progressBar.Value = (int)dProgress + lProgress + cProgress + iProgress;
                        }
                    }
                    //ifi file cant be read
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error reading files: {ex.Message}");
                    }
                }
            }
            //if there is an image loaded, asks user whether to remove it and resets the button
            else
            {
                var result = MessageBox.Show("Are you sure you want to remove all the selected images?","Remove Images",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    picBox.Image = null;
                    images.Clear();
                    picBox.Enabled = false;
                    btnAddFiles.Text = "Add Pictures";
                    lblClickImage.Visible = false;
                }
            }
        }
        //enlarge/view picture
        int c = 0;
        private void picBox_Click(object sender, EventArgs e)
        {
            //cycles through the images
            if(c == images.Count - 1) { c = 0 ; }
            else { c++; }
            picBox.Image = setImg(c);
        }
        //checks text length and adjusts the loading bar
        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            if (txtLocation.Text.Length <= 10) { lProgress = txtLocation.Text.Length * 5; }
            progressBar.Value = (int)dProgress + lProgress + cProgress + iProgress;
            //updates the label to reflect chars
            lblLocationChars.Text = $"{10-(lProgress/5)} characters";
        }
        //checks text length and adjusts the loading bar
        private void rtxtDescription_TextChanged(object sender, EventArgs e)
        {
            if (rtxtDescription.Text.Length <= 20) { dProgress = rtxtDescription.Text.Length * 2; }
            progressBar.Value = (int)dProgress + lProgress + cProgress + iProgress;
            //updates the label to reflect chars
            lblDescriptionChars.Text = $"{20 - (dProgress / 2)} characters";
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
            lProgress = 0;
            dProgress = 0;
            progressBar.Value = 0;
            picBox.Enabled = false;
            picBox.Image = null;
            images.Clear();
            btnAddFiles.Text = "Add Pictures";
            lblClickImage.Visible = false;
        }
        private int imgType(Image image)
        {
            int width = image.Width;
            int height = image.Height;
            if (width > height)
            {
                return 1;
            }
            else if (height > width)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }
        private Image setImg(int i)
        {
            Image destImg;
            //checks if 1st img is landscape or portrait
            if (imgType(images[i]) == 3)
            {
                //Sets the first image to the picture box and halfs the width of it to fit
                destImg = images[i].GetThumbnailImage(picBox.Width / 2, picBox.Height, () => false, IntPtr.Zero);
            }
            else if (imgType(images[i]) == 2)
            {
                //Sets the first image to the picture box and halfs the width of it to fit
                destImg = images[i].GetThumbnailImage(picBox.Width / 3, picBox.Height, () => false, IntPtr.Zero);
            }
            else
            {
                //Sets the first image to the picture box
                destImg = images[i].GetThumbnailImage(picBox.Width - 100, picBox.Height, () => false, IntPtr.Zero);
            }
            return destImg;
        }

        private void cmbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            cProgress = 5;
            progressBar.Value = (int)dProgress + lProgress + cProgress + iProgress;
            //adds a new category
            if (cmbxCategories.Text.Equals("Other Services"))
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
