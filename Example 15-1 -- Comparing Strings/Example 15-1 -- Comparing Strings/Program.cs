using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_15_1____Comparing_Strings
{
    class Tester
    {
        public void Run()
        {
            // create some strings to work with
            string s1 = "abcd";
            string s2 = "ABCD";
            int result; // hold the results of comparisons

            // compare two strings, case-sensitive
            result = string.Compare(s1, s2);
            Console.WriteLine("Compare s1: {0}, s2: {1}, result: {2}\n", s1, s2, result);

            // overloaded compare, takes Boolean "ignore case"
            //(true = ignore case)
            result = string.Compare(s1, s2, true);
            Console.WriteLine("Compare insensitive. result: {0}\n", result);
        }

        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
