using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_windows_form2.classes
{
	internal class Buyer:BaseEntity
	{
		




		public Buyer(string email,string password)
		{
			if(string.IsNullOrEmpty(email)||string.IsNullOrEmpty(password))
			{  throw new ArgumentNullException("email"); }	
	
			Email = email; 
			Password= password;


		}
	
		public string UserName { get; set; }

		public string Phonenumber { get; set; }
		public string Email { get; set; }
		public string Address { get; set; }
		public string ationalcode { get; set; }
		public string Password { get; set; }

	}
}
