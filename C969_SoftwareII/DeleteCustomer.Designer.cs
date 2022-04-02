
namespace C969_SoftwareII
{
    partial class DeleteCustomer
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
            this.deleteLabel = new System.Windows.Forms.GroupBox();
            this.custComboBox = new System.Windows.Forms.ComboBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.noRadio = new System.Windows.Forms.RadioButton();
            this.yesRadio = new System.Windows.Forms.RadioButton();
            this.countryTextbox = new System.Windows.Forms.TextBox();
            this.zipTextbox = new System.Windows.Forms.TextBox();
            this.cityTextbox = new System.Windows.Forms.TextBox();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.phoneTextbox = new System.Windows.Forms.TextBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.activeLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SecAddressTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleteLabel
            // 
            this.deleteLabel.Controls.Add(this.SecAddressTextBox);
            this.deleteLabel.Controls.Add(this.label1);
            this.deleteLabel.Controls.Add(this.custComboBox);
            this.deleteLabel.Controls.Add(this.idLabel);
            this.deleteLabel.Controls.Add(this.clearButton);
            this.deleteLabel.Controls.Add(this.searchButton);
            this.deleteLabel.Controls.Add(this.cancelButton);
            this.deleteLabel.Controls.Add(this.deleteButton);
            this.deleteLabel.Controls.Add(this.noRadio);
            this.deleteLabel.Controls.Add(this.yesRadio);
            this.deleteLabel.Controls.Add(this.countryTextbox);
            this.deleteLabel.Controls.Add(this.zipTextbox);
            this.deleteLabel.Controls.Add(this.cityTextbox);
            this.deleteLabel.Controls.Add(this.addressTextbox);
            this.deleteLabel.Controls.Add(this.phoneTextbox);
            this.deleteLabel.Controls.Add(this.nameTextbox);
            this.deleteLabel.Controls.Add(this.zipLabel);
            this.deleteLabel.Controls.Add(this.activeLabel);
            this.deleteLabel.Controls.Add(this.countryLabel);
            this.deleteLabel.Controls.Add(this.cityLabel);
            this.deleteLabel.Controls.Add(this.addressLabel);
            this.deleteLabel.Controls.Add(this.phoneLabel);
            this.deleteLabel.Controls.Add(this.nameLabel);
            this.deleteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.deleteLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.deleteLabel.Location = new System.Drawing.Point(12, 3);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(277, 434);
            this.deleteLabel.TabIndex = 0;
            this.deleteLabel.TabStop = false;
            this.deleteLabel.Text = "Delete Customer Record";
            // 
            // custComboBox
            // 
            this.custComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.custComboBox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.custComboBox.FormattingEnabled = true;
            this.custComboBox.Location = new System.Drawing.Point(121, 41);
            this.custComboBox.Name = "custComboBox";
            this.custComboBox.Size = new System.Drawing.Size(144, 21);
            this.custComboBox.TabIndex = 98;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.idLabel.Location = new System.Drawing.Point(12, 44);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(103, 13);
            this.idLabel.TabIndex = 97;
            this.idLabel.Text = "Customer Select:";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(157, 343);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(96, 31);
            this.clearButton.TabIndex = 96;
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
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(16, 343);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(96, 31);
            this.searchButton.TabIndex = 95;
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
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(157, 394);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(96, 31);
            this.cancelButton.TabIndex = 93;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Enabled = false;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(15, 394);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(96, 31);
            this.deleteButton.TabIndex = 92;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // noRadio
            // 
            this.noRadio.AutoSize = true;
            this.noRadio.Enabled = false;
            this.noRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.noRadio.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.noRadio.Location = new System.Drawing.Point(214, 314);
            this.noRadio.Name = "noRadio";
            this.noRadio.Size = new System.Drawing.Size(41, 19);
            this.noRadio.TabIndex = 91;
            this.noRadio.TabStop = true;
            this.noRadio.Text = "No";
            this.noRadio.UseVisualStyleBackColor = true;
            // 
            // yesRadio
            // 
            this.yesRadio.AutoSize = true;
            this.yesRadio.Enabled = false;
            this.yesRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.yesRadio.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.yesRadio.Location = new System.Drawing.Point(110, 314);
            this.yesRadio.Name = "yesRadio";
            this.yesRadio.Size = new System.Drawing.Size(45, 19);
            this.yesRadio.TabIndex = 90;
            this.yesRadio.TabStop = true;
            this.yesRadio.Text = "Yes";
            this.yesRadio.UseVisualStyleBackColor = true;
            // 
            // countryTextbox
            // 
            this.countryTextbox.Enabled = false;
            this.countryTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.countryTextbox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.countryTextbox.Location = new System.Drawing.Point(110, 279);
            this.countryTextbox.Name = "countryTextbox";
            this.countryTextbox.Size = new System.Drawing.Size(143, 21);
            this.countryTextbox.TabIndex = 89;
            // 
            // zipTextbox
            // 
            this.zipTextbox.Enabled = false;
            this.zipTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.zipTextbox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.zipTextbox.Location = new System.Drawing.Point(110, 247);
            this.zipTextbox.Name = "zipTextbox";
            this.zipTextbox.Size = new System.Drawing.Size(143, 21);
            this.zipTextbox.TabIndex = 88;
            // 
            // cityTextbox
            // 
            this.cityTextbox.Enabled = false;
            this.cityTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cityTextbox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cityTextbox.Location = new System.Drawing.Point(110, 212);
            this.cityTextbox.Name = "cityTextbox";
            this.cityTextbox.Size = new System.Drawing.Size(143, 21);
            this.cityTextbox.TabIndex = 87;
            // 
            // addressTextbox
            // 
            this.addressTextbox.Enabled = false;
            this.addressTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.addressTextbox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.addressTextbox.Location = new System.Drawing.Point(110, 144);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(143, 21);
            this.addressTextbox.TabIndex = 86;
            // 
            // phoneTextbox
            // 
            this.phoneTextbox.Enabled = false;
            this.phoneTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.phoneTextbox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.phoneTextbox.Location = new System.Drawing.Point(110, 105);
            this.phoneTextbox.Name = "phoneTextbox";
            this.phoneTextbox.Size = new System.Drawing.Size(143, 21);
            this.phoneTextbox.TabIndex = 85;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Enabled = false;
            this.nameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nameTextbox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.nameTextbox.Location = new System.Drawing.Point(110, 78);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(143, 21);
            this.nameTextbox.TabIndex = 84;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.zipLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.zipLabel.Location = new System.Drawing.Point(12, 247);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(59, 15);
            this.zipLabel.TabIndex = 83;
            this.zipLabel.Text = "Zip Code:";
            // 
            // activeLabel
            // 
            this.activeLabel.AutoSize = true;
            this.activeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.activeLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.activeLabel.Location = new System.Drawing.Point(12, 314);
            this.activeLabel.Name = "activeLabel";
            this.activeLabel.Size = new System.Drawing.Size(41, 15);
            this.activeLabel.TabIndex = 82;
            this.activeLabel.Text = "Active:";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.countryLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.countryLabel.Location = new System.Drawing.Point(12, 279);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(51, 15);
            this.countryLabel.TabIndex = 81;
            this.countryLabel.Text = "Country:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cityLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.cityLabel.Location = new System.Drawing.Point(12, 212);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(29, 15);
            this.cityLabel.TabIndex = 80;
            this.cityLabel.Text = "City:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.addressLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.addressLabel.Location = new System.Drawing.Point(13, 144);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(54, 15);
            this.addressLabel.TabIndex = 79;
            this.addressLabel.Text = "Address:";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.phoneLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.phoneLabel.Location = new System.Drawing.Point(13, 105);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(46, 15);
            this.phoneLabel.TabIndex = 78;
            this.phoneLabel.Text = "Phone:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.nameLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.nameLabel.Location = new System.Drawing.Point(12, 78);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 15);
            this.nameLabel.TabIndex = 77;
            this.nameLabel.Text = "Name:";
            // 
            // SecAddressTextBox
            // 
            this.SecAddressTextBox.Enabled = false;
            this.SecAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SecAddressTextBox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.SecAddressTextBox.Location = new System.Drawing.Point(112, 171);
            this.SecAddressTextBox.Name = "SecAddressTextBox";
            this.SecAddressTextBox.Size = new System.Drawing.Size(143, 21);
            this.SecAddressTextBox.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(15, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 99;
            this.label1.Text = "Address2:";
            // 
            // DeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 449);
            this.Controls.Add(this.deleteLabel);
            this.Name = "DeleteCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Customer";
            this.Load += new System.EventHandler(this.DeleteCustomer_Load);
            this.deleteLabel.ResumeLayout(false);
            this.deleteLabel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox deleteLabel;
        private System.Windows.Forms.ComboBox custComboBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.RadioButton noRadio;
        private System.Windows.Forms.RadioButton yesRadio;
        private System.Windows.Forms.TextBox countryTextbox;
        private System.Windows.Forms.TextBox zipTextbox;
        private System.Windows.Forms.TextBox cityTextbox;
        private System.Windows.Forms.TextBox addressTextbox;
        private System.Windows.Forms.TextBox phoneTextbox;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.Label activeLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox SecAddressTextBox;
        private System.Windows.Forms.Label label1;
    }
}