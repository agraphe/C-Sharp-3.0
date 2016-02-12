﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_15_8____StringBuilder
{
    class Tester
    {
        public void Run()
        {
            // create some strings to work with
            string s1 = "One,Two,Three Liberty Associates, Inc.";

            // constants for the space and comma characters
            const char Space = ' ';
            const char Comma = ',';

            // array of delimiters to split the sentence with
            char[] delimiters = new char[]
            {
                Space,
                Comma
            };

            // use a StringBuilder class to build the
            // output string
            StringBuilder output = new StringBuilder();
            int ctr = 1;

            // split the string and then iterate over the
            // resulting array of strings
            foreach (string subString in s1.Split(delimiters))
            {
                // AppendFormat appends a formatted string
                output.AppendFormat("{0}: {1}\n", ctr++, subString);
            }
            Console.WriteLine(output);

        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
