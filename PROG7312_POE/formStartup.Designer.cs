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
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.btnEventsAndAnnouncements = new System.Windows.Forms.Button();
            this.btnServiceReqStatus = new System.Windows.Forms.Button();
            this.panelStartOptions = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panelStartOptions.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.AutoSize = true;
            this.btnReportIssues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReportIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportIssues.Location = new System.Drawing.Point(3, 215);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(322, 44);
            this.btnReportIssues.TabIndex = 0;
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.UseVisualStyleBackColor = true;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // btnEventsAndAnnouncements
            // 
            this.btnEventsAndAnnouncements.AutoSize = true;
            this.btnEventsAndAnnouncements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEventsAndAnnouncements.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventsAndAnnouncements.Location = new System.Drawing.Point(3, 265);
            this.btnEventsAndAnnouncements.Name = "btnEventsAndAnnouncements";
            this.btnEventsAndAnnouncements.Size = new System.Drawing.Size(322, 44);
            this.btnEventsAndAnnouncements.TabIndex = 1;
            this.btnEventsAndAnnouncements.Text = "Events and Announcements";
            this.btnEventsAndAnnouncements.UseVisualStyleBackColor = true;
            this.btnEventsAndAnnouncements.Click += new System.EventHandler(this.btnEventsAndAnnouncements_Click);
            // 
            // btnServiceReqStatus
            // 
            this.btnServiceReqStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnServiceReqStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceReqStatus.Location = new System.Drawing.Point(3, 315);
            this.btnServiceReqStatus.Name = "btnServiceReqStatus";
            this.btnServiceReqStatus.Size = new System.Drawing.Size(322, 44);
            this.btnServiceReqStatus.TabIndex = 2;
            this.btnServiceReqStatus.Text = "Service Request Status";
            this.btnServiceReqStatus.UseVisualStyleBackColor = true;
            this.btnServiceReqStatus.Click += new System.EventHandler(this.btnServiceReqStatus_Click);
            // 
            // panelStartOptions
            // 
            this.panelStartOptions.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelStartOptions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStartOptions.Controls.Add(this.tableLayoutPanel1);
            this.panelStartOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStartOptions.Location = new System.Drawing.Point(0, 0);
            this.panelStartOptions.Name = "panelStartOptions";
            this.panelStartOptions.Size = new System.Drawing.Size(330, 450);
            this.panelStartOptions.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnServiceReqStatus, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnEventsAndAnnouncements, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnReportIssues, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(328, 448);
            this.tableLayoutPanel1.TabIndex = 3;
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnEventsAndAnnouncements;
        private System.Windows.Forms.Button btnServiceReqStatus;
        private System.Windows.Forms.Panel panelStartOptions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

