namespace PROG7312_POE
{
    partial class formEventsAndAnnouncements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEventsAndAnnouncements));
            this.EventsAndAnnoucementsTab = new System.Windows.Forms.TabControl();
            this.eventTab = new System.Windows.Forms.TabPage();
            this.announcementsTab = new System.Windows.Forms.TabPage();
            this.listVEvents = new System.Windows.Forms.ListView();
            this.eventDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.eventDateTime = new System.Windows.Forms.DateTimePicker();
            this.cmbxEventCategory = new System.Windows.Forms.ComboBox();
            this.btnEventFilter = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.lblEventDateCheck = new System.Windows.Forms.CheckBox();
            this.EventsAndAnnoucementsTab.SuspendLayout();
            this.eventTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EventsAndAnnoucementsTab
            // 
            this.EventsAndAnnoucementsTab.Controls.Add(this.eventTab);
            this.EventsAndAnnoucementsTab.Controls.Add(this.announcementsTab);
            this.EventsAndAnnoucementsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventsAndAnnoucementsTab.Location = new System.Drawing.Point(0, 0);
            this.EventsAndAnnoucementsTab.Name = "EventsAndAnnoucementsTab";
            this.EventsAndAnnoucementsTab.SelectedIndex = 0;
            this.EventsAndAnnoucementsTab.Size = new System.Drawing.Size(1135, 683);
            this.EventsAndAnnoucementsTab.TabIndex = 0;
            // 
            // eventTab
            // 
            this.eventTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eventTab.BackgroundImage")));
            this.eventTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eventTab.Controls.Add(this.lblEventDateCheck);
            this.eventTab.Controls.Add(this.btnAddEvent);
            this.eventTab.Controls.Add(this.btnEventFilter);
            this.eventTab.Controls.Add(this.cmbxEventCategory);
            this.eventTab.Controls.Add(this.eventDateTime);
            this.eventTab.Controls.Add(this.panel1);
            this.eventTab.Location = new System.Drawing.Point(4, 22);
            this.eventTab.Name = "eventTab";
            this.eventTab.Size = new System.Drawing.Size(1127, 657);
            this.eventTab.TabIndex = 0;
            this.eventTab.Text = "Events";
            this.eventTab.UseVisualStyleBackColor = true;
            // 
            // announcementsTab
            // 
            this.announcementsTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.announcementsTab.Location = new System.Drawing.Point(4, 22);
            this.announcementsTab.Name = "announcementsTab";
            this.announcementsTab.Size = new System.Drawing.Size(1127, 657);
            this.announcementsTab.TabIndex = 1;
            this.announcementsTab.Text = "Announcements";
            this.announcementsTab.UseVisualStyleBackColor = true;
            // 
            // listVEvents
            // 
            this.listVEvents.BackColor = System.Drawing.SystemColors.Info;
            this.listVEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.eventName,
            this.eventDate,
            this.eventTime,
            this.eventCategory,
            this.eventDescription});
            this.listVEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listVEvents.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVEvents.HideSelection = false;
            this.listVEvents.Location = new System.Drawing.Point(0, 0);
            this.listVEvents.Name = "listVEvents";
            this.listVEvents.Size = new System.Drawing.Size(1127, 478);
            this.listVEvents.TabIndex = 0;
            this.listVEvents.UseCompatibleStateImageBehavior = false;
            // 
            // eventDate
            // 
            this.eventDate.DisplayIndex = 0;
            this.eventDate.Text = "Event Date";
            // 
            // eventTime
            // 
            this.eventTime.DisplayIndex = 1;
            this.eventTime.Text = "Event Time";
            // 
            // eventName
            // 
            this.eventName.DisplayIndex = 2;
            this.eventName.Text = "Event Name";
            // 
            // eventCategory
            // 
            this.eventCategory.Text = "Event Category";
            // 
            // eventDescription
            // 
            this.eventDescription.Text = "Event Description";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listVEvents);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 478);
            this.panel1.TabIndex = 1;
            // 
            // eventDateTime
            // 
            this.eventDateTime.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDateTime.Location = new System.Drawing.Point(8, 497);
            this.eventDateTime.Name = "eventDateTime";
            this.eventDateTime.Size = new System.Drawing.Size(296, 29);
            this.eventDateTime.TabIndex = 1;
            // 
            // cmbxEventCategory
            // 
            this.cmbxEventCategory.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxEventCategory.FormattingEnabled = true;
            this.cmbxEventCategory.Items.AddRange(new object[] {
            "All Events",
            "Fun Day",
            "Community Outreach",
            "Training",
            "Awareness",
            "Celebration",
            "Function"});
            this.cmbxEventCategory.Location = new System.Drawing.Point(8, 543);
            this.cmbxEventCategory.Name = "cmbxEventCategory";
            this.cmbxEventCategory.Size = new System.Drawing.Size(296, 32);
            this.cmbxEventCategory.TabIndex = 3;
            this.cmbxEventCategory.Text = "All Events";
            // 
            // btnEventFilter
            // 
            this.btnEventFilter.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventFilter.Location = new System.Drawing.Point(9, 599);
            this.btnEventFilter.Name = "btnEventFilter";
            this.btnEventFilter.Size = new System.Drawing.Size(295, 43);
            this.btnEventFilter.TabIndex = 4;
            this.btnEventFilter.Text = "Filter Events";
            this.btnEventFilter.UseVisualStyleBackColor = true;
            this.btnEventFilter.Click += new System.EventHandler(this.btnEventFilter_Click);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEvent.Location = new System.Drawing.Point(939, 599);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(180, 43);
            this.btnAddEvent.TabIndex = 5;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // lblEventDateCheck
            // 
            this.lblEventDateCheck.AutoSize = true;
            this.lblEventDateCheck.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEventDateCheck.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDateCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEventDateCheck.Location = new System.Drawing.Point(310, 497);
            this.lblEventDateCheck.Name = "lblEventDateCheck";
            this.lblEventDateCheck.Size = new System.Drawing.Size(100, 28);
            this.lblEventDateCheck.TabIndex = 2;
            this.lblEventDateCheck.Text = "Filter Date";
            this.lblEventDateCheck.UseVisualStyleBackColor = false;
            // 
            // formEventsAndAnnouncements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1135, 683);
            this.Controls.Add(this.EventsAndAnnoucementsTab);
            this.Name = "formEventsAndAnnouncements";
            this.Text = "EventsAndAnnouncements";
            this.EventsAndAnnoucementsTab.ResumeLayout(false);
            this.eventTab.ResumeLayout(false);
            this.eventTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl EventsAndAnnoucementsTab;
        private System.Windows.Forms.TabPage eventTab;
        private System.Windows.Forms.TabPage announcementsTab;
        private System.Windows.Forms.ListView listVEvents;
        private System.Windows.Forms.ColumnHeader eventName;
        private System.Windows.Forms.ColumnHeader eventDate;
        private System.Windows.Forms.ColumnHeader eventTime;
        private System.Windows.Forms.ColumnHeader eventCategory;
        private System.Windows.Forms.ColumnHeader eventDescription;
        private System.Windows.Forms.DateTimePicker eventDateTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEventFilter;
        private System.Windows.Forms.ComboBox cmbxEventCategory;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.CheckBox lblEventDateCheck;
    }
}