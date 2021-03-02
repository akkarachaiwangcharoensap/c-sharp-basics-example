using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_example.ObjectOrientedProgramming
{
	public abstract class Person : Hunger
	{
		private String name;

		public Person (String name)
		{
			this.SetName(name);
		}

		public void Eat ()
		{
			Console.WriteLine("I am eating.");
		}

		public void Introduce ()
		{
			Console.WriteLine("Hello there, I am " + this.GetName());
		}

		public virtual void Speak ()
		{
			Console.WriteLine("A person can speak eh?");
		}

		/**
		 * Set name
		 * 
		 * @param String name
		 * @return void
		 */
		public void SetName (String name)
		{
			this.name = name;
		}

		/**
		 * Get name
		 * @return String this.getName
		 */
		public String GetName ()
		{
			return this.name;
		}
	}
}
