using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBackend.classes;

public class OrderItem
{
	public OrderItem(string Name, decimal Price, int count)
	{
	
		price = Price;
		Count = count;
	}
	public Product product {  get; set; }

	public decimal price { get; set; }
	public int Count { get; set; }

}
