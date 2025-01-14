﻿
namespace AppLourde
{
    partial class ServiceCommercial
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonStats = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ordersCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summOrdersAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageOrderAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.usernameUpdateLabel = new System.Windows.Forms.Label();
            this.saveUsernameButton = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.usernameEditBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.buttonProfile);
            this.panel1.Controls.Add(this.buttonStats);
            this.panel1.Controls.Add(this.buttonClients);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 81);
            this.panel1.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Black;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(1061, 13);
            this.exitButton.Name = "exitButton";
            this.exitButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.Black;
            this.buttonProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonProfile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonProfile.Location = new System.Drawing.Point(836, 24);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(6);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(154, 44);
            this.buttonProfile.TabIndex = 5;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonStats
            // 
            this.buttonStats.BackColor = System.Drawing.Color.Black;
            this.buttonStats.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonStats.FlatAppearance.BorderSize = 0;
            this.buttonStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStats.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStats.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonStats.Location = new System.Drawing.Point(609, 16);
            this.buttonStats.Margin = new System.Windows.Forms.Padding(6);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.Size = new System.Drawing.Size(215, 60);
            this.buttonStats.TabIndex = 4;
            this.buttonStats.Text = "Stats";
            this.buttonStats.UseVisualStyleBackColor = false;
            this.buttonStats.Click += new System.EventHandler(this.buttonStats_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.BackColor = System.Drawing.Color.Black;
            this.buttonClients.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClients.FlatAppearance.BorderSize = 0;
            this.buttonClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClients.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonClients.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonClients.Location = new System.Drawing.Point(382, 16);
            this.buttonClients.Margin = new System.Windows.Forms.Padding(6);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(215, 60);
            this.buttonClients.TabIndex = 3;
            this.buttonClients.Text = "Clients";
            this.buttonClients.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Service Commercial";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelProfile
            // 
            this.panelProfile.BackColor = System.Drawing.Color.DimGray;
            this.panelProfile.Controls.Add(this.label6);
            this.panelProfile.Controls.Add(this.label5);
            this.panelProfile.Controls.Add(this.button3);
            this.panelProfile.Controls.Add(this.button2);
            this.panelProfile.Controls.Add(this.dataGridView1);
            this.panelProfile.Controls.Add(this.label4);
            this.panelProfile.Controls.Add(this.usernameUpdateLabel);
            this.panelProfile.Controls.Add(this.saveUsernameButton);
            this.panelProfile.Controls.Add(this.labelUsername);
            this.panelProfile.Controls.Add(this.textBox3);
            this.panelProfile.Controls.Add(this.textBox2);
            this.panelProfile.Controls.Add(this.usernameEditBox);
            this.panelProfile.Location = new System.Drawing.Point(-1, 89);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(1152, 423);
            this.panelProfile.TabIndex = 2;
            this.panelProfile.Paint += new System.Windows.Forms.PaintEventHandler(this.panelProfile_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordersCount,
            this.summOrdersAmount,
            this.AverageOrderAmount});
            this.dataGridView1.Location = new System.Drawing.Point(464, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(347, 86);
            this.dataGridView1.TabIndex = 8;
            // 
            // ordersCount
            // 
            this.ordersCount.HeaderText = "Number of Orders";
            this.ordersCount.Name = "ordersCount";
            // 
            // summOrdersAmount
            // 
            this.summOrdersAmount.HeaderText = "Summ of all Orders";
            this.summOrdersAmount.Name = "summOrdersAmount";
            // 
            // AverageOrderAmount
            // 
            this.AverageOrderAmount.HeaderText = "Average Amount of Order";
            this.AverageOrderAmount.Name = "AverageOrderAmount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(312, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stats";
            // 
            // usernameUpdateLabel
            // 
            this.usernameUpdateLabel.AutoSize = true;
            this.usernameUpdateLabel.ForeColor = System.Drawing.Color.Black;
            this.usernameUpdateLabel.Location = new System.Drawing.Point(989, 56);
            this.usernameUpdateLabel.Name = "usernameUpdateLabel";
            this.usernameUpdateLabel.Size = new System.Drawing.Size(114, 15);
            this.usernameUpdateLabel.TabIndex = 6;
            this.usernameUpdateLabel.Text = "Username Updated !";
            this.usernameUpdateLabel.Visible = false;
            // 
            // saveUsernameButton
            // 
            this.saveUsernameButton.Location = new System.Drawing.Point(890, 53);
            this.saveUsernameButton.Name = "saveUsernameButton";
            this.saveUsernameButton.Size = new System.Drawing.Size(71, 20);
            this.saveUsernameButton.TabIndex = 5;
            this.saveUsernameButton.Text = "Save";
            this.saveUsernameButton.UseVisualStyleBackColor = true;
            this.saveUsernameButton.Click += new System.EventHandler(this.saveUsernameButton_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.Location = new System.Drawing.Point(312, 52);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(87, 21);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "Username";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(414, 133);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "Enter New Email";
            this.textBox3.Size = new System.Drawing.Size(448, 23);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(414, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Enter New Password";
            this.textBox2.Size = new System.Drawing.Size(448, 23);
            this.textBox2.TabIndex = 1;
            // 
            // usernameEditBox
            // 
            this.usernameEditBox.Location = new System.Drawing.Point(414, 52);
            this.usernameEditBox.Name = "usernameEditBox";
            this.usernameEditBox.PlaceholderText = "Enter New Username";
            this.usernameEditBox.Size = new System.Drawing.Size(448, 23);
            this.usernameEditBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(989, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Username Updated !";
            this.label2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(890, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 20);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(312, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(414, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(448, 23);
            this.textBox1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(890, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 20);
            this.button2.TabIndex = 9;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(890, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 20);
            this.button3.TabIndex = 10;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(312, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(312, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Email";
            // 
            // ServiceCommercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1147, 504);
            this.Controls.Add(this.panelProfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ServiceCommercial";
            this.Text = "ServiceCommercial";
            this.panel1.ResumeLayout(false);
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLogs;
        private System.Windows.Forms.Button buttonStats;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox usernameEditBox;
        private System.Windows.Forms.Button saveUsernameButton;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label usernameUpdateLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordersCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn summOrdersAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageOrderAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}