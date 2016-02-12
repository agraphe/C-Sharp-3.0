using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_14_3____Enumerable_Class
{
    public class ListBoxTest : IEnumerable<String>
    {
        private string[] strings;
        private int ctr = 0;

        // Enumerable classes return an enumerator
        public IEnumerator<string> GetEnumerator()
        {
            foreach (string s in strings)
            {
                yield return s;
            }
        }
        // required to fulfill IEnumerable
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        
        // initialize the ListBox with strings
        public ListBoxTest(params string[] initialStrings)
        {
            // allocate space for the strings
            strings = new String[256];

            // copy the strings passed in to the constructor
            foreach (string s in initialStrings)
            {
                strings[ctr++] = s;
            }
        }

        // add a single string to the end of the ListBox
        public void Add(string theString)
        {
            strings[ctr] = theString;
            ctr++;
        }

        // allow array-like access
        public string this[int index]
        {
            get
            {
                if (index < 0 || index >= strings.Length)
                {
                    // handle bad index
                }
                return strings[index];
            }
            set
            {
                strings[index] = value;
            }
        }

        // publish how many strings you hold
        public int GetNumEntries()
        {
            return ctr;
        }

    }

    public class Tester
    {
        static void Main()
        {
            // create a new ListBox and initialize
            ListBoxTest lbt = new ListBoxTest("Hello", "World");

            // add a few strings
            lbt.Add("Proust");
            lbt.Add("Faulkner");
            lbt.Add("Mann");
            lbt.Add("Hugo");

            // test the access
            string subst = "Universe";
            lbt[1] = subst;

            // access all the strings
            foreach (string s in lbt)
            {
                if (s == null)
                {
                    break;
                }

                Console.WriteLine("Value: {0}", s);
            }
        }
    }
}
