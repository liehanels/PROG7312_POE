﻿using System;
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
            issue.setLocation(txtLocation.Text);
            issue.setCategory(cmbxCategories.Text);
            issue.setDescription(rtxtDescription.Text);
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading file: {ex.Message}");
                    throw;
                }
            }
        }
    }
}
