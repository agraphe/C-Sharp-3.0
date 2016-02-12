using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_8_1____Overloading
{
    public class Box
    {
        // private variables
        private int length;
        private int width;
        private int height;
        private string color;

        // public methods
        public void DisplayBox()
        {
            Console.WriteLine("Length: {0}, Width: {1}, Height: {2} Color: {3}", length, width, height, color);
        }

        // constructor
        public Box(int theLength, int theWidth, int theHeight)
        {
            length = theLength;
            width = theWidth;
            height = theHeight;
            color = "brown";
        }

        public Box(int theLength, int theWidth, int theHeight, string theColor)
        {
            length = theLength;
            width = theWidth;
            height = theHeight;
            color = theColor;
        }
    }

    public class Tester
    {
        public void Run()
        {
            Box box1 = new Box(4, 8, 3);
            box1.DisplayBox();
            Box blueBox = new Box(3, 5, 7, "blue");
            blueBox.DisplayBox();
        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
