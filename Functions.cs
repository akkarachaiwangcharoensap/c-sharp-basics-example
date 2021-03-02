using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_example
{
    class Functions
    {
		public static Functions Instance;

		public int Foo { get; set; }

		public Functions ()
        {
			Functions.Instance = this;
        }

        public static void RunExample ()
        {
			Instance.VoidFunction();
			Instance.IntegerFunction();
			Instance.BooleanFunction();
			Instance.FloatFunction();
			Instance.DoubleFunction();
			Instance.OutputArray(Instance.StringArrayFunction());
			Instance.FunctionWithArguments("Aki", "Canada");
			Instance.RecursiveFunction(5);
		}

		public void VoidFunction()
		{
			Console.WriteLine("This is a void function. It does not return anything!");
		}

		public int IntegerFunction()
		{
			Console.WriteLine("This is an integer function. It returns an integer value!");
			return 1 + 1;
		}

		public Boolean BooleanFunction()
		{
			Console.WriteLine("This is a boolean function. It returns a boolean value!");
			return true;
		}

		public float FloatFunction()
		{
			Console.WriteLine("This is a float function. It returns a float value!");
			return 1.2f + 1.5f;
		}

		public double DoubleFunction()
		{
			Console.WriteLine("This is a double function. It returns a double value!");
			return 2.245 + 1.2345;
		}

		public String[] StringArrayFunction()
		{
			Console.WriteLine("This is a string array function. It returns an array string object!");
			return new String[] { "Hello", "I", "Am", "Aki" };
		}

		public void FunctionWithArguments(String name, String country)
		{
			Console.WriteLine("Hello " + name + " !");
			Console.WriteLine("I see you that live in " + country + "!");
			Console.WriteLine("Awesome!");
		}

		public String OutputArray(String[] items)
		{
			String output = "";
			for (int i = 0; i < items.Length; i++)
			{
				output += items[i];

				if (i < items.Length - 1)
				{
					output += ", ";
				}
			}

			return output;
		}

		public void RecursiveFunction(int i)
		{
			if (i == 0)
			{
				return;
			}

			this.RecursiveFunction(i - 1);

			Console.WriteLine("Printing from: " + i);
		}
	}
}
