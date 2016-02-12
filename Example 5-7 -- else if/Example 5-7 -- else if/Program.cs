using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_5_7____else_if
{
    class Program
    {
        static void Main()
        {
            int temp = 32;

            if (temp < 32)
            {
                Console.WriteLine("Warning! Ice on road!");
            }
            else if (temp == 32)
            {
                Console.WriteLine("Temp exactly freezing, beware of water.");
            }
            else
            {
                Console.WriteLine("No ice; drive with confidence.");
            }
        }
    }
}
