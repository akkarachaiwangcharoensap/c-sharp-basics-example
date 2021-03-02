using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_example.ObjectOrientedProgramming
{
	public class Student : Person
	{
		/**
		 * Student's age
		 */
		private int age;

		/**
		 * Student's declared major
		 */
		private String major;


		/**
		 * Is student poor (yes)
		 */
		private Boolean poor;

		/**
		 * Is student in STEM?
		 */
		private Boolean STEM;

		public Student(String name) : base(name)
		{

		}

		public override void Speak()
		{
			Console.WriteLine("I am a student!");
		}

		protected void BooHoo ()
        {
			Console.WriteLine("Boo Hoo!");
        }

		/**
		 * Set age
		 * 
		 * @param int age
		 * @return void
		 */
		public void SetAge (int age)
		{
			this.age = age;
		}

		/**
		 * Get age
		 * @return int this.age
		 */
		public int GetAge ()
		{
			return this.age;
		}

		/**
		 * Set major
		 * 
		 * @param String major
		 * @return void
		 */
		public void SetMajor (String major)
		{
			this.major = major;
		}

		/**
		 * Get major
		 * 
		 * @return String this.major
		 */
		public String GetMajor ()
		{
			return this.major;
		}

		/**
		 * Set poor
		 * 
		 * @param boolean poor
		 * @return void
		 */
		public void SetPoor (Boolean poor)
		{
			this.poor = poor;
		}

		/**
		 * Is poor
		 * @return boolean this.poor
		 */
		public Boolean IsPoor()
		{
			return this.poor;
		}

		/**
		 * Set STEM
		 * 
		 * @param boolean STEM
		 * @return void
		 */
		public void SetSTEM (Boolean STEM)
		{
			this.STEM = STEM;
		}

		/**
		 * Is STEM
		 *
		 * @return boolean this.STEM
		 */
		public Boolean isSTEM()
		{
			return this.STEM;
		}
	}
}
