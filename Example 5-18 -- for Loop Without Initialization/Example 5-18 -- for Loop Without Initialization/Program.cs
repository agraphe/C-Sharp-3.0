using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_5_18____for_Loop_Without_Initialization
{
    class Program
    {

        public static void Main()
        {
            int counter = 0;
            // some work here
            counter = 3;
            // more work here

            for (; counter < 10; counter++)
            {
                Console.WriteLine("counter: {0} ", counter);
            }
        }
    }
}
