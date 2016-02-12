using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_15_2____Concatenating_Strings
{
    class Tester
    {
        public void Run()
        {
            string s1 = "abcd";
            string s2 = "ABCD";

            // concatenation method
            string s3 = string.Concat(s1, s2);
            Console.WriteLine("s3 concatenated from s1 and s2: {0}", s3);

            // use the overloaded operator
            string s4 = s1 + s2;
            Console.WriteLine("s4 concatenated from s1 + s2: {0}", s4);
        }

        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
