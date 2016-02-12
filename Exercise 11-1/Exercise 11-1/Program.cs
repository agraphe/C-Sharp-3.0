using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_11_1
{
    public class Telephone
    {
        protected string phonetype;
        public void Ring()
        {
            Console.WriteLine("Ringing the {0} phone...", phonetype);
        }
    }
    public class ElectronicPhone : Telephone
    {
        public ElectronicPhone()
        {
            this.phonetype = "Digital";   // access protected member
        }
    }

    public class Tester
    {

        public void Run()
        {
            ElectronicPhone phone = new ElectronicPhone();
            phone.Ring(); // accessing the base method
        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
