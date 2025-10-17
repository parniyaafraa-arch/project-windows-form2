using project_windows_form2.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_windows_form2.Orders
{
	public partial class Form_Order : Form
	{
		List<Product> products;
		public Form_Order()
		{
			InitializeComponent();
			products = new List<Product>();
		
		}

		private void Form_Order_Load(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{








		}

		private void button1_Click(object sender, EventArgs e)
		{
			string Name = NameTextBox.Text;
			string Product = productcomboBox.Text;
			string Quantity = QuantitynumericUpDown.Text;
			string UnitPrice = UnitPricetextBox.Text;
			Product product = new Product();

			products.Add(product);
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = products;
			dataGridView1.Refresh();
		}

		private void NameTextBox_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
