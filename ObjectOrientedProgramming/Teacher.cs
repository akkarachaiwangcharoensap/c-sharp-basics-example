using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_example.ObjectOrientedProgramming
{
	public class Teacher : Person
	{
		public Teacher (String name) : base(name)
		{

		}

		public override void Speak()
		{
			Console.WriteLine("I am a teacher!");
		}
	}
}
