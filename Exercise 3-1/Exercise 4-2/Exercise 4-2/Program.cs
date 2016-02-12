using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int varA = 5;
            int varB = ++varA;
            int varC = varB++;
            Console.WriteLine("A: {0}, B: {1}, C: {2}", varA, varB, varC);
        }
    }
}
