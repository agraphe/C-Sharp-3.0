using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_21_3
{
    class Program
    {
        static void Main()
        {
            DataClasses1DataContext db = new DataClasses1DataContext();

            var orderList =
                from o in db.Orders
                where o.Customer.CompanyName == "Ernst Handel"
                select new { o.Employee.FirstName, o.Employee.LastName };

            Console.WriteLine("Employees who've contacted Ernst Handel:");
            foreach(var order in orderList)
            {
                Console.WriteLine("{0} {1}", order.FirstName, order.LastName );
            }

        }
    }
}
