using System;
using System.Collections.Generic;
using System.Linq;


namespace DistinctList
{
	class DistinctList
	{
		static void Main()

		{
			List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
			for (int i = 0; i < list.Count; i++)
			{
				for (int j = 0; j < list.Count; j++)
				{
					if (list[i] == list[j])
					{
						list.RemoveAt(i);
					}
				}
			}
			Console.WriteLine(string.Join(" ", list));
			//==========================================================


		}
	}
}
