namespace Genertic
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = new int[] { 10, 20, 30, 40 };
			Customloop(numbers);
			long[] numberLong = new long[] { 100, 200, 300, 400 };
			Customloop(numberLong);
			string[] strings = new string[] { "s", "a", "p", "sh" };
			Customloop(strings);


			void Customloop<T>(T[]numbers)
			{

				for (int i = 0; i < numbers.Length; i++)
				{
					{
						Console.WriteLine(numbers[i]);
					}

				}
			}

		}
	}
}
