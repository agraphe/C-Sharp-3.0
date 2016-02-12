using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_5_19____for_Loop_Without_Iterator
{
    class Program
    {

        public static void Main()
        {

            for (int counter = 0; counter < 10; ) // no increment
            {
                Console.WriteLine("counter: {0} ", counter);

                // do more work here

                counter++; // increment counter
            }
        }
    }
}
