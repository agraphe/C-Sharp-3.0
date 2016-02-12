using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_21_7____Object_Relational_Designer
{
    class Program
    {
        static void Main()
        {
            DataClasses1DataContext myContext = new DataClasses1DataContext();

            // find a single product record
            Product foundProduct = myContext.Products.Single(p => p.ProductID == 1);
            Console.WriteLine("Found product #{0}, {1}", foundProduct.ProductID, foundProduct.ProductName);

            // return a list of order records
            var orderList =
                from order in myContext.Order_Details
                where order.OrderID >= 10250 && order.OrderID <= 10255
                select order;

            Console.WriteLine("\nProduct Orders between 10250 and 10255");
            foreach (Order_Detail order in orderList)
            {
                Console.WriteLine("ID: {0}\tQty: {1}\tProduct: {2}", order.OrderID, order.Quantity, order.Product.ProductName);
            }
        }
    }
}
