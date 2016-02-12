using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_16_4____Dedicated_catch_Statements
{
    class Tester
    {

        public void Run()
        {
            try
            {
                double a = 7;
                double b = 0;
                Console.WriteLine("Dividing {0} by {1}...", a, b);
                Console.WriteLine("{0} / {1} = {2}", a, b, DoDivide(a, b));
            }

            // most specific exception type first
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException caught!");
            }

            catch (ArithmeticException)
            {
                Console.WriteLine("ArithmeticException caught!");
            }

            // generic exception type last
            catch
            {
                Console.WriteLine("Unknown exception caught");
            }
        }

        // do the division if legal
        public double DoDivide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            if (a == 0)
            {
                throw new ArithmeticException();
            }
            return a / b;
        }

        static void Main()
        {
            Console.WriteLine("Enter Main...");
            Tester t = new Tester();
            t.Run();
            Console.WriteLine("Exit Main...");
        }
    }
}
