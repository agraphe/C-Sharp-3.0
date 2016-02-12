using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_15_4____String_Equality
{
    class Tester
    {
        public void Run()
        {
            string s1 = "abcd";
            string s2 = "ABCD";

            // the string copy method
            string s5 = string.Copy(s2);
            Console.WriteLine("s5 copied from s2: {0}", s5);
            string s6 = s5;
            Console.WriteLine("s6 = s5: {0}", s6);

            // member method
            Console.WriteLine("\nDoes s6.Equals(s5)?: {0}",
            s6.Equals(s5));

            // static method
            Console.WriteLine("Does Equals(s6,s5)?: {0}",
            string.Equals(s6, s5));

            // overloaded operator
            Console.WriteLine("Does s6==s5?: {0}", s6 == s5);
        }

        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
