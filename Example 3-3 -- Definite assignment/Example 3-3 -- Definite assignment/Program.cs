using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_3_3____Definite_assignment
{
    class Values
    {
        static void Main()
        {
            int myInt;
            //other code here...
            myInt = 7; // assign to it
            System.Console.WriteLine("Assigned, myInt: {0}", myInt);
            myInt = 5;
            System.Console.WriteLine("Reassigned, myInt: {0}", myInt);
        }
    }
}
