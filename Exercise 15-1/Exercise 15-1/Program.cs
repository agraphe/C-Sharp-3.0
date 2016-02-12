using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_15_1
{
    class Tester
    {
        public void Run()
        {
            // creating the six strings
            string s1 = "Hello ";
            string s2 = "World";
            string s3 = @"Come visit us at http://www.LibertyAssociates.com";
            string s4 = s1 + s2;
            string s5 = "world";
            string s6 = string.Copy(s3);

            // returning the length of each string
            Console.WriteLine("Here's how long our strings are...");
            Console.WriteLine("s1: {0} [{1}]", s1.Length, s1);
            Console.WriteLine("s2: {0} [{1}]", s2.Length, s2);
            Console.WriteLine("s3: {0} [{1}]", s3.Length, s3);
            Console.WriteLine("s4: {0} [{1}]", s4.Length, s4);
            Console.WriteLine("s5: {0} [{1}]", s5.Length, s5);
            Console.WriteLine("s6: {0} [{1}]", s6.Length, s6);

            // returning the third character in each string
            Console.WriteLine("\nHere's the third character in each string...");
            Console.WriteLine("s1: {0} [{1}]", s1[2], s1);
            Console.WriteLine("s2: {0} [{1}]", s2[2], s2);
            Console.WriteLine("s3: {0} [{1}]", s3[2], s3);
            Console.WriteLine("s4: {0} [{1}]", s4[2], s4);
            Console.WriteLine("s5: {0} [{1}]", s5[2], s5);
            Console.WriteLine("s6: {0} [{1}]", s6[2], s6);

            // testing for the character H in each string
            Console.WriteLine("\nIs there an h in the string?");
            Console.WriteLine("s1: {0} [{1}]", s1.ToUpper().IndexOf('H') >= 0 ? "yes" : "nope", s1);
            Console.WriteLine("s2: {0} [{1}]", s2.ToUpper().IndexOf('H') >= 0 ? "yes" : "nope", s2);
            Console.WriteLine("s3: {0} [{1}]", s3.ToUpper().IndexOf('H') >= 0 ? "yes" : "nope", s3);
            Console.WriteLine("s4: {0} [{1}]", s4.ToUpper().IndexOf('H') >= 0 ? "yes" : "nope", s4);
            Console.WriteLine("s5: {0} [{1}]", s5.ToUpper().IndexOf('H') >= 0 ? "yes" : "nope", s5);
            Console.WriteLine("s6: {0} [{1}]", s6.ToUpper().IndexOf('H') >= 0 ? "yes" : "nope", s6);

            // testing for strings the same as String 2
            Console.WriteLine("\nWhich strings are the same as s2 [{0}]?", s2);
            Console.WriteLine("s1: {0} [{1}]", String.Compare(s1, s2) == 0 ? "Same!" : "Different", s1);
            Console.WriteLine("s2: {0} [{1}]", String.Compare(s2, s2) == 0 ? "Same!" : "Different", s2);
            Console.WriteLine("s3: {0} [{1}]", String.Compare(s3, s2) == 0 ? "Same!" : "Different", s3);
            Console.WriteLine("s4: {0} [{1}]", String.Compare(s4, s2) == 0 ? "Same!" : "Different", s4);
            Console.WriteLine("s5: {0} [{1}]", String.Compare(s5, s2) == 0 ? "Same!" : "Different", s5);
            Console.WriteLine("s6: {0} [{1}]", String.Compare(s6, s2) == 0 ? "Same!" : "Different", s6);

            // testing for strings the same as String 2, ignoring case
            Console.WriteLine("\nWhich strings are the same as s2 [{0}] ignoring case?", s2);
            Console.WriteLine("s1: {0} [{1}]", String.Compare(s1, s2, true) == 0 ? "Same!" : "Different", s1);
            Console.WriteLine("s2: {0} [{1}]", String.Compare(s2, s2, true) == 0 ? "Same!" : "Different", s2);
            Console.WriteLine("s3: {0} [{1}]", String.Compare(s3, s2, true) == 0 ? "Same!" : "Different", s3);
            Console.WriteLine("s4: {0} [{1}]", String.Compare(s4, s2, true) == 0 ? "Same!" : "Different", s4);
            Console.WriteLine("s5: {0} [{1}]", String.Compare(s5, s2, true) == 0 ? "Same!" : "Different", s5);
            Console.WriteLine("s6: {0} [{1}]", String.Compare(s6, s2, true) == 0 ? "Same!" : "Different", s6);
        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
