using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_12_4
{
    public class Foot
    {
        private double length;

        public static explicit operator Meter(Foot theFoot)
        {
            return new Meter(theFoot.length * 0.3048);
        }

        public void OutputFoot()
        {
            Console.Write("{0} feet", length);
        }

        // constructor
        public Foot(double length)
        {
            this.length = length;
        }
    }

    public class Meter
    {
        private double length;

        public static explicit operator Foot (Meter theMeter)
        {
            return new Foot(theMeter.length * 3.28);
        }

        public void OutputMeter()
        {
            Console.Write("{0} meters", length);
        }

        // constructor
        public Meter(double length)
        {
            this.length = length;
        }
    }

    class Tester
    {
        public void Run()
        {
            Foot myFoot = new Foot(5);
            Meter myMeter = new Meter(3);

            Console.Write("Length of myFoot = ");
            myFoot.OutputFoot();
            Console.Write(", ");
            ((Meter)myFoot).OutputMeter();
            Console.WriteLine();

            Console.Write("Length of myMeter = ");
            myMeter.OutputMeter();
            Console.Write(", ");
            ((Foot)myMeter).OutputFoot();
            Console.WriteLine();
            
        }

        static void Main(string[] args)
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
