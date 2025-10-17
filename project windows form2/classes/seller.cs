using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_windows_form2.classes
{
	internal class Seller:BaseEntity
	{
		
		public int Age { get; set; }
		public string Name { get; set; }
		public string Lastname { get; set; }
		public string Workhistory { get; set; }
		public string PhoneNumber {  get; set; }

		public int sellerid { get; set; }
	}
}
