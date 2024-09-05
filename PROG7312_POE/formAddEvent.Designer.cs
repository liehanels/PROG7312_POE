namespace PROG7312_POE
{
    partial class formAddEvent
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtEventDescription = new System.Windows.Forms.TextBox();
            this.lblEventDescription = new System.Windows.Forms.Label();
            this.lblEventCategory = new System.Windows.Forms.Label();
            this.lblEventTime = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSaveEvent = new System.Windows.Forms.Button();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.dpEventDate = new System.Windows.Forms.DateTimePicker();
            this.cmbxEventCategory = new System.Windows.Forms.ComboBox();
            this.dpEventTime = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.txtEventDescription, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblEventDescription, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblEventCategory, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblEventTime, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblEventDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEventName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnReturn, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnSaveEvent, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtEventName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dpEventDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbxEventCategory, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dpEventTime, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtEventDescription
            // 
            this.txtEventDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEventDescription.Font = new System.Drawing.Font("Franklin Gothic Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventDescription.Location = new System.Drawing.Point(243, 271);
            this.txtEventDescription.Multiline = true;
            this.txtEventDescription.Name = "txtEventDescription";
            this.txtEventDescription.Size = new System.Drawing.Size(554, 84);
            this.txtEventDescription.TabIndex = 3;
            // 
            // lblEventDescription
            // 
            this.lblEventDescription.AutoSize = true;
            this.lblEventDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEventDescription.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDescription.Location = new System.Drawing.Point(3, 268);
            this.lblEventDescription.Name = "lblEventDescription";
            this.lblEventDescription.Size = new System.Drawing.Size(234, 90);
            this.lblEventDescription.TabIndex = 9;
            this.lblEventDescription.Text = "Description :";
            this.lblEventDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEventCategory
            // 
            this.lblEventCategory.AutoSize = true;
            this.lblEventCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEventCategory.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventCategory.Location = new System.Drawing.Point(3, 201);
            this.lblEventCategory.Name = "lblEventCategory";
            this.lblEventCategory.Size = new System.Drawing.Size(234, 67);
            this.lblEventCategory.TabIndex = 7;
            this.lblEventCategory.Text = "Category :";
            this.lblEventCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEventTime
            // 
            this.lblEventTime.AutoSize = true;
            this.lblEventTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEventTime.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventTime.Location = new System.Drawing.Point(3, 134);
            this.lblEventTime.Name = "lblEventTime";
            this.lblEventTime.Size = new System.Drawing.Size(234, 67);
            this.lblEventTime.TabIndex = 5;
            this.lblEventTime.Text = "Time :";
            this.lblEventTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEventDate.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventDate.Location = new System.Drawing.Point(3, 67);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(234, 67);
            this.lblEventDate.TabIndex = 3;
            this.lblEventDate.Text = "Date :";
            this.lblEventDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEventName.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventName.Location = new System.Drawing.Point(3, 0);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(234, 67);
            this.lblEventName.TabIndex = 1;
            this.lblEventName.Text = "Event name :";
            this.lblEventName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnReturn
            // 
            this.btnReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReturn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(3, 361);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(234, 86);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSaveEvent
            // 
            this.btnSaveEvent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveEvent.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEvent.Location = new System.Drawing.Point(243, 361);
            this.btnSaveEvent.Name = "btnSaveEvent";
            this.btnSaveEvent.Size = new System.Drawing.Size(554, 86);
            this.btnSaveEvent.TabIndex = 4;
            this.btnSaveEvent.Text = "Save event details";
            this.btnSaveEvent.UseVisualStyleBackColor = true;
            this.btnSaveEvent.Click += new System.EventHandler(this.btnSaveEvent_Click);
            // 
            // txtEventName
            // 
            this.txtEventName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEventName.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.Location = new System.Drawing.Point(243, 19);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(554, 29);
            this.txtEventName.TabIndex = 1;
            // 
            // dpEventDate
            // 
            this.dpEventDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dpEventDate.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpEventDate.Location = new System.Drawing.Point(243, 86);
            this.dpEventDate.Name = "dpEventDate";
            this.dpEventDate.Size = new System.Drawing.Size(554, 29);
            this.dpEventDate.TabIndex = 10;
            // 
            // cmbxEventCategory
            // 
            this.cmbxEventCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbxEventCategory.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxEventCategory.FormattingEnabled = true;
            this.cmbxEventCategory.Items.AddRange(new object[] {
            "All Events",
            "Fun Day",
            "Community Outreach",
            "Training",
            "Awareness",
            "Celebration",
            "Function"});
            this.cmbxEventCategory.Location = new System.Drawing.Point(243, 218);
            this.cmbxEventCategory.Name = "cmbxEventCategory";
            this.cmbxEventCategory.Size = new System.Drawing.Size(554, 32);
            this.cmbxEventCategory.TabIndex = 2;
            // 
            // dpEventTime
            // 
            this.dpEventTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dpEventTime.Font = new System.Drawing.Font("Franklin Gothic Book", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpEventTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dpEventTime.Location = new System.Drawing.Point(243, 153);
            this.dpEventTime.Name = "dpEventTime";
            this.dpEventTime.Size = new System.Drawing.Size(554, 29);
            this.dpEventTime.TabIndex = 12;
            // 
            // formAddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "formAddEvent";
            this.Text = "formAddEvent";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblEventDescription;
        private System.Windows.Forms.Label lblEventCategory;
        private System.Windows.Forms.Label lblEventTime;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSaveEvent;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox txtEventDescription;
        private System.Windows.Forms.DateTimePicker dpEventDate;
        private System.Windows.Forms.ComboBox cmbxEventCategory;
        private System.Windows.Forms.DateTimePicker dpEventTime;
    }
}