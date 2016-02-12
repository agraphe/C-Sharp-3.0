using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_5_17____The_break_and_continue_Statements
{
    class Program
    {
        public static int Main()
        {
            string signal = "0"; // initialize to neutral
            while (signal != "X") // X indicates stop
            {
                Console.Write("Enter a signal. 0 for normal conditions, X to stop, A to Abort: ");
                signal = Console.ReadLine();

                // do some work here, no matter what signal you
                // receive
                Console.WriteLine("Received: {0}", signal);

                if (signal == "A")
                {
                    // faulty - abort signal processing
                    // Log the problem and abort.
                    Console.WriteLine("Fault! Abort\n");
                    break;
                }

                if (signal == "0")
                {
                    // normal traffic condition
                    // log and continue on
                    Console.WriteLine("All is well.\n");
                    continue;
                }

                // Problem. Take action and then log the problem
                // and then continue on
                Console.WriteLine("{0} -- raise alarm!\n", signal);
            }
            return 0;
        }
    }
}
