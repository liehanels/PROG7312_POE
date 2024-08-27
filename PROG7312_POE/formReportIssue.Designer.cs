﻿namespace PROG7312_POE
{
    partial class formReportIssue
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tblLayoutRequest = new System.Windows.Forms.TableLayoutPanel();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.cmbxCategories = new System.Windows.Forms.ComboBox();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.btnReturnToHome = new System.Windows.Forms.Button();
            this.btnSubmitForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnAddFiles = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewIssues = new System.Windows.Forms.Button();
            this.lblClickImage = new System.Windows.Forms.Label();
            this.tblLayoutRequest.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tblLayoutRequest
            // 
            this.tblLayoutRequest.AutoSize = true;
            this.tblLayoutRequest.ColumnCount = 2;
            this.tblLayoutRequest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLayoutRequest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblLayoutRequest.Controls.Add(this.lblLocation, 0, 1);
            this.tblLayoutRequest.Controls.Add(this.lblCategory, 0, 2);
            this.tblLayoutRequest.Controls.Add(this.lblDescription, 0, 3);
            this.tblLayoutRequest.Controls.Add(this.txtLocation, 1, 1);
            this.tblLayoutRequest.Controls.Add(this.cmbxCategories, 1, 2);
            this.tblLayoutRequest.Controls.Add(this.rtxtDescription, 1, 3);
            this.tblLayoutRequest.Controls.Add(this.btnReturnToHome, 1, 10);
            this.tblLayoutRequest.Controls.Add(this.btnSubmitForm, 1, 9);
            this.tblLayoutRequest.Controls.Add(this.panel1, 1, 6);
            this.tblLayoutRequest.Controls.Add(this.btnAddFiles, 1, 4);
            this.tblLayoutRequest.Controls.Add(this.progressBar, 1, 12);
            this.tblLayoutRequest.Controls.Add(this.label1, 0, 12);
            this.tblLayoutRequest.Controls.Add(this.btnViewIssues, 1, 11);
            this.tblLayoutRequest.Controls.Add(this.lblClickImage, 1, 7);
            this.tblLayoutRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayoutRequest.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tblLayoutRequest.Location = new System.Drawing.Point(0, 0);
            this.tblLayoutRequest.Name = "tblLayoutRequest";
            this.tblLayoutRequest.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tblLayoutRequest.RowCount = 14;
            this.tblLayoutRequest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutRequest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutRequest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutRequest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutRequest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutRequest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutRequest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.tblLayoutRequest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLayoutRequest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutRequest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutRequest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutRequest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutRequest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutRequest.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLayoutRequest.Size = new System.Drawing.Size(807, 831);
            this.tblLayoutRequest.TabIndex = 0;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(3, 20);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(93, 20);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "Location";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(3, 52);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(93, 34);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(3, 86);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(93, 77);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLocation
            // 
            this.txtLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(102, 23);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(702, 26);
            this.txtLocation.TabIndex = 1;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // cmbxCategories
            // 
            this.cmbxCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxCategories.FormattingEnabled = true;
            this.cmbxCategories.Items.AddRange(new object[] {
            "Water",
            "Electricity",
            "Sanitation",
            "Crime",
            "Conservation",
            "Recommendation",
            "Disputes",
            "Other Services"});
            this.cmbxCategories.Location = new System.Drawing.Point(102, 55);
            this.cmbxCategories.Name = "cmbxCategories";
            this.cmbxCategories.Size = new System.Drawing.Size(702, 28);
            this.cmbxCategories.TabIndex = 2;
            this.cmbxCategories.SelectedIndexChanged += new System.EventHandler(this.cmbxCategories_SelectedIndexChanged);
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescription.Location = new System.Drawing.Point(102, 89);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(702, 71);
            this.rtxtDescription.TabIndex = 3;
            this.rtxtDescription.Text = "";
            this.rtxtDescription.TextChanged += new System.EventHandler(this.rtxtDescription_TextChanged);
            // 
            // btnReturnToHome
            // 
            this.btnReturnToHome.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReturnToHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReturnToHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToHome.Location = new System.Drawing.Point(102, 690);
            this.btnReturnToHome.Name = "btnReturnToHome";
            this.btnReturnToHome.Size = new System.Drawing.Size(702, 46);
            this.btnReturnToHome.TabIndex = 6;
            this.btnReturnToHome.Text = "Main Menu";
            this.btnReturnToHome.UseVisualStyleBackColor = false;
            this.btnReturnToHome.Click += new System.EventHandler(this.btnReturnToHome_Click);
            // 
            // btnSubmitForm
            // 
            this.btnSubmitForm.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSubmitForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubmitForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitForm.Location = new System.Drawing.Point(102, 638);
            this.btnSubmitForm.Name = "btnSubmitForm";
            this.btnSubmitForm.Size = new System.Drawing.Size(702, 46);
            this.btnSubmitForm.TabIndex = 5;
            this.btnSubmitForm.Text = "Submit Form";
            this.btnSubmitForm.UseVisualStyleBackColor = false;
            this.btnSubmitForm.Click += new System.EventHandler(this.btnSubmitForm_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(102, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 394);
            this.panel1.TabIndex = 14;
            // 
            // picBox
            // 
            this.picBox.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox.Location = new System.Drawing.Point(0, 0);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(702, 394);
            this.picBox.TabIndex = 13;
            this.picBox.TabStop = false;
            this.picBox.Tag = "";
            this.picBox.Click += new System.EventHandler(this.picBox_Click);
            // 
            // btnAddFiles
            // 
            this.btnAddFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFiles.Location = new System.Drawing.Point(102, 166);
            this.btnAddFiles.Name = "btnAddFiles";
            this.btnAddFiles.Size = new System.Drawing.Size(702, 46);
            this.btnAddFiles.TabIndex = 4;
            this.btnAddFiles.Text = "Add Picture";
            this.btnAddFiles.UseVisualStyleBackColor = true;
            this.btnAddFiles.Click += new System.EventHandler(this.btnAddFiles_Click);
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(102, 794);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(702, 24);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 791);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = " Completion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnViewIssues
            // 
            this.btnViewIssues.BackColor = System.Drawing.SystemColors.Info;
            this.btnViewIssues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewIssues.Location = new System.Drawing.Point(102, 742);
            this.btnViewIssues.Name = "btnViewIssues";
            this.btnViewIssues.Size = new System.Drawing.Size(702, 46);
            this.btnViewIssues.TabIndex = 7;
            this.btnViewIssues.Text = "View Issues";
            this.btnViewIssues.UseVisualStyleBackColor = false;
            this.btnViewIssues.Click += new System.EventHandler(this.btnViewIssues_Click);
            // 
            // lblClickImage
            // 
            this.lblClickImage.AutoSize = true;
            this.lblClickImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblClickImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClickImage.Location = new System.Drawing.Point(102, 615);
            this.lblClickImage.Name = "lblClickImage";
            this.lblClickImage.Size = new System.Drawing.Size(702, 20);
            this.lblClickImage.TabIndex = 16;
            this.lblClickImage.Text = "Click on image above to display all images";
            this.lblClickImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formReportIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(807, 831);
            this.Controls.Add(this.tblLayoutRequest);
            this.Name = "formReportIssue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Issue";
            this.tblLayoutRequest.ResumeLayout(false);
            this.tblLayoutRequest.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutRequest;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ComboBox cmbxCategories;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Button btnAddFiles;
        private System.Windows.Forms.Button btnSubmitForm;
        private System.Windows.Forms.Button btnReturnToHome;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewIssues;
        private System.Windows.Forms.Label lblClickImage;
    }
}