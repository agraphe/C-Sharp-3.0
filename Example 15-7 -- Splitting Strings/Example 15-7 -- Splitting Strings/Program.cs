using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_15_7____Splitting_Strings
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

            int ctr = 1;

            // split the string and then iterate over the
            // resulting array of strings

            String[] resultArray = s1.Split(delimiters);

            foreach (String subString in resultArray)
            {
                Console.WriteLine(ctr++ + ":" + subString);
            }
        }

        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
