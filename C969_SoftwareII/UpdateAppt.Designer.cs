namespace C969_SoftwareII
{
    partial class UpdateAppt
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
            this.appointLabel = new System.Windows.Forms.GroupBox();
            this.typeCombobox = new System.Windows.Forms.ComboBox();
            this.customerLabel = new System.Windows.Forms.Label();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.endLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.endDTP = new System.Windows.Forms.DateTimePicker();
            this.startDTP = new System.Windows.Forms.DateTimePicker();
            this.contactTextbox = new System.Windows.Forms.TextBox();
            this.locationTextbox = new System.Windows.Forms.TextBox();
            this.descriptionTextbox = new System.Windows.Forms.TextBox();
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.appointSelectLabel = new System.Windows.Forms.Label();
            this.appointComboBox = new System.Windows.Forms.ComboBox();
            this.appointLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // appointLabel
            // 
            this.appointLabel.Controls.Add(this.typeCombobox);
            this.appointLabel.Controls.Add(this.customerLabel);
            this.appointLabel.Controls.Add(this.customerComboBox);
            this.appointLabel.Controls.Add(this.clearButton);
            this.appointLabel.Controls.Add(this.searchButton);
            this.appointLabel.Controls.Add(this.cancelButton);
            this.appointLabel.Controls.Add(this.updateButton);
            this.appointLabel.Controls.Add(this.endLabel);
            this.appointLabel.Controls.Add(this.startLabel);
            this.appointLabel.Controls.Add(this.endDTP);
            this.appointLabel.Controls.Add(this.startDTP);
            this.appointLabel.Controls.Add(this.contactTextbox);
            this.appointLabel.Controls.Add(this.locationTextbox);
            this.appointLabel.Controls.Add(this.descriptionTextbox);
            this.appointLabel.Controls.Add(this.titleTextbox);
            this.appointLabel.Controls.Add(this.typeLabel);
            this.appointLabel.Controls.Add(this.contactLabel);
            this.appointLabel.Controls.Add(this.locationLabel);
            this.appointLabel.Controls.Add(this.descriptionLabel);
            this.appointLabel.Controls.Add(this.titleLabel);
            this.appointLabel.Controls.Add(this.appointSelectLabel);
            this.appointLabel.Controls.Add(this.appointComboBox);
            this.appointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.appointLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.appointLabel.Location = new System.Drawing.Point(12, 12);
            this.appointLabel.Name = "appointLabel";
            this.appointLabel.Size = new System.Drawing.Size(378, 526);
            this.appointLabel.TabIndex = 0;
            this.appointLabel.TabStop = false;
            this.appointLabel.Text = "Update Appointment Information";
            // 
            // typeCombobox
            // 
            this.typeCombobox.Enabled = false;
            this.typeCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.typeCombobox.FormattingEnabled = true;
            this.typeCombobox.Items.AddRange(new object[] {
            "Event",
            "Follow Up",
            "Initial Consultation",
            "Lab Visit",
            "Other",
            "Physical",
            "Surgery"});
            this.typeCombobox.Location = new System.Drawing.Point(142, 294);
            this.typeCombobox.Name = "typeCombobox";
            this.typeCombobox.Size = new System.Drawing.Size(192, 23);
            this.typeCombobox.TabIndex = 101;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.customerLabel.Location = new System.Drawing.Point(45, 85);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(63, 15);
            this.customerLabel.TabIndex = 100;
            this.customerLabel.Text = "Customer:";
            // 
            // customerComboBox
            // 
            this.customerComboBox.Enabled = false;
            this.customerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(142, 82);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(192, 23);
            this.customerComboBox.TabIndex = 99;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.clearButton.ForeColor = System.Drawing.SystemColors.Control;
            this.clearButton.Location = new System.Drawing.Point(219, 438);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(96, 31);
            this.clearButton.TabIndex = 98;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.searchButton.ForeColor = System.Drawing.SystemColors.Control;
            this.searchButton.Location = new System.Drawing.Point(78, 438);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(96, 31);
            this.searchButton.TabIndex = 97;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cancelButton.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelButton.Location = new System.Drawing.Point(219, 489);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(96, 31);
            this.cancelButton.TabIndex = 96;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.Enabled = false;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.updateButton.ForeColor = System.Drawing.SystemColors.Control;
            this.updateButton.Location = new System.Drawing.Point(77, 489);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(96, 31);
            this.updateButton.TabIndex = 95;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.endLabel.Location = new System.Drawing.Point(45, 395);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(63, 15);
            this.endLabel.TabIndex = 94;
            this.endLabel.Text = "End Time:";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.startLabel.Location = new System.Drawing.Point(45, 346);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(66, 15);
            this.startLabel.TabIndex = 93;
            this.startLabel.Text = "Start Time:";
            // 
            // endDTP
            // 
            this.endDTP.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.endDTP.Enabled = false;
            this.endDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.endDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDTP.Location = new System.Drawing.Point(142, 389);
            this.endDTP.Name = "endDTP";
            this.endDTP.Size = new System.Drawing.Size(192, 21);
            this.endDTP.TabIndex = 92;
            // 
            // startDTP
            // 
            this.startDTP.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.startDTP.Enabled = false;
            this.startDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.startDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDTP.Location = new System.Drawing.Point(142, 340);
            this.startDTP.Name = "startDTP";
            this.startDTP.Size = new System.Drawing.Size(192, 21);
            this.startDTP.TabIndex = 91;
            // 
            // contactTextbox
            // 
            this.contactTextbox.Enabled = false;
            this.contactTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.contactTextbox.Location = new System.Drawing.Point(142, 259);
            this.contactTextbox.Name = "contactTextbox";
            this.contactTextbox.Size = new System.Drawing.Size(192, 21);
            this.contactTextbox.TabIndex = 90;
            // 
            // locationTextbox
            // 
            this.locationTextbox.Enabled = false;
            this.locationTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.locationTextbox.Location = new System.Drawing.Point(142, 225);
            this.locationTextbox.Name = "locationTextbox";
            this.locationTextbox.Size = new System.Drawing.Size(192, 21);
            this.locationTextbox.TabIndex = 89;
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Enabled = false;
            this.descriptionTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.descriptionTextbox.Location = new System.Drawing.Point(142, 157);
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(192, 52);
            this.descriptionTextbox.TabIndex = 88;
            // 
            // titleTextbox
            // 
            this.titleTextbox.Enabled = false;
            this.titleTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.titleTextbox.Location = new System.Drawing.Point(142, 118);
            this.titleTextbox.MaxLength = 255;
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(192, 21);
            this.titleTextbox.TabIndex = 87;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.typeLabel.Location = new System.Drawing.Point(45, 297);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(36, 15);
            this.typeLabel.TabIndex = 86;
            this.typeLabel.Text = "Type:";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.contactLabel.Location = new System.Drawing.Point(45, 262);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(51, 15);
            this.contactLabel.TabIndex = 85;
            this.contactLabel.Text = "Contact:";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.locationLabel.Location = new System.Drawing.Point(45, 228);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(57, 15);
            this.locationLabel.TabIndex = 84;
            this.locationLabel.Text = "Location:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.descriptionLabel.Location = new System.Drawing.Point(45, 157);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(72, 15);
            this.descriptionLabel.TabIndex = 83;
            this.descriptionLabel.Text = "Description:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.titleLabel.Location = new System.Drawing.Point(45, 118);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(33, 15);
            this.titleLabel.TabIndex = 82;
            this.titleLabel.Text = "Title:";
            // 
            // appointSelectLabel
            // 
            this.appointSelectLabel.AutoSize = true;
            this.appointSelectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.appointSelectLabel.Location = new System.Drawing.Point(45, 44);
            this.appointSelectLabel.Name = "appointSelectLabel";
            this.appointSelectLabel.Size = new System.Drawing.Size(79, 15);
            this.appointSelectLabel.TabIndex = 81;
            this.appointSelectLabel.Text = "Appointment:";
            // 
            // appointComboBox
            // 
            this.appointComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.appointComboBox.FormattingEnabled = true;
            this.appointComboBox.Location = new System.Drawing.Point(142, 41);
            this.appointComboBox.Name = "appointComboBox";
            this.appointComboBox.Size = new System.Drawing.Size(192, 23);
            this.appointComboBox.TabIndex = 79;
            // 
            // UpdateAppt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 550);
            this.Controls.Add(this.appointLabel);
            this.Name = "UpdateAppt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Appointment";
            this.Load += new System.EventHandler(this.UpdateAppoint_Load);
            this.appointLabel.ResumeLayout(false);
            this.appointLabel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox appointLabel;
        private System.Windows.Forms.ComboBox typeCombobox;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.DateTimePicker endDTP;
        private System.Windows.Forms.DateTimePicker startDTP;
        private System.Windows.Forms.TextBox contactTextbox;
        private System.Windows.Forms.TextBox locationTextbox;
        private System.Windows.Forms.TextBox descriptionTextbox;
        private System.Windows.Forms.TextBox titleTextbox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label appointSelectLabel;
        private System.Windows.Forms.ComboBox appointComboBox;
    }
}