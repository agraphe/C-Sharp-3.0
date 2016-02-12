using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_15_3____Copying_Strings
{
    class Tester
    {
        public void Run()
        {
            string s1 = "abcd";

            Console.WriteLine("string s1: {0}", s1);
            Console.WriteLine("string s2 = s1; ");
            
            string s2 = s1;
            Console.WriteLine("s1: {0} s2: {1}", s1, s2);
            Console.WriteLine("s1 == s2? {0}", s1 == s2);
            Console.WriteLine("ReferenceEquals(s1,s2): {0}", ReferenceEquals(s1, s2));
            Console.WriteLine(" \nstring s2 = string.Copy( s1 ); ");
            
            string s3 = string.Copy(s1);
            Console.WriteLine("s1: {0} s3: {1}", s1, s3);
            Console.WriteLine("s1 == s3? {0}", s1 == s3);
            Console.WriteLine("ReferenceEquals(s1,s3): {0}", ReferenceEquals(s1, s3));
            Console.WriteLine(" \ns2 = \"Hello\"; ");

            s1 = "Hello";
            Console.WriteLine("s1: {0} s2: {1}", s1, s2);
            Console.WriteLine("s1 == s2? {0}", s1 == s2);
            Console.WriteLine("ReferenceEquals(s1,s2): {0}", ReferenceEquals(s1, s2));
        }

        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
