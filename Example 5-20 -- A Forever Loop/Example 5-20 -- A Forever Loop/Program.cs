using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_5_20____A_Forever_Loop
{
    class Program
    {
        public static void Main()
        {
            int counterVariable = 0; // initialization

            for (; ; )  // forever
            {
                Console.WriteLine("counter: {0} ", counterVariable++); // increment

                if (counterVariable > 10) // test
                {
                    break;
                }
            }
        }
    }
}
