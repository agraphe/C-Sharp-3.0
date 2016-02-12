using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_16_6____Exception_Class_Properties
{
    class Tester
    {
        public void Run()
        {
            try
            {
                Console.WriteLine("Open file here");
                double a = 12;
                double b = 0;
                Console.WriteLine("{0} / {1} = {2}", a, b, DoDivide(a, b));
                Console.WriteLine("This line may or may not print");
            }

            // most derived exception type first
            catch (DivideByZeroException e)
            {
                Console.WriteLine("\nDivideByZeroException! Msg: {0}", e.Message);
                Console.WriteLine("\nHelpLink: {0}", e.HelpLink);
                Console.WriteLine("\nHere's a stack trace: {0}\n", e.StackTrace);
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
                DivideByZeroException e = new DivideByZeroException();
                e.HelpLink = "http://www.libertyassociates.com";
                throw e;
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
