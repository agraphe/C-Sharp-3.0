using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_15_2
{
    class Tester
    {
        public void Run()
        {
            string myString = "To be, or not to be: That is the " +
                              "question: Whether 'tis nobler in " +
                              "the mind to suffer the slings and " +
                              "arrows of outrageous fortune, or to " +
                              "take arms against a sea of troubles, " +
                              "and by opposing end them?";

            char[] delimiters = {',', ':', ' '};
            
            String[] theStringArray = myString.Split(delimiters);
            Array.Reverse(theStringArray);
            
            StringBuilder sBuilder = new StringBuilder();
            foreach (String subString in theStringArray)
            {
                sBuilder.AppendFormat("{0} ",subString);
            }

            Console.WriteLine(sBuilder);
            
        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
