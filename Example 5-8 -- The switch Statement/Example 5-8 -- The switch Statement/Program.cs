using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_5_8____The_switch_Statement
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

            // hard wire to Democratic
            Party myChoice = Party.Democrat;

            // switch on the value of myChoice
            switch (myChoice)
            {
                case Party.Democrat:
                    Console.WriteLine("You voted Democratic.");
                    break;
                case Party.Republican:
                    Console.WriteLine("You voted Republican.");
                    break;
                case Party.Progressive:
                    Console.WriteLine("You voted Progressive.");
                    break;

            }
            Console.WriteLine("Thank you for voting.");
        }
    }
}
