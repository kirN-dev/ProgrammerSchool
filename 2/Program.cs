using System;

namespace _2
{
	class Program
	{
		//Требуется посчитать сумму целых чисел, расположенных между числами 1 и N включительно.

		//Входные данные
		//В единственной строке входного файла INPUT.TXT записано единственное целое число N, не превышающее по абсолютной величине 104.

		//Выходные данные
		//В единственную строку выходного файла OUTPUT.TXT нужно вывести одно целое число — сумму чисел, расположенных между 1 и N включительно.
		
		static void Main(string[] args)
		{
			int limit = int.Parse(Console.ReadLine());
			int sum = SumLimit(limit);
			Console.WriteLine(sum.ToString());
		}

		private static int SumLimit(int limit)
		{
			int sum = 0;
			for (int i = 1; i <= limit; i++)
			{
				sum += i;
			}

			return sum;
		}
	}
}
