using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_16_5____finally_Block
{
    class Tester
    {
        public void Run()
        {
            try
            {
                Console.WriteLine("Open file here.");
                double a = 5;
                double b = 0;
                Console.WriteLine("{0} / {1} = {2}", a, b, DoDivide(a, b));
                Console.WriteLine("This line may or may not print");
            }

            // most derived exception type first
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException caught!");
            }
            catch
            {
                Console.WriteLine("Unknown exception caught");
            }
            finally
            {
                Console.WriteLine("Close file here.");
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
