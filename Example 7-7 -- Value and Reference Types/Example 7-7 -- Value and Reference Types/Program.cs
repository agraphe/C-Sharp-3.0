using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Example_7_7____Value_and_Reference_Types
{
   public class Dog
   {
      public int weight;
   }

   class Tester
   {
      public void Run()
      {
         // create an integer
         int firstInt = 5;

         // create a second integer
         int secondInt = firstInt;

         // display the two integers
         Console.WriteLine( "firstInt: {0} secondInt: {1}", firstInt, secondInt );

         // modify the second integer
         secondInt = 7;

         // display the two integers
         Console.WriteLine( "firstInt: {0} secondInt: {1}", firstInt, secondInt );

         // create a dog
         Dog milo = new Dog();

         // assign a value to weight
         milo.weight = 5;

         // create a second reference to the dog
         Dog fido = milo;

         // display their values
         Console.WriteLine( "milo: {0}, fido: {1}", milo.weight, fido.weight );

         // assign a new weight to the second reference
         fido.weight = 7;

         // display the two values
         Console.WriteLine( "milo: {0}, fido: {1}", milo.weight, fido.weight );
      }

      static void Main()
      {
         Tester t = new Tester();
         t.Run();
      }
   }
}

