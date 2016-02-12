using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_14_5____Sorting_a_List
{
    // a simple class to store in the list
    public class Employee : IComparable<Employee>
    {
        private int empID;

        public Employee(int empID)
        {
            this.empID = empID;
        }

        public override string ToString()
        {
            return empID.ToString();
        }


        public bool Equals(Employee other)
        {
            if (this.empID == other.empID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Comparer delegates back to Employee
        // Employee uses the integer's default
        // CompareTo method


        public int CompareTo(Employee rhs)
        {
            return this.empID.CompareTo(rhs.empID);
        }

    }
    public class Tester
    {
        static void Main()
        {

            List<Employee> empList = new List<Employee>();
            List<Int32> intList = new List<Int32>();

            // generate random numbers for both the 
            // integers and the employee id's
            Random r = new Random();

            // populate the list
            for (int i = 0; i < 5; i++)
            {
                // add a random employee id
                empList.Add(new Employee(r.Next(10) + 100));

                // add a random integer
                intList.Add(r.Next(10));
            }
            
            // display all the contents of the int list
            Console.WriteLine("List<int> before sorting:");
            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write("{0} ", intList[i].ToString());
            }
            Console.WriteLine("\n");

            // display all the contents of the Employee list
            Console.WriteLine("List<Employee> before sorting:");
            for (int i = 0; i < empList.Count; i++)
            {
                Console.Write("{0} ", empList[i].ToString());
            }
            Console.WriteLine("\n");

            // sort and display the int list
            Console.WriteLine("List<int>after sorting:");
            intList.Sort();
            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write("{0} ", intList[i].ToString());
            }
            Console.WriteLine("\n");

            // sort and display the Employee list
            Console.WriteLine("List<Employee>after sorting:");
            
            //Employee.EmployeeComparer c = Employee.GetComparer();
            //empList.Sort(c);

            empList.Sort();
            
            // display all the contents of the Employee list
            for (int i = 0; i < empList.Count; i++)
            {
                Console.Write("{0} ", empList[i].ToString());
            }
            Console.WriteLine("\n");

        }
    }
}
