using project_windows_form2.classes;
using project_windows_form2.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_windows_form2.Interface;
namespace project_windows_form2.ProductServices
{
	public class ProductService: BaseService<Product>
	{
		List<Product> products = new List<Product>();
		public void Add(Product product)
		{
			products.Add(product);
		}
		public List<Product> GetAll() { return products; }



	}
}
