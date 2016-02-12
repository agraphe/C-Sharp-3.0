using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_15_3
{
    class Tester
    {
        public void Run()
        {
            int theCount = 0;
            string theString = "We choose to go to the moon. " +
                               "We choose to go to the moon in " +
                               "this decade and do the other " +
                               "things, not because they are easy, " +
                               "but because they are hard, " +
                               "because that goal will serve to " +
                               "organize and measure the best of " +
                               "our energies and skills, because " +
                               "that challenge is one that we are " +
                               "willing to accept, one we are " +
                               "unwilling to postpone, and one which " +
                               "we intend to win, and the others, too. ";

            while (theString.IndexOf("the ") != -1)
            {
                theString = theString.Substring(theString.IndexOf("the ") + 4);
                theCount++;
            }
            Console.WriteLine("The word \"the\" occurs {0} times in the string.", theCount);
        }
    }
    class Program
    {
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
