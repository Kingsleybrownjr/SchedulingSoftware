namespace C969_SoftwareII
{
    partial class Dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dashLabel = new System.Windows.Forms.GroupBox();
            this.reportsGroupbox = new System.Windows.Forms.GroupBox();
            this.loginsReportButton = new System.Windows.Forms.Button();
            this.schedButton = new System.Windows.Forms.Button();
            this.numApptButton = new System.Windows.Forms.Button();
            this.custGroupbox = new System.Windows.Forms.GroupBox();
            this.deleteCusButton = new System.Windows.Forms.Button();
            this.updateCusButton = new System.Windows.Forms.Button();
            this.createCusButton = new System.Windows.Forms.Button();
            this.apptGroupbox = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.monthViewRadio = new System.Windows.Forms.RadioButton();
            this.weekViewRadio = new System.Windows.Forms.RadioButton();
            this.deleteApptButton = new System.Windows.Forms.Button();
            this.updateApptButton = new System.Windows.Forms.Button();
            this.addApptButton = new System.Windows.Forms.Button();
            this.dashLabel.SuspendLayout();
            this.reportsGroupbox.SuspendLayout();
            this.custGroupbox.SuspendLayout();
            this.apptGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dashLabel
            // 
            this.dashLabel.Controls.Add(this.reportsGroupbox);
            this.dashLabel.Controls.Add(this.custGroupbox);
            this.dashLabel.Controls.Add(this.apptGroupbox);
            this.dashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dashLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.dashLabel.Location = new System.Drawing.Point(12, 12);
            this.dashLabel.Name = "dashLabel";
            this.dashLabel.Size = new System.Drawing.Size(950, 501);
            this.dashLabel.TabIndex = 0;
            this.dashLabel.TabStop = false;
            this.dashLabel.Text = "Dashboard";
            // 
            // reportsGroupbox
            // 
            this.reportsGroupbox.Controls.Add(this.loginsReportButton);
            this.reportsGroupbox.Controls.Add(this.schedButton);
            this.reportsGroupbox.Controls.Add(this.numApptButton);
            this.reportsGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.reportsGroupbox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.reportsGroupbox.Location = new System.Drawing.Point(494, 30);
            this.reportsGroupbox.Name = "reportsGroupbox";
            this.reportsGroupbox.Size = new System.Drawing.Size(452, 106);
            this.reportsGroupbox.TabIndex = 7;
            this.reportsGroupbox.TabStop = false;
            this.reportsGroupbox.Text = "Reports";
            // 
            // loginsReportButton
            // 
            this.loginsReportButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.loginsReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginsReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginsReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.loginsReportButton.ForeColor = System.Drawing.SystemColors.Control;
            this.loginsReportButton.Location = new System.Drawing.Point(312, 38);
            this.loginsReportButton.Name = "loginsReportButton";
            this.loginsReportButton.Size = new System.Drawing.Size(121, 31);
            this.loginsReportButton.TabIndex = 5;
            this.loginsReportButton.Text = "Timecard";
            this.loginsReportButton.UseVisualStyleBackColor = false;
            this.loginsReportButton.Click += new System.EventHandler(this.cusReportButton_Click);
            // 
            // schedButton
            // 
            this.schedButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.schedButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.schedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.schedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.schedButton.ForeColor = System.Drawing.SystemColors.Control;
            this.schedButton.Location = new System.Drawing.Point(178, 38);
            this.schedButton.Name = "schedButton";
            this.schedButton.Size = new System.Drawing.Size(128, 31);
            this.schedButton.TabIndex = 4;
            this.schedButton.Text = "Consultant Schedules";
            this.schedButton.UseVisualStyleBackColor = false;
            this.schedButton.Click += new System.EventHandler(this.schedButton_Click);
            // 
            // numApptButton
            // 
            this.numApptButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.numApptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numApptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numApptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.numApptButton.ForeColor = System.Drawing.SystemColors.Control;
            this.numApptButton.Location = new System.Drawing.Point(30, 38);
            this.numApptButton.Name = "numApptButton";
            this.numApptButton.Size = new System.Drawing.Size(142, 31);
            this.numApptButton.TabIndex = 3;
            this.numApptButton.Text = "Number of Appointments";
            this.numApptButton.UseVisualStyleBackColor = false;
            this.numApptButton.Click += new System.EventHandler(this.numApptButton_Click);
            // 
            // custGroupbox
            // 
            this.custGroupbox.Controls.Add(this.deleteCusButton);
            this.custGroupbox.Controls.Add(this.updateCusButton);
            this.custGroupbox.Controls.Add(this.createCusButton);
            this.custGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.custGroupbox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.custGroupbox.Location = new System.Drawing.Point(5, 30);
            this.custGroupbox.Name = "custGroupbox";
            this.custGroupbox.Size = new System.Drawing.Size(458, 106);
            this.custGroupbox.TabIndex = 6;
            this.custGroupbox.TabStop = false;
            this.custGroupbox.Text = "Customer Records";
            // 
            // deleteCusButton
            // 
            this.deleteCusButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.deleteCusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteCusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.deleteCusButton.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteCusButton.Location = new System.Drawing.Point(274, 42);
            this.deleteCusButton.Name = "deleteCusButton";
            this.deleteCusButton.Size = new System.Drawing.Size(96, 31);
            this.deleteCusButton.TabIndex = 2;
            this.deleteCusButton.Text = "Delete";
            this.deleteCusButton.UseVisualStyleBackColor = false;
            this.deleteCusButton.Click += new System.EventHandler(this.deleteCusButton_Click);
            // 
            // updateCusButton
            // 
            this.updateCusButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.updateCusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateCusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateCusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.updateCusButton.ForeColor = System.Drawing.SystemColors.Control;
            this.updateCusButton.Location = new System.Drawing.Point(172, 42);
            this.updateCusButton.Name = "updateCusButton";
            this.updateCusButton.Size = new System.Drawing.Size(96, 31);
            this.updateCusButton.TabIndex = 1;
            this.updateCusButton.Text = "Update";
            this.updateCusButton.UseVisualStyleBackColor = false;
            this.updateCusButton.Click += new System.EventHandler(this.updateCusButton_Click);
            // 
            // createCusButton
            // 
            this.createCusButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.createCusButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createCusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.createCusButton.ForeColor = System.Drawing.SystemColors.Control;
            this.createCusButton.Location = new System.Drawing.Point(70, 42);
            this.createCusButton.Name = "createCusButton";
            this.createCusButton.Size = new System.Drawing.Size(96, 31);
            this.createCusButton.TabIndex = 0;
            this.createCusButton.Text = "Create";
            this.createCusButton.UseVisualStyleBackColor = false;
            this.createCusButton.Click += new System.EventHandler(this.createCusButton_Click);
            // 
            // apptGroupbox
            // 
            this.apptGroupbox.Controls.Add(this.dataGridView);
            this.apptGroupbox.Controls.Add(this.monthViewRadio);
            this.apptGroupbox.Controls.Add(this.weekViewRadio);
            this.apptGroupbox.Controls.Add(this.deleteApptButton);
            this.apptGroupbox.Controls.Add(this.updateApptButton);
            this.apptGroupbox.Controls.Add(this.addApptButton);
            this.apptGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.apptGroupbox.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.apptGroupbox.Location = new System.Drawing.Point(5, 172);
            this.apptGroupbox.Name = "apptGroupbox";
            this.apptGroupbox.Size = new System.Drawing.Size(941, 330);
            this.apptGroupbox.TabIndex = 5;
            this.apptGroupbox.TabStop = false;
            this.apptGroupbox.Text = "Appointments";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Location = new System.Drawing.Point(328, 63);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(546, 249);
            this.dataGridView.TabIndex = 9;
            // 
            // monthViewRadio
            // 
            this.monthViewRadio.AutoSize = true;
            this.monthViewRadio.Checked = true;
            this.monthViewRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthViewRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.monthViewRadio.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.monthViewRadio.Location = new System.Drawing.Point(615, 38);
            this.monthViewRadio.Name = "monthViewRadio";
            this.monthViewRadio.Size = new System.Drawing.Size(98, 21);
            this.monthViewRadio.TabIndex = 8;
            this.monthViewRadio.TabStop = true;
            this.monthViewRadio.Text = "Month View";
            this.monthViewRadio.UseVisualStyleBackColor = true;
            // 
            // weekViewRadio
            // 
            this.weekViewRadio.AutoSize = true;
            this.weekViewRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.weekViewRadio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.weekViewRadio.FlatAppearance.CheckedBackColor = System.Drawing.Color.Yellow;
            this.weekViewRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.weekViewRadio.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.weekViewRadio.Location = new System.Drawing.Point(489, 38);
            this.weekViewRadio.Name = "weekViewRadio";
            this.weekViewRadio.Size = new System.Drawing.Size(95, 21);
            this.weekViewRadio.TabIndex = 7;
            this.weekViewRadio.Text = "Week View";
            this.weekViewRadio.UseVisualStyleBackColor = true;
            this.weekViewRadio.CheckedChanged += new System.EventHandler(this.WeekViewRadio_CheckedChanged);
            // 
            // deleteApptButton
            // 
            this.deleteApptButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.deleteApptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteApptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteApptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.deleteApptButton.ForeColor = System.Drawing.SystemColors.Control;
            this.deleteApptButton.Location = new System.Drawing.Point(128, 160);
            this.deleteApptButton.Name = "deleteApptButton";
            this.deleteApptButton.Size = new System.Drawing.Size(96, 31);
            this.deleteApptButton.TabIndex = 5;
            this.deleteApptButton.Text = "Delete";
            this.deleteApptButton.UseVisualStyleBackColor = false;
            this.deleteApptButton.Click += new System.EventHandler(this.DeleteApptButton_Click);
            // 
            // updateApptButton
            // 
            this.updateApptButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.updateApptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateApptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateApptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.updateApptButton.ForeColor = System.Drawing.SystemColors.Control;
            this.updateApptButton.Location = new System.Drawing.Point(128, 109);
            this.updateApptButton.Name = "updateApptButton";
            this.updateApptButton.Size = new System.Drawing.Size(96, 31);
            this.updateApptButton.TabIndex = 4;
            this.updateApptButton.Text = "Update";
            this.updateApptButton.UseVisualStyleBackColor = false;
            this.updateApptButton.Click += new System.EventHandler(this.UpdateApptButton_Click);
            // 
            // addApptButton
            // 
            this.addApptButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.addApptButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addApptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addApptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.addApptButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addApptButton.Location = new System.Drawing.Point(128, 58);
            this.addApptButton.Name = "addApptButton";
            this.addApptButton.Size = new System.Drawing.Size(96, 31);
            this.addApptButton.TabIndex = 3;
            this.addApptButton.Text = "Add";
            this.addApptButton.UseVisualStyleBackColor = false;
            this.addApptButton.Click += new System.EventHandler(this.AddApptButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(965, 525);
            this.Controls.Add(this.dashLabel);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.dashLabel.ResumeLayout(false);
            this.reportsGroupbox.ResumeLayout(false);
            this.custGroupbox.ResumeLayout(false);
            this.apptGroupbox.ResumeLayout(false);
            this.apptGroupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.GroupBox dashLabel;
        private System.Windows.Forms.GroupBox reportsGroupbox;
        private System.Windows.Forms.Button loginsReportButton;
        private System.Windows.Forms.Button schedButton;
        private System.Windows.Forms.Button numApptButton;
        private System.Windows.Forms.GroupBox custGroupbox;
        private System.Windows.Forms.Button deleteCusButton;
        private System.Windows.Forms.Button updateCusButton;
        private System.Windows.Forms.Button createCusButton;
        private System.Windows.Forms.GroupBox apptGroupbox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.RadioButton monthViewRadio;
        private System.Windows.Forms.RadioButton weekViewRadio;
        private System.Windows.Forms.Button deleteApptButton;
        private System.Windows.Forms.Button updateApptButton;
        private System.Windows.Forms.Button addApptButton;
    }
}