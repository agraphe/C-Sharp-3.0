using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_10_4
{
    public class Tester
    {
        public void Run()
        {
            const int rows = 8;
            const int columns = 8;

            // create an 8x8 array
            string[,] chessboardArray = new string[rows, columns];
            
            // populate the chessboard array
            for (int i = 0; i < rows; i++)
            {
                // if row starts with a black square
                if ((i % 2) == 0)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if ((j % 2) == 0)
                        {
                            chessboardArray[i, j] = "black";
                        }
                        else
                        {
                            chessboardArray[i, j] = "white";
                        }
                    }
                }
                // else row starts with a white square
                else
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if ((j % 2) == 0)
                        {
                            chessboardArray[i, j] = "white";
                        }
                        else
                        {
                            chessboardArray[i, j] = "black";
                        }
                    }
                }
            }
            
            // ask the user for coordinates to test
            Console.Write("Enter the row to test (1 through 8): ");
            string rowEntry = Console.ReadLine();
            int testRow = Convert.ToInt32(rowEntry);
            Console.Write("Enter the column to test (1 through 8): ");
            string colEntry = Console.ReadLine();
            int testCol = Convert.ToInt32(colEntry);

            // output the value at those coordinates
            Console.WriteLine("The square at {0}, {1} is {2}.", testRow,
            testCol, chessboardArray[(testRow - 1), (testCol - 1)]);
        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
