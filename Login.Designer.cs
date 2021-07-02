
namespace AppLourde
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginButton = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.usrnLabel = new System.Windows.Forms.Label();
            this.pwLabel = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.reqStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(434, 242);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(331, 135);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(280, 23);
            this.textBoxUsername.TabIndex = 3;
            // 
            // usrnLabel
            // 
            this.usrnLabel.AutoSize = true;
            this.usrnLabel.Location = new System.Drawing.Point(252, 138);
            this.usrnLabel.Name = "usrnLabel";
            this.usrnLabel.Size = new System.Drawing.Size(60, 15);
            this.usrnLabel.TabIndex = 7;
            this.usrnLabel.Text = "Username";
            // 
            // pwLabel
            // 
            this.pwLabel.AutoSize = true;
            this.pwLabel.Location = new System.Drawing.Point(255, 186);
            this.pwLabel.Name = "pwLabel";
            this.pwLabel.Size = new System.Drawing.Size(57, 15);
            this.pwLabel.TabIndex = 8;
            this.pwLabel.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(331, 183);
            this.textBoxPassword.Multiline = true;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '●';
            this.textBoxPassword.Size = new System.Drawing.Size(280, 23);
            this.textBoxPassword.TabIndex = 13;
            // 
            // reqStatus
            // 
            this.reqStatus.AutoSize = true;
            this.reqStatus.Location = new System.Drawing.Point(451, 287);
            this.reqStatus.Name = "reqStatus";
            this.reqStatus.Size = new System.Drawing.Size(39, 15);
            this.reqStatus.TabIndex = 19;
            this.reqStatus.Text = "Status";
            this.reqStatus.Visible = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reqStatus);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.pwLabel);
            this.Controls.Add(this.usrnLabel);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.loginButton);
            this.Name = "LogIn";
            this.Text = "Ces\'Eat Management";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label usrnLabel;
        private System.Windows.Forms.Label pwLabel;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label reqStatus;
    }
}

