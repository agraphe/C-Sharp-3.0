using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_5_2
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Enter a number please: ");
                string theEntry = Console.ReadLine();
                int theNumber = Convert.ToInt32(theEntry);

                // Logic: if the number is greater than 100, say it is too big
                // if it is even but not a multiple of 10 say it is even
                // if it is a multiple of 10, say so
                // if it is not even, say it is odd
                if (theNumber <= 100)
                {
                    if (theNumber % 2 == 0)
                    {
                        if (theNumber == 0)
                        {
                            Console.WriteLine("Zero is not even or odd or a multiple of 10");
                        }
                        else
                        {
                            if (theNumber % 10 == 0)
                            {
                                Console.WriteLine("You have picked a multiple of 10");
                            }
                            else
                            {
                                Console.WriteLine("Your number is even");
                            }  // end else not a multiple of 10
                        }  // end else not zero
                    }  // end if even
                    else
                    {
                        Console.WriteLine("What an odd number to enter");
                    }
                }  // end if not too big
                else
                {
                    Console.WriteLine("Your number is too big for me.");
                }
            } // end while
        }
    }
}
