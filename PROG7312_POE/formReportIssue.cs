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
            picBox.Enabled = false;
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
                issue.attachUserFile(picBox.Image);
                DialogResult review = MessageBox.Show("Request submitted. Would you like to view your request?","Form Submitted",MessageBoxButtons.YesNo);
                if(review == DialogResult.No)
                {
                    txtLocation.Text = "";
                    cmbxCategories.Text = null;
                    rtxtDescription.Text = "";
                    progress = 0;
                    progressBar.Value = progress;
                    this.Close();
                }
            }
        }

        private void btnAddFiles_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Image Files|*.jpg; *.jpeg; *.png; *.dcim;";
            //https://www.bing.com/search?q=how+to+set+max+file+size+for+open+file+dialog+in+c%23&qs=n&form=QBRE&sp=-1&ghc=2&lq=0&pq=how+to+set+max+file+size+for+open+file+dialog+in+c%23&sc=10-51&sk=&cvid=3D504ECA39434898B52B30E3A67FC2CD&ghsh=0&ghacc=0&ghpl=
            long maxSizeInBytes = 2048 * 2048;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileInfo info = new FileInfo(ofd.FileName);
                    if (info.Length > maxSizeInBytes)
                    {
                        MessageBox.Show("File exceeds size limit");
                    }
                    else
                    {
                        //https://www.bing.com/search?q=how+to+use+getthumbnailImage+in+c%23&qs=n&form=QBRE&sp=-1&ghc=1&lq=0&pq=how+to+use+getthumbnailimage+in+c%23&sc=11-34&sk=&cvid=CED83DA004CE4E359DAE389EE12D47FB&ghsh=0&ghacc=0&ghpl=
                        btnAddFiles.Text = ofd.FileName;
                        Image image = new Bitmap(ofd.FileName);
                        var destImg = image.GetThumbnailImage(picBox.Width, picBox.Height, ()=> false , IntPtr.Zero);
                        picBox.Image = destImg;
                        picBox.Enabled = true;
                        if (!hasFile) { progress += 25; }
                        hasFile = true;
                        progressBar.Value = progress;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading file: {ex.Message}");
                    throw;
                }
            }
        }
        private void picBox_Click(object sender, EventArgs e)
        {
            ViewImage viewImage = new ViewImage(issue.getAttachedFile());
            viewImage.ShowDialog();
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            if (!hasLocation) 
            {
                if(txtLocation.Text.Length <= 12) { progress += 2; }
                else
                {
                    hasLocation = true;
                }
            }
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
            if (!hasDescription)
            {
                if (rtxtDescription.Text.Length <= 26) { progress++; }
                else
                {
                    hasDescription = true;
                }
            }
            progressBar.Value = progress;
        }
    }
}
