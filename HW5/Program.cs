using System;
using System.Collections.Generic;
using System.Linq;

namespace HW5
{
	class Program
	{
		static void Main()
		{
			Random rand = new();
			List<int> list = new();

			for (int i = 0; i < 50; i++)
			{
				list.Add(rand.Next(0, 26));
			}

			Console.WriteLine($"Генератор 50 чисел от 0 до 25: ");
			var ordered = list.OrderBy(x => x);
			foreach (int nums in ordered)
			{
				Console.Write($"{nums} ");
			}

			Console.WriteLine($"\n\nЧисла от 10 до 20 (без повторения) в порядке убывания: ");
			var sorted = list.Distinct().Where(x => ((x >= 10) && (x <= 20))).OrderByDescending(x => x); 
			foreach (int nums in sorted)
			{
				Console.WriteLine($"{nums} ");
			}
		}

	}
}