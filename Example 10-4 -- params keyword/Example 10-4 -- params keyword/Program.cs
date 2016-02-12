using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_10_4____params_keyword
{
    public class Tester
    {
        static void Main()
        {
            Tester t = new Tester();
            t.DisplayVals(5, 6, 7, 8);
            int[] explicitArray = new int[] { 1, 2, 3, 4, 5 };
            t.DisplayVals(explicitArray);
        }

        public void DisplayVals(params int[] intVals)
        {
            foreach (int i in intVals)
            {
                Console.WriteLine("DisplayVals {0}", i);
            }
        }
    }
}
