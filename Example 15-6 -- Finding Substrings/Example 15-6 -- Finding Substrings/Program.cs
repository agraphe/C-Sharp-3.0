using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_15_6____Finding_Substrings
{
    class Tester
    {
        public void Run()
        {
            // create some strings to work with
            string s1 = "One Two Three Four";

            int index;

            // get the index of the last space
            index = s1.LastIndexOf(" ");

            // get the last word.
            string s2 = s1.Substring(index + 1);

            // set s1 to the substring starting at 0
            // and ending at index (the start of the last word)
            // thus s1 has "one two three"
            s1 = s1.Substring(0, index);

            // find the last space in s1 (after two)
            index = s1.LastIndexOf(" ");

            // set s3 to the substring starting at
            // index, the space after "two" plus one more
            // thus s3 = "three"
            string s3 = s1.Substring(index + 1);
            // reset s1 to the substring starting at 0
            // and ending at index, thus the string "one two"
            s1 = s1.Substring(0, index);

            // reset index to the space between
            // "one" and "two"
            index = s1.LastIndexOf(" ");

            // set s4 to the substring starting one
            // space after index, thus the substring "two"
            string s4 = s1.Substring(index + 1);

            // reset s1 to the substring starting at 0
            // and ending at index, thus "one"
            s1 = s1.Substring(0, index);

            // set index to the last space, but there is
            // none so index now = -1
            index = s1.LastIndexOf(" ");

            // set s5 to the substring at one past
            // the last space. there was no last space
            // so this sets s5 to the substring starting
            // at zero
            string s5 = s1.Substring(index + 1);

            Console.WriteLine("s2: {0}\ns3: {1}", s2, s3);
            Console.WriteLine("s4: {0}\ns5: {1}\n", s4, s5);
            Console.WriteLine("s1: {0}\n", s1);
        }

        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
