using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_example.FunctionsExample
{
    class CalculatorFunction
    {
        public static CalculatorFunction Instance;

        public CalculatorFunction ()
        {
            CalculatorFunction.Instance = this;
        }

        public static void RunExample ()
        {
			Console.WriteLine(Instance.Add(1, 2));
			Console.WriteLine(Instance.Subtract(1, 1));
			Console.WriteLine(Instance.Multiply(1, 1));
			Console.WriteLine(Instance.Divide(1, 1));
			Console.WriteLine(Instance.Modulus(1, 1));
		}

		public int Add (int a, int b)
		{
			return a + b;
		}

		public int Subtract (int a, int b)
		{
			return a - b;
		}

		public int Multiply (int a, int b)
		{
			return a * b;
		}

		public int Divide (int a, int b)
		{
			return a / b;
		}

		public int Modulus (int a, int b)
		{
			return a % b;
		}
	}
}
