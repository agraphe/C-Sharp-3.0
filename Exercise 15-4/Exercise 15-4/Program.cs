using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Exercise_15_4
{
    class Tester
    {
        public void Run()
        {
            string importantString = "We hold these truths to be self-evident, " +
                                     "that all men are created equal, that " +
                                     "they are endowed by their Creator with " +
                                     "certain unalienable Rights, that among " +
                                     "these are Life, Liberty and the pursuit " +
                                     "of Happiness.";

            Regex theRegex = new Regex(" |, |,");
            StringBuilder sBuilder = new StringBuilder();
            int id = 1;
            foreach (string subString in theRegex.Split(importantString))
            {
                sBuilder.AppendFormat("{0}: {1}\n", id++, subString);
            }
            Console.WriteLine("{0}", sBuilder);
        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
