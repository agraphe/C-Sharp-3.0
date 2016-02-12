using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_5_15_The_Modulus_Operator
{
    class Program
    {

        public static void Main()
        {
            for (int counter = 1; counter <= 100; counter++)
            {
                Console.Write("{0} ", counter);

                if (counter % 10 == 0)
                {
                    Console.WriteLine("\t{0}", counter);
                }    
            }       
        }          
    }             
}
