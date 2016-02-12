using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_10_1
{
    public class Dog
    {
        public Dog(int theWeight, string theName)
        {
            this.weight = theWeight;
            this.name = theName;
        }
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private int weight;
        private string name;
    }
    public class Tester
    {
        public void Run()
        {
            Dog milo = new Dog(26, "Milo");
            Dog frisky = new Dog(10, "Frisky");
            Dog laika = new Dog(50, "Laika");
            Dog[] dogArray = { milo, frisky, laika };
            // output array values
            foreach (Dog d in dogArray)
            {
                Console.WriteLine("Dog {0} weighs {1} pounds.", d.Name, d.Weight);
            }
        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
