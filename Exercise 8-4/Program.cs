using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_8_4
{
    class Tester
    {
        public void Run()
        {
            Console.Write("Input an integer: ");
            int x = Convert.ToInt32(Console.ReadLine());
            int doubleX;      // uninitialized
            int tripleX;      // uninitialized
            DoublerAndTripler(x, out doubleX, out tripleX);
            Console.WriteLine("Double {0} = {1}; triple {2} = {3}", x, doubleX, x, tripleX);
        }
        static void DoublerAndTripler(int theVal, out int doubleValue, out int tripleValue)
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
