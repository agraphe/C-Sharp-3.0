using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_15_5____String_Methods
{
    class Tester
    {
        public void Run()
        {
            string s1 = "abcd";
            string s2 = "ABCD";
            string s3 = @"Liberty Associates, Inc.
 provides custom .NET development,
 on-site Training and Consulting";

            // the string copy method
            string s5 = string.Copy(s2);
            Console.WriteLine("s5 copied from s2: {0}", s5);

            // Two useful properties: the index and the length
            Console.WriteLine("\nString s3 is {0} characters long. ", s3.Length);
            Console.WriteLine("The 5th character is {0}\n", s3[4]);

            // test whether a string ends with a set of characters
            Console.WriteLine("s3:{0}\nEnds with Training?: {1}\n", s3, s3.EndsWith("Training"));
            Console.WriteLine("Ends with Consulting?: {0}", s3.EndsWith("Consulting"));

            // return the index of the substring
            Console.WriteLine("\nThe first occurrence of Training ");
            Console.WriteLine("in s3 is {0}\n", s3.IndexOf("Training"));

            // insert the word excellent before "training"
            string s10 = s3.Insert(71, "excellent ");
            Console.WriteLine("s10: {0}\n", s10);

            // you can combine the two as follows:
            string s11 = s3.Insert(s3.IndexOf("Training"), "excellent ");
            Console.WriteLine("s11: {0}\n", s11);
        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
