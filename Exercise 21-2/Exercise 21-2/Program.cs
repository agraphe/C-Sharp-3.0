using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Exercise_21_2
{
    [Table(Name = "Order Details")]
    public class OrderDetails
    {
        [Column] public int OrderID { get; set; }
        [Column] public int ProductID { get; set; }
        [Column] public short Quantity { get; set; }
    }

    class Program
    {
        static void Main()
        {
            DataContext db = new DataContext("Data Source = .\\SQLExpress;Initial Catalog=Northwind;Integrated Security=True");

            Table<OrderDetails> orderDetails = db.GetTable<OrderDetails>();
            var dbQuery = from od in orderDetails
                          where od.Quantity > 100
                          select od;

            Console.WriteLine("Products ordered in quantities of more than 100:");
            foreach (OrderDetails od in dbQuery)
            {
                Console.WriteLine("Order #{0}\tQty: {1}\tProduct:{2}", od.OrderID, od.Quantity, od.ProductID);
            }
        }
    }
}

