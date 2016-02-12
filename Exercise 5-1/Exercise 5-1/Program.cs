using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_5_1
{
   class Program
   {
      static void Main()
      {
         Console.WriteLine( "while" );
         int counter = 1;
         while ( counter <= 10 )
         {
            Console.Write( counter );
            if ( counter < 10 )
            {
               Console.Write( ", " );
            }
            counter++;
         }
         Console.WriteLine( "\ndo..while" );
         counter = 1;
         do
         {
            Console.Write( counter );
            if ( counter < 10 )
            {
               Console.Write( ", " );
            }
            counter++;
         } while ( counter <= 10 );
         Console.WriteLine( "\nfor" );
         for ( int ctr = 1; ctr <= 10; ctr++ )
         {
            Console.Write( ctr );
            if ( ctr < 10 )
            {
               Console.Write( ", " );
            }
         }
         Console.WriteLine( "\nDone" );
      }
   }
}

