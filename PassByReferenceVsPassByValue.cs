using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_example
{
    class PassByReferenceVsPassByValue
    {
        public static void RunExample ()
        {
            /**
             * Definition
             * Pass by reference = pass by a new copy
             * Pass by value = pass by current address
             */

            // Pass By Reference (copy) VS Pass By Value (address)
            int someInteger = 0;
            int addedInteger = PassByReferenceVsPassByValue.AddOneTo(someInteger);
            Console.WriteLine(addedInteger); // output: 1 `addedInteger` is the new copy
            Console.WriteLine(someInteger); // output: 0 `someInteger` does not change

            PassByReferenceVSPassByValueObject temp = new PassByReferenceVSPassByValueObject();
            Console.WriteLine(temp.SomeNumber);

            AddOneTo(temp); // `temp.SomeNumber is now 1` because we are directly changing the value by its address.
            AddOneTo(temp); // `temp.SomeNumber is now 2` because we are directly changing the value by its address.
            AddOneTo(temp); // `temp.SomeNumber is now 3` because we are directly changing the value by its address.

            Console.WriteLine(temp.SomeNumber); // output: 3

        }

        public static int AddOneTo (int number)
        {
            return number += 1;
        }

        public static void AddOneTo (PassByReferenceVSPassByValueObject obj)
        {
            obj.SomeNumber += 1;
        }
    }
}
