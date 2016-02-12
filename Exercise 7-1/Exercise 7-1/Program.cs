using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_7_1
{
   class Math
   {
      public int Add( int left, int right )
      {
        return left + right;
      }
      public int Subtract( int left, int right )
      {
          return left - right;
      }
       public int Multiply( int left, int right )
       {
           return left * right;
       }
       public float Divide( float left, float right )
       {
           return left / right;
       }
   }     // end class Math
   class Program
   {
       static void Main()
       {
           Math m = new Math();
           int sum =         m.Add(3,5);
           int difference =  m.Subtract(3,5);
           int product =     m.Multiply(3,5);
           float quotient =  m.Divide(3.0f, 5.0f);
           Console.WriteLine("sum: {0}, difference: {1}, product: {2}, quotient: {3}", sum, difference, product, quotient);
       }
   }
}
