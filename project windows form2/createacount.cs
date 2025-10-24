using project_windows_form2.classes;
using project_windows_form2.Helps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace project_windows_form2
{
	public partial class create_acount : Form
	{
		public create_acount()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string UserName = UserNameTextBox.Text;
			string PhoneNumber = phonenumberTextBox.Text;
			string ConfirmPassword = confirmpasswordTextBox.Text;
			string Email = EmaliTextBox.Text;
			classes.Buyer buyer = new classes.Buyer(email: EmaliTextBox.Text, password: phonenumberTextBox.Text);

			List<classes.Buyer> buyers = new List<classes.Buyer>();
			buyers.Add(buyer);
			PhoneNumberHelper.IsValidPhoneNumber(PhoneNumber);




		}

		private void phonenumberTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void EmaliTextBox_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
