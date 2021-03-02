using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_example.ObjectOrientedProgramming
{
	public class Worker : Person
	{
		public Worker(String name) : base(name)
		{

		}

		public override void Speak()
		{
			Console.WriteLine("I am a worker!");
		}
	}
}
