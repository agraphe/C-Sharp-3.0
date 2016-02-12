using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_10_2
{
    public class Tester
    {
        public void Run()
        {
            int[] intArray = new int[10];
            Console.WriteLine("You'll be asked to enter 10 integers");
            // enter data into the array
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.Write("Enter an integer: ");
                string theEntry = Console.ReadLine();
                intArray[i] = Convert.ToInt32(theEntry);
            }
            // sort and reverse the array
            Array.Sort(intArray);
            Array.Reverse(intArray);
            Console.WriteLine("\nValues:");
            foreach (int j in intArray)
            {
                Console.WriteLine("{0}", j);
            }
        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
