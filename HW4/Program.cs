using System;
using System.Collections.Generic;
using System.Linq;

namespace HW4
{
	class Program
	{
		static void Main()
		{
			Random rand = new();
			List<int> list = new();

			for (int i = 0; i < 10; i++)
			{
				list.Add(rand.Next(1, 10));
			}

			var ordered = list.OrderBy(x => x);
			foreach (int nums in ordered)
			{
				Console.WriteLine($"{nums} ");
			}
			Console.WriteLine($"\nРазных чисел {ordered.Distinct().Count()} ");
		}

	}
}