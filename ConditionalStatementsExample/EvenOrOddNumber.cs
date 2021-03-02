using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_example.ConditionalStatementsExample
{
    class EvenOrOddNumber
    {
		public static void RunExample()
		{
			Console.WriteLine("Please enter an integer to determine if it is an odd or even integer.");

			int number = Convert.ToInt32(Console.ReadLine());

			// If the number is odd
			if ((number % 2) == 0)
			{
				Console.WriteLine("The given integer is even");
			}
			else if (!(number % 2 == 0))
			{
				Console.WriteLine("The given integer is odd");
			}
			else
			{
				Console.WriteLine("THIS WILL NEVER BE PRINTED.");
			}
		}
	}
}
