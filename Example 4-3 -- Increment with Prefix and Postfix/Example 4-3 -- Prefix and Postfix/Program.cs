﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_4_3____Prefix_and_Postfix
{
    class Program
    {
        static void Main()
        {
            int original = 10;
            int result;

            // increment then assign
            result = ++original;
            Console.WriteLine("After prefix: {0}, {1}", original, result);

            // assign then increment
            result = original++;
            Console.WriteLine("After postfix: {0}, {1}", original, result);
        }
    }
}
