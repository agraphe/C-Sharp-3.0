using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_5_9____The_default_statement
{
    class Program
    {
        enum Party
        {
            Democrat,
            Republican,
            Progressive
        }
        static void Main()
        {

            // hard-wire to Democratic
            Party myChoice = Party.Democrat;

            // switch on the value of myChoice
            switch (myChoice)
            {
                /* case Party.Democrat:
                    Console.WriteLine("You voted Democratic.");
                    break; */
                case Party.Republican:
                    Console.WriteLine("You voted Republican.");
                    break;
                case Party.Progressive:
                    Console.WriteLine("You voted Progressive.");
                    break;
                default:
                    Console.WriteLine("You did not make a valid choice.");
                    break;

            }
            Console.WriteLine("Thank you for voting.");
        }
    }
}
