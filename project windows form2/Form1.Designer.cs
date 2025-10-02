namespace project_windows_form2
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
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
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
			label3.Size = new Size(109, 20);
			label3.TabIndex = 2;
			label3.Text = "phone Number";
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
			button1.Location = new Point(116, 227);
			button1.Name = "button1";
			button1.Size = new Size(129, 36);
			button1.TabIndex = 4;
			button1.Text = "Login";
			button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(255, 128, 128);
			button2.Location = new Point(116, 279);
			button2.Name = "button2";
			button2.Size = new Size(129, 34);
			button2.TabIndex = 5;
			button2.Text = "Departure";
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
			// textBox1
			// 
			textBox1.Location = new Point(118, 21);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(203, 27);
			textBox1.TabIndex = 7;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(117, 61);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(203, 27);
			textBox2.TabIndex = 8;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(118, 99);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(202, 27);
			textBox3.TabIndex = 9;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(118, 139);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(203, 27);
			textBox4.TabIndex = 10;
			// 
			// linkLabel2
			// 
			linkLabel2.AutoSize = true;
			linkLabel2.Location = new Point(153, 183);
			linkLabel2.Name = "linkLabel2";
			linkLabel2.Size = new Size(103, 20);
			linkLabel2.TabIndex = 11;
			linkLabel2.TabStop = true;
			linkLabel2.Text = "Create Acount";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(373, 378);
			Controls.Add(linkLabel2);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
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
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private TextBox textBox4;
		private LinkLabel linkLabel2;
	}
}
