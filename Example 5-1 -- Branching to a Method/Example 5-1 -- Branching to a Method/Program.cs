using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_5_1____Branching_to_a_Method
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("In Main! Calling SomeMethod()...");
            SomeMethod();
            Console.WriteLine("Back in Main().");
        }
        static void SomeMethod()
        {
            Console.WriteLine("Greetings from SomeMethod!");
        }
    }
}
