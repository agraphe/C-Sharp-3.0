using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_5_4
{
    class Program
    {
        static void Main()
        {
            int i;
            int j;
            for (i = 0, j = 25; i < j; ++i, --j )
            {
                Console.WriteLine("i: {0}; j: {1}", i, j);
            }
            Console.WriteLine( "Crossed over! i: {0}; j: {1}", i, j );
        }
    }
}
