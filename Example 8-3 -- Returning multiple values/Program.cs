using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_8_3____Returning_multiple_values
{
    class Doubler
    {
        public void DoubleInt(int firstNum, int secondNum)
        {
            firstNum = firstNum * 2;
            secondNum = secondNum * 2;
        }
    }
    class Tester
    {
        public void Run()
        {
            int first = 5;
            int second = 10;
            Console.WriteLine("Before doubling:");
            Console.WriteLine("First number: {0}, Second number: {1}", first, second);

            Doubler d = new Doubler();
            d.DoubleInt(first, second);
            Console.WriteLine("After doubling:");
            Console.WriteLine("First number: {0}, Second number: {1}", first, second);
        }

        static void Main(string[] args)
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
