using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_10_3____foreach_statement
{
    class Tester
    {
        public void Run()
        {
            int[] myIntArray = new int[10];

            //populate the array
            for (int i = 0; i < myIntArray.Length; i++)
            {
                myIntArray[i] = 2 * (i + 1);
            }

            //output the array
            foreach (int i in myIntArray)
            {
                Console.WriteLine("The value is {0}.", i);
            }

        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
