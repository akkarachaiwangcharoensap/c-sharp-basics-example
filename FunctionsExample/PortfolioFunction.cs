using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_example.FunctionsExample
{
    class PortfolioFunction
    {
		public static PortfolioFunction Instance;

		public PortfolioFunction()
		{
			PortfolioFunction.Instance = this;
		}

		public static void RunExample()
		{
			Instance.ShowPortfolio("Aki", new String[] { "Web Development", "Software Development" }, 3);
		}

		public void ShowPortfolio(String name, String[] skills, int yearsOfWorkExperience)
		{
			Console.WriteLine("Hello, my name is " + name);
			Console.WriteLine("I can do: ");
			
			foreach (String skill in skills)
			{
				Console.WriteLine(skill);
			}

			Console.WriteLine("I have at least " + yearsOfWorkExperience + " years of experience");
		}
	}
}
