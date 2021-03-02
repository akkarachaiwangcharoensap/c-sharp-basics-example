using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_example
{
    class ConditionalStatements
    {
        public static void RunExample ()
        {
			Boolean catWoofs = false;
			Boolean dogWoofs = true;
			Boolean fishCanWalk = false;

			// This is false.
			if (catWoofs)
			{
				Console.WriteLine("Cat does woof!");
				Console.WriteLine("THIS WILL NEVER PRINT OUT THE MESSAGE");
			}

			// This is true.
			if (dogWoofs)
			{
				Console.WriteLine("Dog does woof!");
			}

			// This is false
			if (fishCanWalk)
			{
				Console.WriteLine("Fish can walk!");
			}

			// This is true 
			if (catWoofs == false && dogWoofs == true && fishCanWalk == false)
			{
				Console.WriteLine("This makes sense! Cat does not woof, dog does woof and fish cannot walk!");
			}

			// Same as above with different format
			if (!catWoofs && dogWoofs && !fishCanWalk)
			{
				Console.WriteLine("This also makes sense!");
			}

			// greater than
			// greater than or equal to
			// less than
			// less than or equal to
			Boolean greaterThan = 1 > 2;                // false
			Boolean greaterThanOrEqualTo = 0 >= 0;      // true
			Boolean lessThan = 1 < 2;                   // true
			Boolean lessThanOrEqualTo = 0 <= 0;         // true

			Console.WriteLine(greaterThan);
			Console.WriteLine(greaterThanOrEqualTo);
			Console.WriteLine(lessThan);
			Console.WriteLine(lessThanOrEqualTo);

			// String value comparison
			String stringA = new String("A");
			String fooA = new String("A");

			// Reference comparison
			Console.WriteLine(stringA == "A");         // false
			Console.WriteLine(stringA == fooA);        // false

			// String value comparison
			Console.WriteLine(stringA.Equals("A"));    // true
			Console.WriteLine(stringA.Equals(fooA));   // true
		}
    }
}
