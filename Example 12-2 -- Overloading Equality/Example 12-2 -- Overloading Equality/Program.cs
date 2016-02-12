using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_12_2____Overloading_Equality
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

        // overloaded operator+ takes two fractions
        // and returns their sum
        public static Fraction operator+ (Fraction lhs, Fraction rhs)
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
        public static bool operator== (Fraction lhs, Fraction rhs)
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
            return !(lhs == rhs);
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
            Console.WriteLine("f1: {0}", f1.ToString());

            Fraction f2 = new Fraction(2, 4);
            Console.WriteLine("f2: {0}", f2.ToString());

            Fraction f3 = f1 + f2;
            Console.WriteLine("f1 + f2 = f3: {0}", f3.ToString());

            Fraction f4 = new Fraction(5, 4);
            
            if (f4 == f3)
            {
                Console.WriteLine("f4: {0} == F3: {1}", f4.ToString(), f3.ToString());
            }

            if (f4 != f2)
            {
                Console.WriteLine("f4: {0} != F2: {1}", f4.ToString(), f2.ToString());
            }
            
            if (f4.Equals(f3))
            {
                Console.WriteLine("{0}.Equals({1})", f4.ToString(), f3.ToString());
            }
            
        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
