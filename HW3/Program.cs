using System;
using System.Collections.Generic;
using System.Linq;

namespace HW3
{
	class Program
	{
		static void Main()
		{
			Random rand = new();
			List<int> list = new();

			for (int i = 0; i < 10; i++)
			{
				list.Add(rand.Next(50, 300));
			}


			int min = list.OrderBy(x => x).First();

			int max = list.OrderBy(x => x).Last();

			var ordered = list.OrderBy(x => x);
			foreach (int nums in ordered)
			{
				Console.WriteLine($"{nums} ");
			}

			Console.WriteLine($"\nМинимальный элемент {min} ");
			Console.WriteLine($"Максимальный элемент {max} ");
		}

	}
}