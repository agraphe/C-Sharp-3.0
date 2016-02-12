using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_5_2____The_if_Statement
{
    class Program
    {
        static void Main()
        {
            int valueOne = 10;
            int valueTwo = 20;
            int valueThree = 30;

            Console.WriteLine("Testing valueOne against valueTwo...");
            if (valueOne > valueTwo)
            {
                Console.WriteLine("ValueOne: {0} larger than ValueTwo: {1}", valueOne, valueTwo);
            }

            Console.WriteLine("Testing valueThree against valueTwo...");
            if (valueThree > valueTwo)
            {
                Console.WriteLine("ValueThree: {0} larger than ValueTwo: {1}", valueThree, valueTwo);
            }    
        }       
    }      
}
