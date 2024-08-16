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
        Dictionary<int,ReportedIssue> issues = new Dictionary<int,ReportedIssue>();
        int amountIssues = 0;
        int progress = 0;
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
                ReportedIssue issue = new ReportedIssue();
                issue.setLocation(txtLocation.Text);
                issue.setCategory(cmbxCategories.Text);
                issue.setDescription(rtxtDescription.Text);
                issue.attachUserFile(picBox.Image);
                issues.Add(amountIssues, issue);
                amountIssues++;
                DialogResult review = MessageBox.Show("Request submitted. Would you like to view your request?","Form Submitted",MessageBoxButtons.YesNo);
                if(review == DialogResult.No)
                {
                    txtLocation.Text = "";
                    cmbxCategories.Text = null;
                    rtxtDescription.Text = "";
                    progress = 0;
                    progressBar.Value = progress;
                    picBox.Image = null;
                }
                if(review == DialogResult.Yes)
                {
                    ViewIssues viewIssues = new ViewIssues(issues);
                    viewIssues.ShowDialog();
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
                        Image image = new Bitmap(ofd.FileName);
                        var destImg = image.GetThumbnailImage(picBox.Width, picBox.Height, ()=> false , IntPtr.Zero);
                        picBox.Image = destImg;
                        picBox.Enabled = true;
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
            ViewImage viewImage = new ViewImage(picBox.Image);
            viewImage.ShowDialog();
        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            if (txtLocation.Text.Length <= 10) { progress = txtLocation.Text.Length * 10; }
            progressBar.Value = progress;
        }
        private void rtxtDescription_TextChanged(object sender, EventArgs e)
        {
            if (rtxtDescription.Text.Length <= 20) { progress = rtxtDescription.Text.Length * 5; }
            progressBar.Value = progress;
        }

        private void btnViewIssues_Click(object sender, EventArgs e)
        {
            ViewIssues viewIssues = new ViewIssues(issues);
            viewIssues.ShowDialog();
        }
    }
}
