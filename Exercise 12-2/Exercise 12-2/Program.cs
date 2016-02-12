using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_12_2
{
    using System;

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
        public static Invoice operator +(Invoice lhs, Invoice rhs)
        {
            if (lhs.vendor == rhs.vendor)
            {
                return new Invoice(lhs.vendor, lhs.amount + rhs.amount);
            }
            Console.WriteLine("Vendors don't match; operation failed.");
            return new Invoice("", 0);
        }
        
        // overloaded equality operator
        public static bool operator ==(Invoice lhs, Invoice rhs)
        {
            if (lhs.vendor == rhs.vendor && lhs.amount == rhs.amount)
            {
                return true;
            }
            return false;
        }
        
        // overloaded inequality operator, delegates to ==
        public static bool operator !=(Invoice lhs, Invoice rhs)
        {
            return !(lhs == rhs);
        }
        
        // method for determining equality; tests for same type,
        // then delegates to ==
        public override bool Equals(object o)
        {
            if (!(o is Invoice))
            {
                return false;
            }
            return this == (Invoice)o;
        }

        public void PrintInvoice()
        {
            Console.WriteLine("Invoice from {0} for ${1}.", this.vendor,
                              this.amount);
        }
    }


    public class Tester
    {
        public void Run()
        {
            Invoice firstInvoice = new Invoice("TinyCorp", 399.65);
            Invoice secondInvoice = new Invoice("SuperMegaCo", 56389.53);
            Invoice thirdInvoice = new Invoice("SuperMegaCo", 399.65);
            Invoice testInvoice = new Invoice("SuperMegaCo", 399.65);
            if (testInvoice == firstInvoice)
            {
                Console.WriteLine("First invoice matches.");
            }
            else if (testInvoice == secondInvoice)
            {
                Console.WriteLine("Second invoice matches.");
            }
            else if (testInvoice == thirdInvoice)
            {
                Console.WriteLine("Third invoice matches.");
            }
            else
            {
                Console.WriteLine("No matching invoices.");
            }
        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
