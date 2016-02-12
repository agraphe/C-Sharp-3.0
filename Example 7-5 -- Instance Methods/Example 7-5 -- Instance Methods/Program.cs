using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_7_5____Instance_Methods
{
    // create the class
    class Tester
    {
        // Run is an instance method
        public void Run()
        {
            Console.WriteLine("Hello World");
        }

        // Main is static
        static void Main()
        {
            // create an instance
            Tester t = new Tester();

            // invoke the instance method
            t.Run();
        }
    }
}
