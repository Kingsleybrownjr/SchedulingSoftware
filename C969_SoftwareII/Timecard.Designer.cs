
namespace C969_SoftwareII
{
    partial class Timecard
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
            this.scheduleLabel = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.scheduleLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // scheduleLabel
            // 
            this.scheduleLabel.Controls.Add(this.dataGridView);
            this.scheduleLabel.Controls.Add(this.backButton);
            this.scheduleLabel.Controls.Add(this.reportButton);
            this.scheduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.scheduleLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.scheduleLabel.Location = new System.Drawing.Point(12, 12);
            this.scheduleLabel.Name = "scheduleLabel";
            this.scheduleLabel.Size = new System.Drawing.Size(582, 449);
            this.scheduleLabel.TabIndex = 0;
            this.scheduleLabel.TabStop = false;
            this.scheduleLabel.Text = "Print User Timecard";
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Location = new System.Drawing.Point(27, 107);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(523, 313);
            this.dataGridView.TabIndex = 60;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(301, 59);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(96, 31);
            this.backButton.TabIndex = 59;
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
            this.reportButton.ForeColor = System.Drawing.Color.White;
            this.reportButton.Location = new System.Drawing.Point(182, 59);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(96, 31);
            this.reportButton.TabIndex = 58;
            this.reportButton.Text = "Generate Report";
            this.reportButton.UseVisualStyleBackColor = false;
            this.reportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // Timecard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 473);
            this.Controls.Add(this.scheduleLabel);
            this.Name = "Timecard";
            this.Text = "Timecard";
            this.Load += new System.EventHandler(this.Timecard_Load);
            this.scheduleLabel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox scheduleLabel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button reportButton;
    }
}