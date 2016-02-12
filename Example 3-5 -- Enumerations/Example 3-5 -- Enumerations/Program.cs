using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_3_5____Enumerations
{
    class Values
    {
        // declare the enumeration
        enum Temperatures
        {
            WickedCold = 0,
            FreezingPoint = 32,
            LightJacketWeather = 60,
            SwimmingWeather = 72,
            BoilingPoint = 212,
        }

        static void Main()
        {
            System.Console.WriteLine("Freezing point of water: {0}",
                                     (int)Temperatures.FreezingPoint);
            System.Console.WriteLine("Boiling point of water: {0}",
                                     (int)Temperatures.BoilingPoint);
        }
    }
}