using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_5_3
{
    class Program
    {
        enum numericCondition
        {
            even,
            multiple,
            odd,
            tooBig,
            unknown,
            zero
        }
        static void Main()
        {
            while (true)
            {
                Console.Write("Enter a number, please: ");
                string theEntry = Console.ReadLine();
                int theNumber = Convert.ToInt32(theEntry);

                numericCondition condition = numericCondition.unknown;  // initialize
                condition = (theNumber % 2 == 0) ?
                    numericCondition.even : numericCondition.odd;
                if (theNumber % 10 == 0) condition = numericCondition.multiple;
                if (theNumber == 0) condition = numericCondition.zero;
                if (theNumber > 100) condition = numericCondition.tooBig;
                // switch on the condition and display the correct message
                switch (condition)
                {
                    case numericCondition.even:
                        Console.WriteLine("Your number is even");
                        break;
                    case numericCondition.multiple:
                        Console.WriteLine("You have picked a multiple of 10");
                        break;
                    case numericCondition.odd:
                        Console.WriteLine("What an odd number to enter");
                        break;
                    case numericCondition.tooBig:
                        Console.WriteLine("Your number is too big for me.");
                        break;
                    case numericCondition.zero:
                        Console.WriteLine("zero is not even or odd or a multiple of 10");
                        break;
                    default:
                        Console.WriteLine("I'm sorry, I didn't understand that.");
                        break;
                }
            }
        }
    }
}
