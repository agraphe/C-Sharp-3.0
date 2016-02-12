using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_8_2____Properties
{
    public class Box
    {
        // private variables
        private int length;
        private int width;
        private int height;
        
        // property
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }


        // public methods
        public void DisplayBox()
        {
            Console.WriteLine("Length: {0}, Width: {1}, Height: {2}", length, width, height);
        }

        // constructor
        public Box(int theLength, int theWidth, int theHeight)
        {
            length = theLength;
            width = theWidth;
            height = theHeight;
        }

    }

    public class Tester
    {
        public void Run()
        {
            // create a box for testing and display it
            Box testBox = new Box(3, 5, 7);
            testBox.DisplayBox();

            // access the length, store it in a local variable
            int testLength = testBox.Length;
            Console.WriteLine("Length of box is: {0}", testLength);

            // increment the length
            testLength++;

            // assign the new value to the member variable
            testBox.Length = testLength;

            // display the box again to test the new value
            testBox.DisplayBox();
        }

        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
