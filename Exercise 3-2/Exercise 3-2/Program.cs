using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_3_2
{
    class exercise
    {
        static void Main()
        {
            int myInt = 42;
            float myFloat = 98.6f;
            double myDouble = 12345.6789;
            char myChar = 'Z';
            string myString = "The quick brown fox jumped over the lazy dogs.";
            Console.WriteLine("myInt: {0}, myFloat: {1}, myDouble: {2}, myChar: {3}, myString: {4}", myInt, myFloat, myDouble, myChar, myString);

            myInt = 25;
            myFloat = 100.3f;
            myDouble = 98765.4321;
            myChar = 'M';
            myString = "A quick movement of the enemy will jeopardize six gun boats.";
            Console.WriteLine("myInt: {0}, myFloat: {1}, myDouble: {2}, myChar: {3}, myString: {4}", myInt, myFloat, myDouble, myChar, myString);      
        }
    }
}