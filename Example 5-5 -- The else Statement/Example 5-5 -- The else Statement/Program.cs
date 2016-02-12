using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_5_5____The_else_Statement
{
    class Program
    {
        static void Main()
        {
            int valueOne = 10;
            int valueTwo = 20;

            Console.WriteLine("Testing valueOne against valueTwo...");
            if (valueOne > valueTwo)
            {
                Console.WriteLine("ValueOne: {0} larger than ValueTwo: {1}", valueOne, valueTwo);
            } 
            else
            {
                Console.WriteLine("Nope, ValueOne: {0} is NOT larger than ValueTwo: {1}", valueOne, valueTwo);
            } 
        } 
    }    
}
