using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_10_2____Arrays_and_Objects
{
    // a simple class to store in the array
    public class Employee
    {
        public int EmpID { get; set; }

        public Employee(int empID)
        {
            EmpID = empID;
        }
    }
    public class Tester
    {
        static void Main()
        {
            Employee[] empArray;
            empArray = new Employee[3];

            // populate the arrays
            for (int i = 0; i < empArray.Length; i++)
            {
                empArray[i] = new Employee(i + 1005);
            }

            // output array values
            Console.WriteLine("\nemployee IDs:");
            for (int i = 0; i < empArray.Length; i++)
            {
                Console.WriteLine(empArray[i].EmpID);
            }
        }
    }
}
