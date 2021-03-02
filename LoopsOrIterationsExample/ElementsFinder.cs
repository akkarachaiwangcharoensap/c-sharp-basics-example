using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_example.LoopsOrIterationsExample
{
    class ElementsFinder
    {
        public static void RunExample ()
        {
            int target = 4;
            int[] listOfIntegers = new int[] { 2, 4, 125, -12602, 123123, 4, -123, 12412, 5, 4 };

            for (int i = 0; i < listOfIntegers.Length; i++)
            {
                if (listOfIntegers[i] == target)
                {
                    Console.WriteLine(target + " found at index: " + i);
                }
            }
        }
    }
}
