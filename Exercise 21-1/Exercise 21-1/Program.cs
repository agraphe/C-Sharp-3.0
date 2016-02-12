using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_21_1
{
    public class Box
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public void DisplayBox()
        {
            Console.WriteLine("{0}x{1}x{2}", Length, Width, Height);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxList = new List<Box>
            {
                new Box { Length = 4,
                          Width = 6,
                          Height = 2 },
                new Box { Length = 3,
                          Width = 1,
                          Height = 4 },
                new Box { Length = 5,
                          Width = 12,
                          Height = 3 },
                new Box { Length = 4,
                          Width = 7,
                          Height = 5 },
                new Box { Length = 3,
                          Width = 7,
                          Height = 1 }
            };

            IEnumerable<Box> resultList =
                from myBox in boxList
                where myBox.Length > 3 && myBox.Width > 3
                select myBox;

            Console.WriteLine("Boxes greater than 3 units in length or width:");
            foreach (Box b in resultList)
            {
                b.DisplayBox();
            }
        }
    }
}
