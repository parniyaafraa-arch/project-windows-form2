using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseBackend.classes;

public class Convertjson
{
	public static void Buyerjson()
	{

		string jsonDataStrfilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "BuyerList");
		string jsonDataStr = File.ReadAllText(jsonDataStrfilePath);
		List<Buyer> BuyerLists = JsonConvert.DeserializeObject<List<Buyer>>(jsonDataStr);
		Console.WriteLine(jsonDataStr);



	}
	





}
