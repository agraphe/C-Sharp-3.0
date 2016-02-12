using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_7_2
{
    class Math
    {
        static public int Add( int left, int right )
        {
            return left + right;
        }
        static public int Subtract( int left, int right )
        {
            return left - right;
        }
        static public int Multiply( int left, int right )
        {
            return left * right;
        }
        static public float Divide( float left, float right )
        {
            return left / right;
        }
    }     // end class Math
    class Program
    {
        static void Main( string[] args )
        {
            int sum =         Math.Add( 3, 5 );
            int difference =  Math.Subtract(3,5);
            int product =     Math.Multiply(3,5);
            float quotient =  Math.Divide(3.0f, 5.0f);
            Console.WriteLine("sum: {0}, difference: {1}, product: {2}, quotient: {3}", sum, difference, product, quotient);
        }
    }
}
