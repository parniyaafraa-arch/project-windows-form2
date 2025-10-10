namespace project_windows_form2.sellers
{
	partial class Form_seller
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			PhoneNumber = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			textBox4 = new TextBox();
			label5 = new Label();
			dateTimePicker1 = new DateTimePicker();
			label4 = new Label();
			textBox3 = new TextBox();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			linkLabel1 = new LinkLabel();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(46, 31);
			label1.Name = "label1";
			label1.Size = new Size(49, 20);
			label1.TabIndex = 0;
			label1.Text = "Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(46, 79);
			label2.Name = "label2";
			label2.Size = new Size(0, 20);
			label2.TabIndex = 1;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(59, 126);
			label3.Name = "label3";
			label3.Size = new Size(36, 20);
			label3.TabIndex = 2;
			label3.Text = "Age";
			// 
			// PhoneNumber
			// 
			PhoneNumber.AutoSize = true;
			PhoneNumber.Location = new Point(27, 170);
			PhoneNumber.Name = "PhoneNumber";
			PhoneNumber.Size = new Size(101, 20);
			PhoneNumber.TabIndex = 3;
			PhoneNumber.Text = "Phonenumber";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(153, 24);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(241, 27);
			textBox1.TabIndex = 4;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(153, 72);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(241, 27);
			textBox2.TabIndex = 5;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(153, 170);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(241, 27);
			textBox4.TabIndex = 7;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(44, 75);
			label5.Name = "label5";
			label5.Size = new Size(75, 20);
			label5.TabIndex = 8;
			label5.Text = "LastName";
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(153, 121);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(241, 27);
			dateTimePicker1.TabIndex = 9;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(38, 218);
			label4.Name = "label4";
			label4.Size = new Size(90, 20);
			label4.TabIndex = 10;
			label4.Text = "WorkHistory";
			// 
			// textBox3
			// 
			textBox3.Location = new Point(153, 211);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(241, 27);
			textBox3.TabIndex = 11;
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(128, 255, 255);
			button1.Location = new Point(175, 251);
			button1.Name = "button1";
			button1.Size = new Size(95, 31);
			button1.TabIndex = 12;
			button1.Text = "Registration";
			button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(192, 192, 255);
			button2.Location = new Point(175, 304);
			button2.Name = "button2";
			button2.Size = new Size(95, 29);
			button2.TabIndex = 13;
			button2.Text = "Reset";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.BackColor = Color.FromArgb(255, 192, 192);
			button3.Location = new Point(175, 350);
			button3.Name = "button3";
			button3.Size = new Size(93, 30);
			button3.TabIndex = 14;
			button3.Text = "Departure";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// linkLabel1
			// 
			linkLabel1.AutoSize = true;
			linkLabel1.Location = new Point(289, 250);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(103, 20);
			linkLabel1.TabIndex = 15;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Create Acount";
			// 
			// Form_seller
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(452, 392);
			Controls.Add(linkLabel1);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox3);
			Controls.Add(label4);
			Controls.Add(dateTimePicker1);
			Controls.Add(label5);
			Controls.Add(textBox4);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(PhoneNumber);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form_seller";
			Text = "Form_seller";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label PhoneNumber;
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox4;
		private Label label5;
		private DateTimePicker dateTimePicker1;
		private Label label4;
		private TextBox textBox3;
		private Button button1;
		private Button button2;
		private Button button3;
		private LinkLabel linkLabel1;
	}
}