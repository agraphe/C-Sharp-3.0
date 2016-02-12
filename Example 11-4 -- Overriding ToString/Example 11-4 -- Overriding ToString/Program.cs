using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_11_4____Overriding_ToString
{
    public class Dog
    {
        private int weight;

        // constructor
        public Dog(int weight)
        {
            this.weight = weight;
        }

        // override Object.ToString
        public override string ToString()
        {
            return weight.ToString();
        }
    }

    public class Tester
    {
        static void Main()
        {
            int i = 5;
            Console.WriteLine("The value of i is: {0}", i.ToString());

            Dog milo = new Dog(62);
            Console.WriteLine("My dog Milo weighs {0} pounds", milo);
        }
    }
}
