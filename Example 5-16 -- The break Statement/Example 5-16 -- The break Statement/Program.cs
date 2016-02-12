using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_5_16____The_break_Statement
{
    class Program
    {
        public static void Main()
        {
            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine("counter: {0} ", counter);

                // if condition is met, break out.
                if (counter == 5)
                {
                    {
                        Console.WriteLine("Breaking out of the loop");
                        break;
                    }
                }

            }
            Console.WriteLine("For loop ended");
        }
    }
}
