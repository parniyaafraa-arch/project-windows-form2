using project_windows_form2.classes;
using project_windows_form2.Services;

namespace project_windows_form2
{
	public partial class BuyerForm : Form
	{
		UserService userService;

		public BuyerForm()
		{
			InitializeComponent();
			userService=new UserService();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string UserName = UserNameTextBox.Text;
			string Password = passwordTextBox.Text;
			string PhoneNumber = phonenumberTextBox.Text;
			string Email = EmaliTextBox.Text;

			Buyer buyer = new Buyer(email: Email, password: Password);
			buyer.UserName = UserName;
			buyer.Password = Password;
			buyer.Phonenumber = PhoneNumber;
			buyer.Email = Email;
			userService.Add(buyer);


		}

		private void UserNameTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void passwordTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void EmaliTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			create_acount create_Acount = new create_acount();
			create_Acount.Show();




		}
	}
}
