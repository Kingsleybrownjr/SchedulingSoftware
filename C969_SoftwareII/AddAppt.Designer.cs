namespace C969_SoftwareII
{
    partial class AddAppt
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
            this.cancelButton = new System.Windows.Forms.Button();
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
            this.createCusButton = new System.Windows.Forms.Button();
            this.custLabel = new System.Windows.Forms.Label();
            this.custComboBox = new System.Windows.Forms.ComboBox();
            this.appointLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // appointLabel
            // 
            this.appointLabel.Controls.Add(this.typeCombobox);
            this.appointLabel.Controls.Add(this.cancelButton);
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
            this.appointLabel.Controls.Add(this.createCusButton);
            this.appointLabel.Controls.Add(this.custLabel);
            this.appointLabel.Controls.Add(this.custComboBox);
            this.appointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.appointLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.appointLabel.Location = new System.Drawing.Point(12, 12);
            this.appointLabel.Name = "appointLabel";
            this.appointLabel.Size = new System.Drawing.Size(359, 463);
            this.appointLabel.TabIndex = 56;
            this.appointLabel.TabStop = false;
            this.appointLabel.Text = "Enter New Appointment Information";
            // 
            // typeCombobox
            // 
            this.typeCombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.typeCombobox.FormattingEnabled = true;
            this.typeCombobox.Items.AddRange(new object[] {
            "Event",
            "Follow Up",
            "Initial Consultation",
            "Lab Visit",
            "Other",
            "Physical",
            "Surgery"});
            this.typeCombobox.Location = new System.Drawing.Point(132, 268);
            this.typeCombobox.Name = "typeCombobox";
            this.typeCombobox.Size = new System.Drawing.Size(192, 21);
            this.typeCombobox.TabIndex = 74;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(228, 418);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(96, 31);
            this.cancelButton.TabIndex = 73;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.endLabel.Location = new System.Drawing.Point(35, 366);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(55, 13);
            this.endLabel.TabIndex = 72;
            this.endLabel.Text = "End Time:";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.startLabel.Location = new System.Drawing.Point(35, 317);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(58, 13);
            this.startLabel.TabIndex = 71;
            this.startLabel.Text = "Start Time:";
            // 
            // endDTP
            // 
            this.endDTP.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.endDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.endDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDTP.Location = new System.Drawing.Point(132, 360);
            this.endDTP.Name = "endDTP";
            this.endDTP.Size = new System.Drawing.Size(192, 20);
            this.endDTP.TabIndex = 70;
            // 
            // startDTP
            // 
            this.startDTP.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.startDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.startDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDTP.Location = new System.Drawing.Point(132, 311);
            this.startDTP.Name = "startDTP";
            this.startDTP.Size = new System.Drawing.Size(192, 20);
            this.startDTP.TabIndex = 69;
            // 
            // contactTextbox
            // 
            this.contactTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.contactTextbox.Location = new System.Drawing.Point(132, 230);
            this.contactTextbox.Name = "contactTextbox";
            this.contactTextbox.Size = new System.Drawing.Size(192, 20);
            this.contactTextbox.TabIndex = 68;
            // 
            // locationTextbox
            // 
            this.locationTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.locationTextbox.Location = new System.Drawing.Point(132, 196);
            this.locationTextbox.Name = "locationTextbox";
            this.locationTextbox.Size = new System.Drawing.Size(192, 20);
            this.locationTextbox.TabIndex = 67;
            // 
            // descriptionTextbox
            // 
            this.descriptionTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.descriptionTextbox.Location = new System.Drawing.Point(132, 128);
            this.descriptionTextbox.Multiline = true;
            this.descriptionTextbox.Name = "descriptionTextbox";
            this.descriptionTextbox.Size = new System.Drawing.Size(192, 52);
            this.descriptionTextbox.TabIndex = 66;
            // 
            // titleTextbox
            // 
            this.titleTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.titleTextbox.Location = new System.Drawing.Point(132, 89);
            this.titleTextbox.MaxLength = 255;
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(192, 20);
            this.titleTextbox.TabIndex = 65;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.typeLabel.Location = new System.Drawing.Point(35, 268);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(34, 13);
            this.typeLabel.TabIndex = 64;
            this.typeLabel.Text = "Type:";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.contactLabel.Location = new System.Drawing.Point(35, 233);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(47, 13);
            this.contactLabel.TabIndex = 63;
            this.contactLabel.Text = "Contact:";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.locationLabel.Location = new System.Drawing.Point(35, 199);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(51, 13);
            this.locationLabel.TabIndex = 62;
            this.locationLabel.Text = "Location:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.descriptionLabel.Location = new System.Drawing.Point(35, 128);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.descriptionLabel.TabIndex = 61;
            this.descriptionLabel.Text = "Description:";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.titleLabel.Location = new System.Drawing.Point(35, 89);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(30, 13);
            this.titleLabel.TabIndex = 60;
            this.titleLabel.Text = "Title:";
            // 
            // createCusButton
            // 
            this.createCusButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.createCusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createCusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.createCusButton.ForeColor = System.Drawing.Color.White;
            this.createCusButton.Location = new System.Drawing.Point(38, 418);
            this.createCusButton.Name = "createCusButton";
            this.createCusButton.Size = new System.Drawing.Size(96, 31);
            this.createCusButton.TabIndex = 59;
            this.createCusButton.Text = "Create";
            this.createCusButton.UseVisualStyleBackColor = false;
            this.createCusButton.Click += new System.EventHandler(this.CreateCusButton_Click);
            // 
            // custLabel
            // 
            this.custLabel.AutoSize = true;
            this.custLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.custLabel.Location = new System.Drawing.Point(35, 52);
            this.custLabel.Name = "custLabel";
            this.custLabel.Size = new System.Drawing.Size(54, 13);
            this.custLabel.TabIndex = 58;
            this.custLabel.Text = "Customer:";
            // 
            // custComboBox
            // 
            this.custComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.custComboBox.FormattingEnabled = true;
            this.custComboBox.Location = new System.Drawing.Point(132, 49);
            this.custComboBox.Name = "custComboBox";
            this.custComboBox.Size = new System.Drawing.Size(192, 21);
            this.custComboBox.TabIndex = 56;
            // 
            // AddAppt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 487);
            this.Controls.Add(this.appointLabel);
            this.Name = "AddAppt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Appointment";
            this.Load += new System.EventHandler(this.AddAppt_Load_1);
            this.appointLabel.ResumeLayout(false);
            this.appointLabel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox appointLabel;
        private System.Windows.Forms.ComboBox typeCombobox;
        private System.Windows.Forms.Button cancelButton;
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
        private System.Windows.Forms.Button createCusButton;
        private System.Windows.Forms.Label custLabel;
        private System.Windows.Forms.ComboBox custComboBox;
    }
}