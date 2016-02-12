using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_4_4
{
    class Program
    {
        static void Main()
        {
            const float Pi = 3.14159f;
            const float radius = 5f;
            float surfaceArea = 4f * Pi * (radius * radius);
            Console.WriteLine("Surface area is: {0}", surfaceArea);
            float volume = (4f / 3f) * Pi * (radius * radius * radius);
            Console.WriteLine("Volume is: {0}", volume);
            float greater = surfaceArea > volume ? surfaceArea : volume;
            Console.WriteLine("The greater of these is: {0}", greater);

        }
    }
}
