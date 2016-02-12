using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_3_1____Using_variables
{
    class Values
    {
        static void Main()
        {
            int myInt = 7;
            System.Console.WriteLine("Initialized, myInt: {0}", myInt);
            myInt = 5;
            System.Console.WriteLine("After assignment, myInt: {0}", myInt);
        }
    }
}
