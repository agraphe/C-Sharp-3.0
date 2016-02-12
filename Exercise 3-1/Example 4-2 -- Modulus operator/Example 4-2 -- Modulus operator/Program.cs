using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_4_2____Modulus_operator
{
    class ValuesProgram
    {
        static void Main()
        {
            int firstInt, secondInt;
            float firstFloat, secondFloat;
            double firstDouble, secondDouble;
            decimal firstDecimal, secondDecimal;

            firstInt = 17;
            secondInt = 4;
            firstFloat = 17;
            secondFloat = 4;
            firstDouble = 17;
            secondDouble = 4;
            firstDecimal = 17;
            secondDecimal = 4;
            Console.WriteLine("Integer:\t{0}\nfloat:\t\t{1}", firstInt / secondInt, firstFloat / secondFloat);
            Console.WriteLine("double:\t\t{0}\ndecimal:\t{1}", firstDouble / secondDouble, firstDecimal / secondDecimal);
            Console.WriteLine("\nRemainder (modulus) from integer division:\t{0}", firstInt % secondInt);

        }
    }
}
