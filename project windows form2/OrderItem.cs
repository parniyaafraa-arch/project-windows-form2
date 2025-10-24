using project_windows_form2.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_windows_form2
{
	public class OrderItem
	{
		public Product product {  get; set; }

		public decimal price { get; set; }
		public int Count { get; set; }

	}
}
