using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_3_4____Symbolic_Constants
{
    class Values
    {
        static void Main()
        {
            const int FreezingPoint = 32; // degrees Fahrenheit
            const int BoilingPoint = 212;

            System.Console.WriteLine("Freezing point of water: {0}", FreezingPoint);
            System.Console.WriteLine("Boiling point of water: {0}", BoilingPoint);

            BoilingPoint = 21;
        }
    }
}
