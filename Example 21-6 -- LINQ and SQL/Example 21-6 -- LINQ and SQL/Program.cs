using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Example_21_6____LINQ_and_SQL
{
    [Table(Name = "Employees")]
    public class Employee
    {
        [Column] public int EmployeeID { get; set; }
        [Column] public string FirstName { get; set; }
        [Column] public string LastName { get; set; }
    }

    class Program
    {
        static void Main()
        {
            DataContext db = new DataContext("Data Source = .\\SQLExpress;Initial Catalog=Northwind;Integrated Security=True");

            Table<Employee> employees = db.GetTable<Employee>();
            var dbQuery = from emp in employees
                          select emp;

            foreach (var employee in dbQuery)
            {
                Console.WriteLine("{0}\t{1} {2}", employee.EmployeeID, employee.FirstName, employee.LastName);
            }
        }
    }
}
