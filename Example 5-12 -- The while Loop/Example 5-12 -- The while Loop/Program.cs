using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_5_12____The_while_Loop
{
    class Program
    {
        public static void Main()
        {
            int counterVariable = 0;

            // while the counter variable is less than 10
            // print out its value
            while (counterVariable < 10)
            {
                Console.WriteLine("counterVariable: {0}", counterVariable);
                counterVariable++;
            }
        }
    }
}
