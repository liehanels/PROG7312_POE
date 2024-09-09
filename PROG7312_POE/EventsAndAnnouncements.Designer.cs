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
            this.chbxEventDateCheck = new System.Windows.Forms.CheckBox();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnEventFilter = new System.Windows.Forms.Button();
            this.cmbxEventCategory = new System.Windows.Forms.ComboBox();
            this.eventDateTime = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listVEvents = new System.Windows.Forms.ListView();
            this.announcementsTab = new System.Windows.Forms.TabPage();
            this.btnRefreshAnnouncements = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listVAnnouncements = new System.Windows.Forms.ListView();
            this.reccomendationTab = new System.Windows.Forms.TabPage();
            this.btnReturnToMainMenu = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listVRecommendations = new System.Windows.Forms.ListView();
            this.btnRefreshReccomendations = new System.Windows.Forms.Button();
            this.btnResetRecommendations = new System.Windows.Forms.Button();
            this.EventsAndAnnoucementsTab.SuspendLayout();
            this.eventTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.announcementsTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.reccomendationTab.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // EventsAndAnnoucementsTab
            // 
            this.EventsAndAnnoucementsTab.Controls.Add(this.eventTab);
            this.EventsAndAnnoucementsTab.Controls.Add(this.announcementsTab);
            this.EventsAndAnnoucementsTab.Controls.Add(this.reccomendationTab);
            this.EventsAndAnnoucementsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventsAndAnnoucementsTab.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.eventTab.Controls.Add(this.btnReturnToMainMenu);
            this.eventTab.Controls.Add(this.chbxEventDateCheck);
            this.eventTab.Controls.Add(this.btnAddEvent);
            this.eventTab.Controls.Add(this.btnEventFilter);
            this.eventTab.Controls.Add(this.cmbxEventCategory);
            this.eventTab.Controls.Add(this.eventDateTime);
            this.eventTab.Controls.Add(this.panel1);
            this.eventTab.Location = new System.Drawing.Point(4, 33);
            this.eventTab.Name = "eventTab";
            this.eventTab.Size = new System.Drawing.Size(1127, 646);
            this.eventTab.TabIndex = 0;
            this.eventTab.Text = "Events";
            this.eventTab.UseVisualStyleBackColor = true;
            // 
            // chbxEventDateCheck
            // 
            this.chbxEventDateCheck.AutoSize = true;
            this.chbxEventDateCheck.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chbxEventDateCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxEventDateCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chbxEventDateCheck.Location = new System.Drawing.Point(310, 497);
            this.chbxEventDateCheck.Name = "chbxEventDateCheck";
            this.chbxEventDateCheck.Size = new System.Drawing.Size(113, 28);
            this.chbxEventDateCheck.TabIndex = 2;
            this.chbxEventDateCheck.Text = "Filter Date";
            this.chbxEventDateCheck.UseVisualStyleBackColor = false;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEvent.Location = new System.Drawing.Point(939, 599);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(180, 43);
            this.btnAddEvent.TabIndex = 5;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // btnEventFilter
            // 
            this.btnEventFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventFilter.Location = new System.Drawing.Point(9, 599);
            this.btnEventFilter.Name = "btnEventFilter";
            this.btnEventFilter.Size = new System.Drawing.Size(295, 43);
            this.btnEventFilter.TabIndex = 4;
            this.btnEventFilter.Text = "Filter Events";
            this.btnEventFilter.UseVisualStyleBackColor = true;
            this.btnEventFilter.Click += new System.EventHandler(this.btnEventFilter_Click);
            // 
            // cmbxEventCategory
            // 
            this.cmbxEventCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // eventDateTime
            // 
            this.eventDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDateTime.Location = new System.Drawing.Point(8, 497);
            this.eventDateTime.Name = "eventDateTime";
            this.eventDateTime.Size = new System.Drawing.Size(296, 29);
            this.eventDateTime.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.listVEvents);
            this.panel1.Location = new System.Drawing.Point(8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 478);
            this.panel1.TabIndex = 1;
            // 
            // listVEvents
            // 
            this.listVEvents.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listVEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listVEvents.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVEvents.HideSelection = false;
            this.listVEvents.Location = new System.Drawing.Point(0, 0);
            this.listVEvents.Name = "listVEvents";
            this.listVEvents.Size = new System.Drawing.Size(1111, 478);
            this.listVEvents.TabIndex = 0;
            this.listVEvents.UseCompatibleStateImageBehavior = false;
            // 
            // announcementsTab
            // 
            this.announcementsTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("announcementsTab.BackgroundImage")));
            this.announcementsTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.announcementsTab.Controls.Add(this.btnRefreshAnnouncements);
            this.announcementsTab.Controls.Add(this.panel2);
            this.announcementsTab.Location = new System.Drawing.Point(4, 33);
            this.announcementsTab.Name = "announcementsTab";
            this.announcementsTab.Size = new System.Drawing.Size(1127, 646);
            this.announcementsTab.TabIndex = 1;
            this.announcementsTab.Text = "Announcements";
            this.announcementsTab.UseVisualStyleBackColor = true;
            // 
            // btnRefreshAnnouncements
            // 
            this.btnRefreshAnnouncements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshAnnouncements.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshAnnouncements.Location = new System.Drawing.Point(8, 583);
            this.btnRefreshAnnouncements.Name = "btnRefreshAnnouncements";
            this.btnRefreshAnnouncements.Size = new System.Drawing.Size(1111, 43);
            this.btnRefreshAnnouncements.TabIndex = 5;
            this.btnRefreshAnnouncements.Text = "Refresh Announcements";
            this.btnRefreshAnnouncements.UseVisualStyleBackColor = true;
            this.btnRefreshAnnouncements.Click += new System.EventHandler(this.btnRefreshAnnouncements_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.listVAnnouncements);
            this.panel2.Location = new System.Drawing.Point(8, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1111, 563);
            this.panel2.TabIndex = 0;
            // 
            // listVAnnouncements
            // 
            this.listVAnnouncements.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listVAnnouncements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listVAnnouncements.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVAnnouncements.HideSelection = false;
            this.listVAnnouncements.Location = new System.Drawing.Point(0, 0);
            this.listVAnnouncements.Name = "listVAnnouncements";
            this.listVAnnouncements.Size = new System.Drawing.Size(1111, 563);
            this.listVAnnouncements.TabIndex = 0;
            this.listVAnnouncements.UseCompatibleStateImageBehavior = false;
            // 
            // reccomendationTab
            // 
            this.reccomendationTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reccomendationTab.BackgroundImage")));
            this.reccomendationTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reccomendationTab.Controls.Add(this.btnResetRecommendations);
            this.reccomendationTab.Controls.Add(this.btnRefreshReccomendations);
            this.reccomendationTab.Controls.Add(this.panel3);
            this.reccomendationTab.Location = new System.Drawing.Point(4, 33);
            this.reccomendationTab.Name = "reccomendationTab";
            this.reccomendationTab.Size = new System.Drawing.Size(1127, 646);
            this.reccomendationTab.TabIndex = 2;
            this.reccomendationTab.Text = "Recommendations";
            this.reccomendationTab.UseVisualStyleBackColor = true;
            // 
            // btnReturnToMainMenu
            // 
            this.btnReturnToMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturnToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToMainMenu.Location = new System.Drawing.Point(732, 599);
            this.btnReturnToMainMenu.Name = "btnReturnToMainMenu";
            this.btnReturnToMainMenu.Size = new System.Drawing.Size(180, 43);
            this.btnReturnToMainMenu.TabIndex = 6;
            this.btnReturnToMainMenu.Text = "Main Menu";
            this.btnReturnToMainMenu.UseVisualStyleBackColor = true;
            this.btnReturnToMainMenu.Click += new System.EventHandler(this.btnReturnToMainMenu_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.listVRecommendations);
            this.panel3.Location = new System.Drawing.Point(8, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1111, 503);
            this.panel3.TabIndex = 0;
            // 
            // listVRecommendations
            // 
            this.listVRecommendations.BackColor = System.Drawing.Color.CadetBlue;
            this.listVRecommendations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listVRecommendations.Font = new System.Drawing.Font("Franklin Gothic Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listVRecommendations.HideSelection = false;
            this.listVRecommendations.Location = new System.Drawing.Point(0, 0);
            this.listVRecommendations.Name = "listVRecommendations";
            this.listVRecommendations.Size = new System.Drawing.Size(1111, 503);
            this.listVRecommendations.TabIndex = 0;
            this.listVRecommendations.UseCompatibleStateImageBehavior = false;
            // 
            // btnRefreshReccomendations
            // 
            this.btnRefreshReccomendations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshReccomendations.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshReccomendations.Location = new System.Drawing.Point(8, 537);
            this.btnRefreshReccomendations.Name = "btnRefreshReccomendations";
            this.btnRefreshReccomendations.Size = new System.Drawing.Size(1111, 43);
            this.btnRefreshReccomendations.TabIndex = 6;
            this.btnRefreshReccomendations.Text = "Update Recommendations";
            this.btnRefreshReccomendations.UseVisualStyleBackColor = true;
            this.btnRefreshReccomendations.Click += new System.EventHandler(this.btnRefreshReccomendations_Click);
            // 
            // btnResetRecommendations
            // 
            this.btnResetRecommendations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetRecommendations.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetRecommendations.Location = new System.Drawing.Point(8, 595);
            this.btnResetRecommendations.Name = "btnResetRecommendations";
            this.btnResetRecommendations.Size = new System.Drawing.Size(1111, 43);
            this.btnResetRecommendations.TabIndex = 7;
            this.btnResetRecommendations.Text = "Reset Recommendations";
            this.btnResetRecommendations.UseVisualStyleBackColor = true;
            this.btnResetRecommendations.Click += new System.EventHandler(this.btnResetRecommendations_Click);
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
            this.announcementsTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.reccomendationTab.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl EventsAndAnnoucementsTab;
        private System.Windows.Forms.TabPage eventTab;
        private System.Windows.Forms.TabPage announcementsTab;
        private System.Windows.Forms.ListView listVEvents;
        private System.Windows.Forms.DateTimePicker eventDateTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEventFilter;
        private System.Windows.Forms.ComboBox cmbxEventCategory;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.CheckBox chbxEventDateCheck;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefreshAnnouncements;
        private System.Windows.Forms.ListView listVAnnouncements;
        private System.Windows.Forms.TabPage reccomendationTab;
        private System.Windows.Forms.Button btnReturnToMainMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listVRecommendations;
        private System.Windows.Forms.Button btnRefreshReccomendations;
        private System.Windows.Forms.Button btnResetRecommendations;
    }
}