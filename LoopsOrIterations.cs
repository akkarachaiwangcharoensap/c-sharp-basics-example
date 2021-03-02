using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_example
{
    class LoopsOrIterations
    {
		public static void RunExample ()
		{
			// 1D loop / iteration | performance: O(n^1)
			for (int i = 0; i < 10; i = i + 1)
			{
				Console.WriteLine(i);
			}

			Console.WriteLine("=======================================");

			// 2D loop / iteration | performance: O(n^2)
			for (int x = 0; x < 10; x++)
			{
				for (int y = 0; y < 10; y++)
				{
					Console.WriteLine("x: " + x + " " + "y: " + y);
				}
			}

			Console.WriteLine("=======================================");

			// 3D loop / iteration | performance: O(n^3)
			for (int x = 0; x < 10; x++)
			{
				for (int y = 0; y < 10; y++)
				{
					for (int z = 0; z < 10; z++)
					{
						Console.WriteLine("x: " + x + " " + "y: " + y + " " + "z: " + z);
					}
				}
			}
		}
	}
}
