using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_12_3____Conversion_Operators
{
    public class Fraction
    {
        private int numerator;
        private int denominator;

        // create a fraction by passing in the numerator
        // and denominator
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        // overload the constructor to create a
        // fraction from a whole number
        public Fraction(int wholeNumber)
        {
            Console.WriteLine("In constructor taking a whole number");
            numerator = wholeNumber;
            denominator = 1;
        }
        
        // convert ints to Fractions implicitly
        public static implicit operator Fraction(int theInt)
        {
            Console.WriteLine("Implicitly converting int to Fraction");
            return new Fraction(theInt);
        }

        // convert Fractions to ints explicitly
        public static explicit operator int(Fraction theFraction)
        {
            Console.WriteLine("Explicitly converting Fraction to int");
            return theFraction.numerator / theFraction.denominator;

        }
        
        // overloaded operator + takes two fractions
        // and returns their sum
        public static Fraction operator +(Fraction lhs, Fraction rhs)
        {
            // like fractions (shared denominator) can be added
            // by adding their numerators
            if (lhs.denominator == rhs.denominator)
            {
                return new Fraction(lhs.numerator + rhs.numerator, lhs.denominator);
            }

            // simplistic solution for unlike fractions
            // 1/2 + 3/4 == (1*4) + (3*2) / (2*4) == 10/8
            // this method does not reduce.
            int firstProduct = lhs.numerator * rhs.denominator;
            int secondProduct = rhs.numerator * lhs.denominator;
            return new Fraction( firstProduct + secondProduct, lhs.denominator * rhs.denominator );
        }

        // test whether two Fractions are equal
        public static bool operator ==(Fraction lhs, Fraction rhs)
        {
            if (lhs.denominator == rhs.denominator && lhs.numerator == rhs.numerator)
            {
                return true;
            }
            // code here to handle unlike fractions
            return false;
        }

        // delegates to operator ==
        public static bool operator !=(Fraction lhs, Fraction rhs)
        {
            bool equality = lhs == rhs;
            return !(equality);
        }

        // tests for same types, then delegates
        public override bool Equals(object o)
        {
            if (!(o is Fraction))
            {
                return false;
            }
            return this == (Fraction)o;
        }

        // return a string representation of the fraction
        public override string ToString()
        {
            String s = numerator.ToString() + "/" + denominator.ToString();
            return s;
        }
    }


    public class Tester
    {
        public void Run()
        {
            Fraction f1 = new Fraction(3, 4);
            Fraction f2 = new Fraction(2, 4);
            Fraction f3 = f1 + f2;

            Console.WriteLine("adding f3 + 5...");
            Fraction f4 = f3 + 5;
            Console.WriteLine("f3 + 5 = f4: {0}", f4.ToString());

            Console.WriteLine("\nAssigning f4 to an int...");
            int truncated = (int)f4;
            Console.WriteLine("When you truncate f4 you get {0}",
            truncated);
        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
