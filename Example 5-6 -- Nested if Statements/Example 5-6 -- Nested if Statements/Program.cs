using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_5_6____Nested_if_Statements
{
    class Program
    {
        static void Main()
        {
            int temp = 32;

            if (temp <= 32)
            {
                Console.WriteLine("Warning! Ice on road!");
                if (temp == 32)
                {
                    Console.WriteLine("Temp exactly freezing, beware of water.");
                }
                else
                {
                    Console.WriteLine("Watch for black ice! Temp: {0}", temp);
                }
            }
            else
            {
                Console.WriteLine("No ice; drive with confidence.");
            }
        }
    }
}
