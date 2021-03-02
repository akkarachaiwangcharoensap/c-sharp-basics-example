using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_basics_example
{
    class PassByReferenceVSPassByValueObject
    {
        public int SomeNumber { set; get; }

        public PassByReferenceVSPassByValueObject ()
        {
            SomeNumber = 0;
        }
    }
}
