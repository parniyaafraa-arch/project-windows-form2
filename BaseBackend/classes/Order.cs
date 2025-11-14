using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBackend.classes;

public  class order:BaseEntity
{
	//composition wich Buyer and Seller
	public order():base() { }
	
	public List<OrderItem> OrderItems { get; set; }
	public List<Product> Products { get; set; }
	public int Numberproduct { get; set; }
	public Buyer Address { get; set; }
	public DateTime ProductArrivalTime { get; set; }

	public string Transportation { get; set; }

}
