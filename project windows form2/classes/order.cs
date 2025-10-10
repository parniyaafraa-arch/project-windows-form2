using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_windows_form2.classes
{
	internal class order:BaseEntity
	{
		
		public int Numberproduct { get; set; }
		public Buyer Address { get; set; }
		public DateTime ProductArrivalTime { get; set; }

		public string Transportation { get; set; }

	}
}
