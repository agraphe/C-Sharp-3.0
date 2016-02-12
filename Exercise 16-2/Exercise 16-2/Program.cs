using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_16_2
{
    class Tester
    {
        public void Run()
        {
            bool tryAgain = true;
            while (tryAgain)
            {
                int[] theIntArray = new int[] { 15, 27, 34 };
                Console.Write("Which array member would you like? ");

                try
                {
                    int theEntry = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("The entry you asked for is {0}", theIntArray[theEntry - 1]);
                }

                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Please enter a number from 1 to {0}.", theIntArray.Length);
                }

                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number.");
                }

                catch
                {
                    Console.WriteLine("That isn't a valid entry.");
                }

                Console.Write("Try again (y/n)? ");
                string theReply = Console.ReadLine();
                tryAgain = (theReply == "y" || theReply == "Y");
            }
        }

        static void Main(string[] args)
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
