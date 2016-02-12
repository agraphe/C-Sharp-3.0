using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_5_13____The_do._._.while_Loop
{
    class Program
    {
        public static void Main()
        {
            int counterVariable = 11;

            // display the message and then test that the value is
            // less than 10
            do
            {
                Console.WriteLine("counterVariable: {0}", counterVariable);
                counterVariable++;
            } while (counterVariable < 10);
        }
    }
}
