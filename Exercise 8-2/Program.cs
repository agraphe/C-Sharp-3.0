using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_8_2
{
    public class Dog
    {
        private int weight;
        private string color;

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

        public string Color 
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        } 

        public void DisplayDog()
        {
            Console.WriteLine("The dog weighs {0} pounds and is {1}.", weight, color);
        }

        public Dog(int myWeight, string myColor)
        {
            weight = myWeight;
            color = myColor;
        }
    }

    class Tester
    {
        public void Run()
        { 
            Dog fluffy = new Dog(25, "brown");
            fluffy.DisplayDog();
            Console.WriteLine("The dog is still {0}.", fluffy.Color);
            Console.Write("What is the dog's new weight? ");
            int newWeight = Convert.ToInt32(Console.ReadLine());
            fluffy.Weight = newWeight;
            fluffy.DisplayDog();

        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
