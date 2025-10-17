using project_windows_form2.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_windows_form2.Dashbords
{
	public partial class Dashbord : Form
	{
		public Dashbord()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{






		}

		private void basketToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_Order form_Order = new Form_Order();
			form_Order.ShowDialog();
		}

		private void sellerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_Order seller = new Form_Order();
		    seller.ShowDialog();





		}
	}
}
