using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_example.ConditionalStatementsExample
{
    class LetterGrade
    {
		public static void RunExample()
		{
			Console.WriteLine("Please enter percentage value to determine your letter grade.");

			int percentage = Convert.ToInt32(Console.ReadLine());

			if (percentage >= 86)
			{
				Console.WriteLine("You got an A");
			}
			else if (percentage >= 73)
			{
				Console.WriteLine("You got a B");
			}
			else if (percentage >= 50)
			{
				Console.WriteLine("You got a C");
			}
			else
			{
				Console.WriteLine("You are failing... That is unfortunate...");
			}
		}
	}
}
