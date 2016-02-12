using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_11_2
{
    public class Telephone
    {
        protected string phonetype;
        public virtual void Ring()  // now virtual
        {
            Console.WriteLine("Ringing the {0} phone. Ring Ring.", phonetype);
        }
    }
    public class ElectronicPhone : Telephone
    {
        public ElectronicPhone()
        {
            this.phonetype = "Digital";   // access protected member
        }
        public override void Ring()      // override
        {
            Console.WriteLine("Ringing the {0} phone. Beep Beep.", phonetype);
        }
    }
    public class Tester
    {
        public void Run()
        {
            // assign derived instance to base reference
            Telephone phone = new ElectronicPhone();
            phone.Ring(); // accessing the polymorphic method
        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }

}
