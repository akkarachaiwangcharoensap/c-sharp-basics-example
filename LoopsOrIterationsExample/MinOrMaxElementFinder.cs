using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_example.LoopsOrIterationsExample
{
    class MinOrMaxElementFinder
    {
        public static void RunExample ()
        {
			int[] listOfIntegers = new int[] { 2, 4, 125, -12602, 123123, 12610312, -123, 12412, 5, 2521 };

			// Find the smallest integer
			int smallest = listOfIntegers[0]; // Assume, the smallest integer is the first element.
			for (int i = 1; i < listOfIntegers.Length; i++)
			{
				if (smallest > listOfIntegers[i])
				{
					smallest = listOfIntegers[i];
				}
			}

			Console.WriteLine("The smallest number is " + smallest);

			// Find the largest integer
			int largest = listOfIntegers[0];
			for (int i = 1; i < listOfIntegers.Length; i++)
			{
				if (largest < listOfIntegers[i])
				{
					largest = listOfIntegers[i];
				}
			}

			Console.WriteLine("The largest number is " + largest);
		}
    }
}
