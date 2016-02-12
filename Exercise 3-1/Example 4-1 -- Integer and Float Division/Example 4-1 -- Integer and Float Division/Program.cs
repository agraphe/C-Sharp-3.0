using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_4_1____Integer_and_Float_Division
{
    class Program
    {
        public static void Main()
        {
            int smallInt = 5;
            int largeInt = 12;
            int intQuotient;
            intQuotient = largeInt / smallInt;
            Console.WriteLine("Dividing integers. {0} / {1} = {2}", largeInt, smallInt, intQuotient);

            float smallFloat = 5;
            float largeFloat = 12;
            float FloatQuotient;
            FloatQuotient = largeFloat / smallFloat;
            Console.WriteLine("Dividing floats. {0} / {1} = {2}", largeFloat, smallFloat, FloatQuotient);

        }
    }
}
