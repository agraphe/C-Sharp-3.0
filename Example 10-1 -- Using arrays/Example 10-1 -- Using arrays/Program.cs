using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_10_1____Using_arrays
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
            for (int i = 0; i < myIntArray.Length; i++)
            {
                Console.WriteLine("Value in index {0} is {1}.", i, myIntArray[i]);
            }

        }
        static void Main(string[] args)
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
