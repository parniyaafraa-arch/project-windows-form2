using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseBackend.classes;

namespace BaseBackend.Services
{
	public class UserService
	{
		List<Buyer> buyers=new List<Buyer>();
		public void Add(Buyer buyer)
		{

			buyers.Add(buyer);

		}
		public List<Buyer> GetBuyers()
		{

			return buyers;
		}


	}
}
