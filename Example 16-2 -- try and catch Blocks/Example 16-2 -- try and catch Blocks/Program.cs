using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_16_2____try_and_catch_blocks
{
    class Tester
    {
        public void Run()
        {
            Console.WriteLine("Entering Run...");
            Method1();
            Console.WriteLine("Exiting Run...");
        }

        public void Method1()
        {
            Console.WriteLine("Entering Method1...");
            Method2();
            Console.WriteLine("Exiting Method1...");
        }

        public void Method2()
        {
            Console.WriteLine("Entering Method2...");
            try
            {
                Console.WriteLine("Entering try block...");
                throw new System.Exception();
                // this next line can never execute
                Console.WriteLine("Exiting try block...");
            }
            catch
            {
                Console.WriteLine("Exception caught and handled!");
            }
            Console.WriteLine("Exiting Method2...");

        }
        static void Main()
        {
            Console.WriteLine("Entering Main...");
            Tester t = new Tester();
            t.Run();
            Console.WriteLine("Exiting Main...");
        }
    }
}
