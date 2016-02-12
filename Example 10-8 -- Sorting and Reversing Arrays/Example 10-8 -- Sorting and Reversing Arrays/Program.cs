using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_10_8____Sorting_and_Reversing_Arrays
{
    public class Tester
    {
        public static void PrintMyArray(string[] theArray)
        {

            foreach (string str in theArray)
            {
                Console.WriteLine("Value: {0}", str);
            }
            Console.WriteLine("\n");
        }

        static void Main()
        {
            String[] myArray =
            {
                "Proust", "Faulkner", "Mann", "Hugo"
            };

            PrintMyArray(myArray);
            Array.Reverse(myArray);
            PrintMyArray(myArray);

            String[] myOtherArray =
            {
                "We", "Hold", "These", "Truths", "To", "Be", "Self", "Evident",
            };

            PrintMyArray(myOtherArray);
            Array.Sort(myOtherArray);
            PrintMyArray(myOtherArray);

        }
    }
}
