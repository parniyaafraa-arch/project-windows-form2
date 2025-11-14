using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBackend.classes;

namespace BaseBackend.SellerServices
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
