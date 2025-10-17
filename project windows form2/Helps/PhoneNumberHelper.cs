using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_windows_form2.Helps
{
	internal class PhoneNumberHelper
	{
		public static bool IsValidPhoneNumber(string phoneNumber)
		{
			if (!string.IsNullOrEmpty(phoneNumber))

			{

				return true;


			}
			else
			{

				return false;
			}


		}
	

	}
}
