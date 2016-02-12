using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_10_3
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
            const int rows = 3;
            // declare and populate the dogs array
            Dog milo = new Dog(26, "Milo");
            Dog frisky = new Dog(10, "Frisky");
            Dog laika = new Dog(50, "Laika");
            Dog[] dogArray = { milo, frisky, laika };

            // declare the dogAwards array as 3 rows high
            string[][] dogAwardsArray = new string[rows][];
            
            // declare the rows
            dogAwardsArray[0] = new string[3];
            dogAwardsArray[1] = new string[1];
            dogAwardsArray[2] = new string[2];
            
            // Populate the rows
            dogAwardsArray[0][0] = "Best in Show";
            dogAwardsArray[0][1] = "Best of Breed";
            dogAwardsArray[0][2] = "Judge's Cup";
            dogAwardsArray[1][0] = "Best Toy Tog";
            dogAwardsArray[2][0] = "Best Working Dog";
            dogAwardsArray[2][1] = "Best Large Dog";
            
            // Output the contents
            for (int i = 0; i < dogAwardsArray.Length; i++)
            {
                Console.WriteLine("{0}'s awards: ", dogArray[i].Name);
                for (int j = 0; j < dogAwardsArray[i].Length; j++)
                {
                    Console.WriteLine("\t{0}", dogAwardsArray[i][j]);
                }
            }
        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
