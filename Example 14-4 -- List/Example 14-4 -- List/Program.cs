﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_14_4____List
{
    // a simple class to store in the List
    public class Employee
    {
        private int empID;

        public Employee(int empID) //constructor
        {
            this.empID = empID;
        }
        public override string ToString()
        {
            return empID.ToString();
        }
    }

    public class Tester
    {
        static void Main()
        {

            List<Employee> empList = new List<Employee>();
            List<int> intList = new List<int>();

            // populate the Lists
            for (int i = 0; i < 5; i++)
            {
                intList.Add(i * 5);
                empList.Add(new Employee(i + 100));
            }

            // print the contents of the int List
            for (int i = 0; i < intList.Count; i++)
            {
                Console.Write("{0} ", intList[i].ToString());
            }

            Console.WriteLine("\n");

            // print the contents of the Employee List
            for (int i = 0; i < empList.Count; i++)
            {
                Console.Write("{0} ", empList[i].ToString());
            }

            Console.WriteLine("\n");
            Console.WriteLine("empList.Capacity: {0}", empList.Capacity);
        }
    }
}
