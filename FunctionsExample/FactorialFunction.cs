using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_example.FunctionsExample
{
    class FactorialFunction
    {
		public static FactorialFunction Instance;

		public FactorialFunction()
		{
			FactorialFunction.Instance = this;
		}

		public static void RunExample()
		{
			Console.WriteLine(Instance.Factorial(5));
		}

		public int Factorial (int i)
		{
			if (i == 0)
            {
				return 1;
            }

			return i * this.Factorial(i - 1);
		}
	}
}
