using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_example.ConditionalStatementsExample
{
    class ClassPicker
    {
        public static void RunExample()
        {
			Console.WriteLine("Please pick: 1, 2, 3, or 4 to schedule your next class.");

			int classNumber = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("You picked: " + classNumber);

			switch (classNumber)
			{
				case 1:
					Console.WriteLine("You have selected a Math class");
					break;
				case 2:
					Console.WriteLine("You have selected a Science class");
					break;
				case 3:
					Console.WriteLine("You have selected a Physical Education (PE) class");
					break;
				case 4:
					Console.WriteLine("You have selected a Computer Science class");
					break;
				default:
					Console.WriteLine("You did not pick a class!");
					break;
			}
		}
    }
}
