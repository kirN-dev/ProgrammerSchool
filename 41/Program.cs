using System;

namespace _41
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] temperatures = { 9, -20, 14 };

			int[] sort = Sort(temperatures);

			foreach (var temperature in temperatures)
			{
				Console.Write("{0} ", temperature);
			}
		}

		private static int[] Sort(int[] temperatures)
		{
			for (int j = 0; j < temperatures.Length; j++)
			{
				for (int i = 0; i < temperatures.Length - 1; i++)
				{
					if (temperatures[i] > temperatures[i + 1])
					{
						int buffer = temperatures[i];
						temperatures[i] = temperatures[i + 1];
						temperatures[i + 1] = buffer;
					}
				}
			}

			return temperatures;
		}
	}
}
