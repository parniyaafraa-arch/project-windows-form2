using System.Runtime.CompilerServices;

namespace FileHanding
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string file = @" C:\Users\110\source\repos\project windows form2\FileHanding\info.txt";
			if (File.Exists(file))
			{
				string str = File.ReadAllText(file);
				Console.WriteLine(str);
			}
			if (File.Exists(file))
			{
				string[] lines = File.ReadAllLines(file);
				foreach (string line in lines)
				{
					Console.WriteLine(lines);

				}

			}



			if (File.Exists(file))
			{
				StreamReader Textfile = new StreamReader(file);
				string line;
				while ((line = Textfile.ReadLine()) != null)
				{

					Console.WriteLine(line);
				}
				Textfile.Close();

				Console.WriteLine();

			}



			string PathFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Files", "info.txt");
			if (File.Exists(PathFile))
			{
				string str = File.ReadAllText(PathFile);
				Console.WriteLine(str);
			}
			if (File.Exists(PathFile))

			{

				File.AppendAllText(path: PathFile, contents: "write from c#");

			}
			
		}
	}

}
