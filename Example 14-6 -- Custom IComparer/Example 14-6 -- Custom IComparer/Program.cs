using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_14_6____Custom_IComparer
{
    public class Employee : IComparable<Employee>
    {
        private int empID;

        private int yearsOfSvc = 1;

        public Employee(int empID)
        {
            this.empID = empID;
        }
        
        public Employee(int empID, int yearsOfSvc)
        {
            this.empID = empID;
            this.yearsOfSvc = yearsOfSvc;
        }
        
        public override string ToString()
        {
            return "ID: " + empID.ToString() + ". Years of Svc: " + yearsOfSvc.ToString();
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

        // static method to get a Comparer object
        public static EmployeeComparer GetComparer()
        {
            return new Employee.EmployeeComparer();
        }
        
        // Comparer delegates back to Employee
        // Employee uses the integer's default
        // CompareTo method
        public int CompareTo(Employee rhs)
        {
            return this.empID.CompareTo(rhs.empID);
        }
                
        // Special implementation to be called by custom comparer
        public int CompareTo(Employee rhs, Employee.EmployeeComparer.ComparisonType which)
        {
            switch (which)
            {
                case Employee.EmployeeComparer.ComparisonType.EmpID:
                    return this.empID.CompareTo(rhs.empID);
                case Employee.EmployeeComparer.ComparisonType.YearsOfService:
                    return this.yearsOfSvc.CompareTo(rhs.yearsOfSvc);
            }
            return 0;
        }


        // nested class which implements IComparer
        public class EmployeeComparer : IComparer<Employee>
        {
            // private state variable
            private Employee.EmployeeComparer.ComparisonType whichComparison;
            // enumeration of comparsion types
            public enum ComparisonType
            {
                EmpID,
                YearsOfService
            };
            
            public bool Equals(Employee lhs, Employee rhs)
            {
                return this.Compare(lhs, rhs) == 0;
            }
            
            // Tell the Employee objects to compare themselves
            public int Compare(Employee lhs, Employee rhs)
            {
                return lhs.CompareTo(rhs, WhichComparison);
            }

            public Employee.EmployeeComparer.ComparisonType WhichComparison
            {
                get { return whichComparison; }
                set { whichComparison = value; }
            }
        }
    }
    public class Tester
    {
        static void Main()
        {
            List<Employee> empList = new List<Employee>();

            // generate random numbers for
            // both the integers and the
            // employee IDs
            Random r = new Random();

            // populate the list
            for (int i = 0; i < 5; i++)
            {
                // add a random employee ID
                empList.Add(new Employee(r.Next(10) + 100, r.Next(20)));
            }

            // display all the contents of the Employee list
            for (int i = 0; i < empList.Count; i++)
            {
                Console.Write("\n{0} ", empList[i].ToString());
            }
            Console.WriteLine("\n");
            
            // sort and display the employee list
            Employee.EmployeeComparer c = Employee.GetComparer();
            c.WhichComparison = Employee.EmployeeComparer.ComparisonType.EmpID;
            empList.Sort(c);
            
            // display all the contents of the Employee list
            for (int i = 0; i < empList.Count; i++)
            {
                Console.Write("\n{0} ", empList[i].ToString());
            }
            Console.WriteLine("\n");
            
            c.WhichComparison = Employee.EmployeeComparer.ComparisonType.YearsOfService;
            empList.Sort(c);
            
            for (int i = 0; i < empList.Count; i++)
            {
                Console.Write("\n{0} ", empList[i].ToString());
            }
            Console.WriteLine("\n");
        }
    }
}
