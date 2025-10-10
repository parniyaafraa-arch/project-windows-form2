using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_windows_form2.enums;
namespace project_windows_form2.classes
{
	internal class Product:BaseEntity
	{
	
		public string Name { get; set; }
		public int Numberproduct { get; set; }
		public string Storageconditions { get; set; }
		public OrderStatus Status { get; set; }
		public Seller sellerid { get; set; }
	}
}
