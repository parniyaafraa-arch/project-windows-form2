namespace project_windows_form2
{
	partial class create_acount
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
			label4 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			button1 = new Button();
			button2 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(16, 31);
			label1.Name = "label1";
			label1.Size = new Size(82, 20);
			label1.TabIndex = 0;
			label1.Text = "User Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(28, 71);
			label2.Name = "label2";
			label2.Size = new Size(70, 20);
			label2.TabIndex = 1;
			label2.Text = "Password";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(3, 113);
			label3.Name = "label3";
			label3.Size = new Size(127, 20);
			label3.TabIndex = 2;
			label3.Text = "Confirm Password";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(28, 150);
			label4.Name = "label4";
			label4.Size = new Size(46, 20);
			label4.TabIndex = 3;
			label4.Text = "Emali";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(136, 24);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(174, 27);
			textBox1.TabIndex = 4;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(136, 71);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(174, 27);
			textBox2.TabIndex = 5;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(136, 110);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(174, 27);
			textBox3.TabIndex = 6;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(136, 150);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(174, 27);
			textBox4.TabIndex = 7;
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(128, 255, 255);
			button1.Location = new Point(109, 213);
			button1.Name = "button1";
			button1.Size = new Size(99, 35);
			button1.TabIndex = 8;
			button1.Text = "Rigester";
			button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(255, 128, 128);
			button2.Location = new Point(109, 262);
			button2.Name = "button2";
			button2.Size = new Size(99, 32);
			button2.TabIndex = 9;
			button2.Text = "Cancel";
			button2.UseVisualStyleBackColor = false;
			// 
			// create_acount
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(334, 345);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "create_acount";
			Text = "create_acount";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private TextBox textBox4;
		private Button button1;
		private Button button2;
	}
}