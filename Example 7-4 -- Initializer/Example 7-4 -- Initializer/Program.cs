using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_7_4____Initializer
{
    public class Box
    {
        // private variables
        private int length;
        private int width;
        private int height = 6;

        // public methods
        public void DisplayBox()
        {
            Console.WriteLine("Length: {0}, Width: {1}, Height: {2}", length, width, height);
        }

        // constructor
        public Box(int theLength, int theWidth)
        {
            length = theLength;
            width = theWidth;
        }
    }

    public class Tester
    {
        static void Main()
        {
            Box boxObject = new Box(4, 8);
            boxObject.DisplayBox();
        }
    }
}
