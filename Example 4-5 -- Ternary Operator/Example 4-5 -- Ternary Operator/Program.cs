using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_4_5____Ternary_Operator
{
    class ValuesProgram
    {
        static void Main()
        {
            int valueOne = 10;
            int valueTwo = 20;

            int maxValue = valueOne > valueTwo ? valueOne : valueTwo;

            Console.WriteLine("ValueOne: {0}, valueTwo: {1}, maxValue: {2}", valueOne, valueTwo, maxValue);

        }
    }
}
