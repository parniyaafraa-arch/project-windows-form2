namespace project_windows_form2.Orders
{
	partial class Form_Order
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
			textBox1 = new TextBox();
			label1 = new Label();
			label2 = new Label();
			comboBox1 = new ComboBox();
			label3 = new Label();
			numericUpDown1 = new NumericUpDown();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			textBox2 = new TextBox();
			label8 = new Label();
			button1 = new Button();
			dataGridView1 = new DataGridView();
			Name = new DataGridViewTextBoxColumn();
			Product = new DataGridViewTextBoxColumn();
			Quantity = new DataGridViewTextBoxColumn();
			Total = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(176, 63);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(231, 27);
			textBox1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(91, 66);
			label1.Name = "label1";
			label1.Size = new Size(49, 20);
			label1.TabIndex = 1;
			label1.Text = "Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(80, 119);
			label2.Name = "label2";
			label2.Size = new Size(60, 20);
			label2.TabIndex = 2;
			label2.Text = "Product";
			// 
			// comboBox1
			// 
			comboBox1.FormattingEnabled = true;
			comboBox1.Location = new Point(176, 121);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new Size(231, 28);
			comboBox1.TabIndex = 3;
			comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(80, 177);
			label3.Name = "label3";
			label3.Size = new Size(65, 20);
			label3.TabIndex = 4;
			label3.Text = "Quantity";
			// 
			// numericUpDown1
			// 
			numericUpDown1.Location = new Point(176, 175);
			numericUpDown1.Name = "numericUpDown1";
			numericUpDown1.Size = new Size(231, 27);
			numericUpDown1.TabIndex = 5;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(80, 228);
			label4.Name = "label4";
			label4.Size = new Size(72, 20);
			label4.TabIndex = 6;
			label4.Text = "Unit Price";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(42, 239);
			label5.Name = "label5";
			label5.Size = new Size(0, 20);
			label5.TabIndex = 7;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(42, 290);
			label6.Name = "label6";
			label6.Size = new Size(0, 20);
			label6.TabIndex = 8;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(42, 317);
			label7.Name = "label7";
			label7.Size = new Size(0, 20);
			label7.TabIndex = 9;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(176, 221);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(231, 27);
			textBox2.TabIndex = 10;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(129, 237);
			label8.Name = "label8";
			label8.Size = new Size(0, 20);
			label8.TabIndex = 11;
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(128, 255, 255);
			button1.Location = new Point(212, 286);
			button1.Name = "button1";
			button1.Size = new Size(155, 29);
			button1.TabIndex = 12;
			button1.Text = "Submit Order";
			button1.UseVisualStyleBackColor = false;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Product, Quantity, Total });
			dataGridView1.Location = new Point(22, 340);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(540, 98);
			dataGridView1.TabIndex = 13;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// Name
			// 
			Name.HeaderText = "Customer Name";
			Name.MinimumWidth = 6;
			Name.Name = "Name";
			Name.Width = 125;
			// 
			// Product
			// 
			Product.HeaderText = "Product";
			Product.MinimumWidth = 6;
			Product.Name = "Product";
			Product.Width = 125;
			// 
			// Quantity
			// 
			Quantity.HeaderText = "Quantity";
			Quantity.MinimumWidth = 6;
			Quantity.Name = "Quantity";
			Quantity.Width = 125;
			// 
			// Total
			// 
			Total.HeaderText = "Total";
			Total.MinimumWidth = 6;
			Total.Name = "Total";
			Total.Width = 125;
			// 
			// Form_Order
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(592, 503);
			Controls.Add(dataGridView1);
			Controls.Add(button1);
			Controls.Add(label8);
			Controls.Add(textBox2);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(numericUpDown1);
			Controls.Add(label3);
			Controls.Add(comboBox1);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBox1);
			Name = "Form_Order";
			Text = "Form_Order";
			Load += Form_Order_Load;
			((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private Label label1;
		private Label label2;
		private ComboBox comboBox1;
		private Label label3;
		private NumericUpDown numericUpDown1;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private TextBox textBox2;
		private Label label8;
		private Button button1;
		private DataGridView dataGridView1;
		private DataGridViewTextBoxColumn Name;
		private DataGridViewTextBoxColumn Product;
		private DataGridViewTextBoxColumn Quantity;
		private DataGridViewTextBoxColumn Total;
	}
}