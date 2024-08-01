namespace PROG7312_POE
{
    partial class formMain
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
            this.panelStartOptions = new System.Windows.Forms.Panel();
            this.btnServiceReqStatus = new System.Windows.Forms.Button();
            this.btnEventsAndAnnouncements = new System.Windows.Forms.Button();
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.panelStartOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStartOptions
            // 
            this.panelStartOptions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelStartOptions.Controls.Add(this.btnServiceReqStatus);
            this.panelStartOptions.Controls.Add(this.btnEventsAndAnnouncements);
            this.panelStartOptions.Controls.Add(this.btnReportIssues);
            this.panelStartOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStartOptions.Location = new System.Drawing.Point(0, 0);
            this.panelStartOptions.Name = "panelStartOptions";
            this.panelStartOptions.Size = new System.Drawing.Size(330, 450);
            this.panelStartOptions.TabIndex = 0;
            // 
            // btnServiceReqStatus
            // 
            this.btnServiceReqStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceReqStatus.Location = new System.Drawing.Point(3, 297);
            this.btnServiceReqStatus.Name = "btnServiceReqStatus";
            this.btnServiceReqStatus.Size = new System.Drawing.Size(324, 50);
            this.btnServiceReqStatus.TabIndex = 2;
            this.btnServiceReqStatus.Text = "Service Request Status";
            this.btnServiceReqStatus.UseVisualStyleBackColor = true;
            this.btnServiceReqStatus.Click += new System.EventHandler(this.btnServiceReqStatus_Click);
            // 
            // btnEventsAndAnnouncements
            // 
            this.btnEventsAndAnnouncements.AutoSize = true;
            this.btnEventsAndAnnouncements.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventsAndAnnouncements.Location = new System.Drawing.Point(3, 241);
            this.btnEventsAndAnnouncements.Name = "btnEventsAndAnnouncements";
            this.btnEventsAndAnnouncements.Size = new System.Drawing.Size(324, 50);
            this.btnEventsAndAnnouncements.TabIndex = 1;
            this.btnEventsAndAnnouncements.Text = "Events and Announcements";
            this.btnEventsAndAnnouncements.UseVisualStyleBackColor = true;
            this.btnEventsAndAnnouncements.Click += new System.EventHandler(this.btnEventsAndAnnouncements_Click);
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.AutoSize = true;
            this.btnReportIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportIssues.Location = new System.Drawing.Point(3, 185);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(324, 50);
            this.btnReportIssues.TabIndex = 0;
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.UseVisualStyleBackColor = true;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 450);
            this.Controls.Add(this.panelStartOptions);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PROG7312 POE";
            this.panelStartOptions.ResumeLayout(false);
            this.panelStartOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStartOptions;
        private System.Windows.Forms.Button btnServiceReqStatus;
        private System.Windows.Forms.Button btnEventsAndAnnouncements;
        private System.Windows.Forms.Button btnReportIssues;
    }
}

