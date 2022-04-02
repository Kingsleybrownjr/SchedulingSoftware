
namespace C969_SoftwareII
{
    partial class Login
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
            this.infoLabel = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.passTextbox = new System.Windows.Forms.TextBox();
            this.userTextbox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.infoLabel.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.Controls.Add(this.cancelButton);
            this.infoLabel.Controls.Add(this.loginButton);
            this.infoLabel.Controls.Add(this.passTextbox);
            this.infoLabel.Controls.Add(this.userTextbox);
            this.infoLabel.Controls.Add(this.passwordLabel);
            this.infoLabel.Controls.Add(this.usernameLabel);
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.infoLabel.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.infoLabel.Location = new System.Drawing.Point(12, 12);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(367, 222);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.TabStop = false;
            this.infoLabel.Text = "Enter Login Information";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cancelButton.ForeColor = System.Drawing.SystemColors.Control;
            this.cancelButton.Location = new System.Drawing.Point(215, 176);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.loginButton.ForeColor = System.Drawing.SystemColors.Control;
            this.loginButton.Location = new System.Drawing.Point(80, 176);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 11;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click_1);
            // 
            // passTextbox
            // 
            this.passTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.passTextbox.Location = new System.Drawing.Point(164, 112);
            this.passTextbox.Name = "passTextbox";
            this.passTextbox.PasswordChar = '•';
            this.passTextbox.Size = new System.Drawing.Size(126, 21);
            this.passTextbox.TabIndex = 10;
            // 
            // userTextbox
            // 
            this.userTextbox.BackColor = System.Drawing.Color.White;
            this.userTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.userTextbox.Location = new System.Drawing.Point(164, 65);
            this.userTextbox.Name = "userTextbox";
            this.userTextbox.Size = new System.Drawing.Size(126, 21);
            this.userTextbox.TabIndex = 9;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.passwordLabel.Location = new System.Drawing.Point(77, 115);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(64, 15);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.usernameLabel.Location = new System.Drawing.Point(77, 65);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(68, 15);
            this.usernameLabel.TabIndex = 7;
            this.usernameLabel.Text = "Username:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(391, 246);
            this.Controls.Add(this.infoLabel);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.infoLabel.ResumeLayout(false);
            this.infoLabel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox infoLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passTextbox;
        private System.Windows.Forms.TextBox userTextbox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
    }
}

