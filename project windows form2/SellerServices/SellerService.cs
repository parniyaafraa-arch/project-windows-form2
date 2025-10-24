using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_windows_form2.classes;

namespace project_windows_form2.SellerServices
{
	internal class SellerService
	{
		List<Seller> lists=new List<Seller>();
		public void Add(Seller seller)
		{

			lists.Add(seller);	
		}

		public List<Seller> GetList() {return lists;}




	}
}
