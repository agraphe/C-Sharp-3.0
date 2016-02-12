using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_5_11____The_goto_Statement
{
    class Program
    {

        public static void Main()
        {
            int counterVariable = 0;

        repeat: // the label

            Console.WriteLine("counterVariable: {0}", counterVariable);

            // increment the counter
            counterVariable++;

            if (counterVariable < 10)
            {
                goto repeat; // the dastardly deed
            }
        }
    }
}
