using BaseBackend.classes;
using BaseBackend.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBackend.Interface;
namespace BaseBackend.ProductServices;

public class ProductService: iBaseService<Product>
{
	List<Product> products = new List<Product>();
	public void Add(Product product)
	{
		products.Add(product);
	}
	public List<Product> GetAll() { return products; }



}
