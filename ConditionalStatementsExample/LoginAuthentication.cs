using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_example.ConditionalStatementsExample
{
    class LoginAuthentication
    {
        public static void RunExample ()
        {
			Console.WriteLine("Please enter your name and password.");

			String name = Console.ReadLine();
			String password = Console.ReadLine();

			if (name.Equals("Aki") && password.Equals("password"))
			{
				Console.WriteLine("Hello there, " + name + "!");
			}
			else
			{
				Console.WriteLine("ERROR: The credentials do not exist");
			}
		}
    }
}
