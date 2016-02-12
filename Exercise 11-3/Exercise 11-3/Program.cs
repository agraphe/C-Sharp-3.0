using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_11_3
{
    public abstract class Telephone
    {
        protected string phonetype;
        public abstract void Ring(); // now abstract
    }
    public class DigitalPhone : Telephone
    {
        public DigitalPhone()
        {
            this.phonetype = "Digital";   // access protected member
        }
        public override void Ring()      // implement
        {
            Console.WriteLine("Ringing the {0} phone. Beep Beep.", phonetype);
        }
    }
    public class TalkingPhone : Telephone
    {
        public TalkingPhone()
        {
            this.phonetype = "Talking";   // access protected member
        }
        public override void Ring()      // implement
        {
            Console.WriteLine("Ringing the {0} phone. You have a call.", phonetype);
        }
    }
    public class Tester
    {
        public void Run()
        {
            // assign derived instance to base reference
            Telephone phone1 = new DigitalPhone();
            Telephone phone2 = new TalkingPhone();
            phone1.Ring(); // accessing the polymorphic method
            phone2.Ring(); // accessing the polymorphic method
        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
