using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_example.ObjectOrientedProgramming
{
	public class ComputerScienceStudent : Student
		{
		public ComputerScienceStudent (String name) : base(name)
		{

		}

		public override void Speak()
		{
			Console.WriteLine("I am a Computer Science student!");
		}
	}
}
