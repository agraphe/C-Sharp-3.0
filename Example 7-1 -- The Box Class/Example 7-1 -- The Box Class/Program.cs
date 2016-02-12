using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_7_1____The_Box_Class
{
    public class Box
    {
        // private variables
        private int length;
        private int width;
        private int height;

        // public methods
        public void DisplayBox()
        {
            Console.WriteLine("Stub for displaying the box.");
        }
    }

    public class Tester
    {
        static void Main()
        {
            Box boxObject = new Box();
            boxObject.DisplayBox();
        }
    }
}
