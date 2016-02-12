using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_7_4
{
    public class Point
    {
        public int xCoord;
        public int yCoord;

        public void DisplayPoint()
        {
            Console.WriteLine("({0}, {1})", xCoord, yCoord);
        }

        //constructor
        public Point(int x, int y)
        {
            xCoord = x;
            yCoord = y;
        }
    }

    public class Square
    {
        private Point topLeft;
        private Point topRight;
        private Point bottomRight;
        private Point bottomLeft;
        private int sideLength;

        public void displaySquare()
        {
            Console.WriteLine("The four corners are:");
            topLeft.DisplayPoint();
            topRight.DisplayPoint();
            bottomLeft.DisplayPoint();
            bottomRight.DisplayPoint();
        }

        //constructor
        public Square(Point myPoint, int myLength)
        {
            sideLength = myLength;
            topLeft = myPoint;
            topRight = new Point(topLeft.xCoord + sideLength, topLeft.yCoord);
            bottomLeft = new Point(topLeft.xCoord, topLeft.yCoord + sideLength);
            bottomRight = new Point(topLeft.xCoord + sideLength, topLeft.yCoord + sideLength);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point startPoint = new Point(3, 3);
            int length = 5;
            Square mySquare = new Square(startPoint, length);
            mySquare.displaySquare();
        }
    }
}
