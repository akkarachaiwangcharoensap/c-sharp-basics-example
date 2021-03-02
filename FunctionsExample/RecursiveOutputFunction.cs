using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_example.FunctionsExample
{
    class RecursiveOutputFunction
    {
		public static RecursiveOutputFunction Instance;

		public RecursiveOutputFunction()
		{
			RecursiveOutputFunction.Instance = this;
		}

		public static void RunExample()
		{
			Instance.OutputRecursion(5);
		}

		public void OutputRecursion (int i)
		{
			if (i == 0)
			{
				return;
			}

			Console.WriteLine (i);

			this.OutputRecursion(i - 1);

			Console.WriteLine (i);
		}
	}
}
