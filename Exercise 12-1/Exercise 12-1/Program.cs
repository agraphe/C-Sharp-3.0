using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_12_1
{
    public class Invoice
    {
        private string vendor;
        private double amount;
        // constructor

        public Invoice(string vendor, double amount)
        {
            this.vendor = vendor;
            this.amount = amount;
        }
        // Overloaded operator + takes two invoices.
        // If the vendors are the same, the two amounts are added.
        // If not, the operation fails, and a blank invoice is returned.
        public static Invoice operator+ (Invoice lhs, Invoice rhs)
        {
            if (lhs.vendor == rhs.vendor)
            {
                return new Invoice(lhs.vendor, lhs.amount + rhs.amount);
            }
            Console.WriteLine("Vendors don't match; operation failed.");
            return new Invoice("", 0);
        }
        public void PrintInvoice()
        {
            Console.WriteLine("Invoice from {0} for ${1}.", vendor, amount);
        }
    }


    public class Tester
    {
        public void Run()
        {
            Invoice firstInvoice = new Invoice("TinyCorp", 345);
            Invoice secondInvoice = new Invoice("SuperMegaCo", 56389.53);
            Invoice thirdInvoice = new Invoice("SuperMegaCo", 399.65);
            Console.WriteLine("Adding first and second invoices.");
            Invoice addedInvoice = firstInvoice + secondInvoice;
            addedInvoice.PrintInvoice();
            Console.WriteLine("Adding second and third invoices.");
            Invoice otherAddedInvoice = secondInvoice + thirdInvoice;
            otherAddedInvoice.PrintInvoice();
        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
