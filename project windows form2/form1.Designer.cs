﻿namespace project_windows_form2
{
    partial class Form1
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			button1 = new Button();
			button2 = new Button();
			linkLabel1 = new LinkLabel();
			UserNameTextBox = new TextBox();
			passwordTextBox = new TextBox();
			phonenumberTextBox = new TextBox();
			EmaliTextBox = new TextBox();
			linkLabel2 = new LinkLabel();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 28);
			label1.Name = "label1";
			label1.Size = new Size(82, 20);
			label1.TabIndex = 0;
			label1.Text = "User Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(22, 64);
			label2.Name = "label2";
			label2.Size = new Size(72, 20);
			label2.TabIndex = 1;
			label2.Text = "password";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(3, 102);
			label3.Name = "label3";
			label3.Size = new Size(108, 20);
			label3.TabIndex = 2;
			label3.Text = "Phone Number";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(35, 142);
			label4.Name = "label4";
			label4.Size = new Size(46, 20);
			label4.TabIndex = 3;
			label4.Text = "Email";
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(128, 255, 255);
			button1.Location = new Point(153, 232);
			button1.Name = "button1";
			button1.Size = new Size(129, 36);
			button1.TabIndex = 4;
			button1.Text = "Login";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(255, 128, 128);
			button2.Location = new Point(153, 283);
			button2.Name = "button2";
			button2.Size = new Size(129, 34);
			button2.TabIndex = 5;
			button2.Text = "Reset";
			button2.UseVisualStyleBackColor = false;
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Location = new Point(169, 181);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(0, 20);
			linkLabel1.TabIndex = 6;
			// 
			// UserNameTextBox
			// 
			UserNameTextBox.Location = new Point(118, 21);
			UserNameTextBox.Name = "UserNameTextBox";
			UserNameTextBox.Size = new Size(255, 27);
			UserNameTextBox.TabIndex = 7;
			UserNameTextBox.TextChanged += UserNameTextBox_TextChanged;
			// 
			// passwordTextBox
			// 
			passwordTextBox.Location = new Point(118, 61);
			passwordTextBox.Name = "passwordTextBox";
			passwordTextBox.Size = new Size(255, 27);
			passwordTextBox.TabIndex = 8;
			passwordTextBox.TextChanged += passwordTextBox_TextChanged;
			// 
			// phonenumberTextBox
			// 
			phonenumberTextBox.Location = new Point(118, 99);
			phonenumberTextBox.Name = "phonenumberTextBox";
			phonenumberTextBox.Size = new Size(255, 27);
			phonenumberTextBox.TabIndex = 9;
			// 
			// EmaliTextBox
			// 
			EmaliTextBox.Location = new Point(118, 142);
			EmaliTextBox.Name = "EmaliTextBox";
			EmaliTextBox.Size = new Size(255, 27);
			EmaliTextBox.TabIndex = 10;
			EmaliTextBox.TextChanged += EmaliTextBox_TextChanged;
			// 
			// linkLabel2
			// 
			linkLabel2.AutoSize = true;
			linkLabel2.Location = new Point(191, 181);
			linkLabel2.Name = "linkLabel2";
			linkLabel2.Size = new Size(103, 20);
			linkLabel2.TabIndex = 11;
			linkLabel2.TabStop = true;
			linkLabel2.Text = "Create Acount";
			linkLabel2.LinkClicked += linkLabel2_LinkClicked;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(412, 343);
			Controls.Add(linkLabel2);
			Controls.Add(EmaliTextBox);
			Controls.Add(phonenumberTextBox);
			Controls.Add(passwordTextBox);
			Controls.Add(UserNameTextBox);
			Controls.Add(linkLabel1);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Button button1;
		private Button button2;
		private LinkLabel linkLabel1;
		private TextBox UserNameTextBox;
		private TextBox passwordTextBox;
		private TextBox phonenumberTextBox;
		private TextBox EmaliTextBox;
		private LinkLabel linkLabel2;
	}
}
