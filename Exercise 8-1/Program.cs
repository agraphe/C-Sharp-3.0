using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_8_1
{
    class Tester
    {
        public void Run()
        {
            int x = 5;
            float y = 5.2f;
            Console.WriteLine("Triple {0} = {1}", x, Tripler(x));
            Console.WriteLine("Triple {0} = {1}", y, Tripler(y));
        }
        static int Tripler(int theVal)
        {
            return theVal * 3;
        }
        static float Tripler(float theVal)
        {
            return theVal * 3.0f;
        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
