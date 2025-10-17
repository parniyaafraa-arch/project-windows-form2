namespace project_windows_form2.Dashbords
{
	partial class Dashbord
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
			components = new System.ComponentModel.Container();
			contextMenuStrip1 = new ContextMenuStrip(components);
			acToolStripMenuItem = new ToolStripMenuItem();
			ordersToolStripMenuItem = new ToolStripMenuItem();
			basketToolStripMenuItem = new ToolStripMenuItem();
			sellerToolStripMenuItem = new ToolStripMenuItem();
			contextMenuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			contextMenuStrip1.ImageScalingSize = new Size(20, 20);
			contextMenuStrip1.Items.AddRange(new ToolStripItem[] { acToolStripMenuItem, ordersToolStripMenuItem });
			contextMenuStrip1.Name = "contextMenuStrip1";
			contextMenuStrip1.Size = new Size(211, 80);
			// 
			// acToolStripMenuItem
			// 
			acToolStripMenuItem.Name = "acToolStripMenuItem";
			acToolStripMenuItem.Size = new Size(210, 24);
			acToolStripMenuItem.Text = "Acount";
			// 
			// ordersToolStripMenuItem
			// 
			ordersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { basketToolStripMenuItem, sellerToolStripMenuItem });
			ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
			ordersToolStripMenuItem.Size = new Size(210, 24);
			ordersToolStripMenuItem.Text = "Orders";
			// 
			// basketToolStripMenuItem
			// 
			basketToolStripMenuItem.Name = "basketToolStripMenuItem";
			basketToolStripMenuItem.Size = new Size(224, 26);
			basketToolStripMenuItem.Text = "Buyer";
			basketToolStripMenuItem.Click += basketToolStripMenuItem_Click;
			// 
			// sellerToolStripMenuItem
			// 
			sellerToolStripMenuItem.Name = "sellerToolStripMenuItem";
			sellerToolStripMenuItem.Size = new Size(224, 26);
			sellerToolStripMenuItem.Text = "Seller";
			sellerToolStripMenuItem.Click += sellerToolStripMenuItem_Click;
			// 
			// Dashbord
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Name = "Dashbord";
			Text = "Form1";
			Load += Form1_Load;
			contextMenuStrip1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem acToolStripMenuItem;
		private ToolStripMenuItem ordersToolStripMenuItem;
		private ToolStripMenuItem basketToolStripMenuItem;
		private ToolStripMenuItem sellerToolStripMenuItem;
	}
}