using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_11_4
{
    public abstract class Telephone
    {
        protected string phonetype;
        public abstract void Ring(); // now abstract
    } // end abstract class Telephone

    public class DigitalPhone : Telephone
    {
        public DigitalPhone()
        {
            this.phonetype = "Digital";   // access protected member
        }
        public override void Ring()      // implement abstract method
        {
            Console.WriteLine("Ringing the {0} phone. Beep Beep.", phonetype);
        }
        public virtual void VoiceMail()
        {
            Console.WriteLine("You have a message. Press Play to retrieve.");
        }
    } //end class DigitalPhone

    public class TalkingPhone : Telephone
    {
        public TalkingPhone()
        {
            this.phonetype = "Talking";   // access protected member
        }
        public override void Ring()      // implement abstract method
        {
            Console.WriteLine("Ringing the {0} phone. You have a call.", phonetype);
        }
    } //end class TalkingPhone

    public class DigitalCellPhone : DigitalPhone
    {
        public DigitalCellPhone()
        {
            this.phonetype = "Digital Cell"; // access protected member
        }

        // no need to implement Ring(); it uses its parent class ring.

        public override void VoiceMail()
        {
            Console.WriteLine("You have a message. Call to retrieve.");
        }
    } // end class DigitalCellPhone
    
    public class Tester
    {
        public void Run()
        {
            // assign derived instance to base reference
            Telephone phone1 = new DigitalPhone();
            Telephone phone2 = new TalkingPhone();
            Telephone phone3 = new DigitalCellPhone();
            phone1.Ring(); // accessing the polymorphic method
            phone2.Ring(); // accessing the polymorphic method
            phone3.Ring(); // accessing the polymorphic method

            DigitalPhone phone4 = new DigitalPhone();
            DigitalPhone phone5 = new DigitalCellPhone();
            phone4.VoiceMail();
            phone5.VoiceMail();
        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
