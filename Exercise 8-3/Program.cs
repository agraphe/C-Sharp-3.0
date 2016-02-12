using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_8_3
{
    class Tester
    {
        public void Run()
        {
            Console.Write("Input an integer: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int doubleX = 0;
            int tripleX = 0;
            DoublerAndTripler(x, ref doubleX, ref tripleX);
            Console.WriteLine("Double {0} = {1}; triple {2} = {3}", x, doubleX, x, tripleX);
        }
        static void DoublerAndTripler(int theVal, ref int doubleValue, ref int tripleValue)
        {
            doubleValue = theVal * 2;
            tripleValue = theVal * 3;
        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
