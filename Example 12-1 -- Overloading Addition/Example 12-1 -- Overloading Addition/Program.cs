using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_12_1____Overloading_Addition
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

        // overloaded operator + takes two fractions
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
            Fraction firstFraction = new Fraction(3, 4);
            Console.WriteLine("firstFraction: {0}", firstFraction.ToString());

            Fraction secondFraction = new Fraction(2, 4);
            Console.WriteLine("secondFraction: {0}", secondFraction.ToString());

            Fraction sumOfTwoFractions = firstFraction + secondFraction;
            Console.WriteLine( "firstFraction + secondFraction = sumOfTwoFractions: {0}", sumOfTwoFractions.ToString());

        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
