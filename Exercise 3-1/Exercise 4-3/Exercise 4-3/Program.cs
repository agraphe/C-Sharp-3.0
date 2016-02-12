using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int weightAbby = 135;
            const int weightBob = 175;
            const int weightCharlie = 55;
            const int weightDawn = 45;
            const int minWeight = 100;
            const int maxWeight = 300;

            bool canRide;
            int weight1, weight2;

            // Abby + Bob
            weight1 = weightAbby;
            weight2 = weightBob;
            canRide = ((weight1 + weight2) > minWeight) && ((weight1 + weight2) <= maxWeight);
            Console.WriteLine("Abby and Bob can ride? {0}", canRide);

            // Bob + Charlie
            weight1 = weightBob;
            weight2 = weightCharlie;
            canRide = ((weight1 + weight2) > minWeight) && ((weight1 + weight2) <= maxWeight);
            Console.WriteLine("Bob and Charlie can ride? {0}", canRide);

            // Charlie + Dawn
            weight1 = weightCharlie;
            weight2 = weightDawn;
            canRide = ((weight1 + weight2) > minWeight) && ((weight1 + weight2) <= maxWeight);
            Console.WriteLine("Charlie and Dawn can ride? {0}", canRide);
            
        }
    }
}
