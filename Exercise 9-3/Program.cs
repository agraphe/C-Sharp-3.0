using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_9_3
{
    class Program
    {
        public static int Factorial(int myInt)
        {
            int result = 1;
            for (int i = 1; i < myInt; i++)
            {
                result = result * i;
            }
            return result;
        }


        static void Main()
        {
            int input = 5;
            Console.WriteLine("{0} factorial is {1}", input, Factorial(input));
        }
    }
}
