
namespace C969_SoftwareII
{
    partial class Schedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.scheduleLabel = new System.Windows.Forms.GroupBox();
            this.backButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.consultantComboBox = new System.Windows.Forms.ComboBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.scheduleLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // scheduleLabel
            // 
            this.scheduleLabel.Controls.Add(this.backButton);
            this.scheduleLabel.Controls.Add(this.reportButton);
            this.scheduleLabel.Controls.Add(this.consultantComboBox);
            this.scheduleLabel.Controls.Add(this.userLabel);
            this.scheduleLabel.Controls.Add(this.dataGridView);
            this.scheduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.scheduleLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.scheduleLabel.Location = new System.Drawing.Point(12, 12);
            this.scheduleLabel.Name = "scheduleLabel";
            this.scheduleLabel.Size = new System.Drawing.Size(1011, 603);
            this.scheduleLabel.TabIndex = 0;
            this.scheduleLabel.TabStop = false;
            this.scheduleLabel.Text = "Schedule";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.backButton.ForeColor = System.Drawing.SystemColors.Control;
            this.backButton.Location = new System.Drawing.Point(644, 63);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(96, 31);
            this.backButton.TabIndex = 21;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.reportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.reportButton.ForeColor = System.Drawing.SystemColors.Control;
            this.reportButton.Location = new System.Drawing.Point(529, 63);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(96, 31);
            this.reportButton.TabIndex = 20;
            this.reportButton.Text = "Generate Report";
            this.reportButton.UseVisualStyleBackColor = false;
            this.reportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // consultantComboBox
            // 
            this.consultantComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.consultantComboBox.FormattingEnabled = true;
            this.consultantComboBox.Location = new System.Drawing.Point(297, 69);
            this.consultantComboBox.Name = "consultantComboBox";
            this.consultantComboBox.Size = new System.Drawing.Size(171, 23);
            this.consultantComboBox.TabIndex = 19;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.userLabel.Location = new System.Drawing.Point(201, 71);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(90, 17);
            this.userLabel.TabIndex = 18;
            this.userLabel.Text = "Consultants: ";
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(17, 100);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(976, 504);
            this.dataGridView.TabIndex = 16;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 627);
            this.Controls.Add(this.scheduleLabel);
            this.Name = "Schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.Schedule_Load);
            this.scheduleLabel.ResumeLayout(false);
            this.scheduleLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox scheduleLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.ComboBox consultantComboBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}