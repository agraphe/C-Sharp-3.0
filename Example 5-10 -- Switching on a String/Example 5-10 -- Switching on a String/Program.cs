using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_5_10____Switching_on_a_String
{
    class Program
    {
        static void Main()
        {
            String myChoice = "NewLeft";

            // switch on the string value of myChoice
            switch (myChoice)
            {
                case "NewLeft":
                    Console.WriteLine(
                    "The NewLeft members are voting Democratic.");
                    goto case "Democrat";
                case "Democrat":
                    Console.WriteLine("You voted Democratic.\n");
                    break;
                case "CompassionateRepublican": // fall through
                case "Republican":
                    Console.WriteLine("You voted Republican.\n");
                    Console.WriteLine("Don't you feel compassionate?");
                    break;
                case "Progressive":
                    Console.WriteLine("You voted Progressive.\n");
                    break;
                default:
                    Console.WriteLine("You did not make a valid choice.");
                    break;
            }
            Console.WriteLine("Thank you for voting.");
        }
    }
}
