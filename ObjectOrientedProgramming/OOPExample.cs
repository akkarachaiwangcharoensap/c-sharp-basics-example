using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_example.ObjectOrientedProgramming
{
    class OOPExample
    {
        public static void RunExample ()
        {
			Student studentA = new Student("Bob");
			Teacher teacherA = new Teacher("Allan");
			Worker workerA = new Worker("John");
			ComputerScienceStudent csStudentA = new ComputerScienceStudent("Aki");

			studentA.Speak();
			teacherA.Speak();
			workerA.Speak();
			csStudentA.Speak();

			((Person)studentA).Introduce();
			((Person)teacherA).Introduce();
			((Person)workerA).Introduce();
			((Person)csStudentA).Introduce();

			((Person)studentA).Eat();
			((Person)teacherA).Eat();
			((Person)workerA).Eat();
			((Person)csStudentA).Eat();
		}
    }
}
