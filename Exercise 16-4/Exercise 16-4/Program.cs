using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_16_4
{
    class Cat
    {
        public int Age { get; set;}
        public Cat(int age)
        {
            this.Age = age;
        }
    }

    // custom exception class
    public class CustomCatException : System.ApplicationException
    {
        public CustomCatException(string message) : base(message) // pass the message up to the base class
        {
        }
    }
    
    class Tester
    {
        private void CheckCat(Cat testCat)
        {
            if (testCat.Age <= 0)
            {
                // create a custom exception instance
                CustomCatException e = new CustomCatException("Your cat is too young.");
                e.HelpLink = "http://www.libertyassociates.com";
                throw e;
            }
        }
        private void CatManager(Cat kitty)
        {
            CheckCat(kitty);
            Console.WriteLine("Managing a cat who is " + kitty.Age + " years old");
        }
        public void Run()
        {
            try
            {
                Console.WriteLine("Allocate resource that must be deallocated here");
                List<Cat> cats = new List<Cat>();
                cats.Add(new Cat(7));
                cats.Add(new Cat(-2));
                CatManager(cats[0]); // pass in the first cat
                CatManager(cats[1]); // pass in the second cat
            }
            // catch custom exception
            catch (CustomCatException e)
            {
                Console.WriteLine("\nCustomCatException! Msg: {0}", e.Message);
                Console.WriteLine("\nHelpLink: {0}\n", e.HelpLink);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("We're sorry; your cat does not exist.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Unknown exception caught" + e.Message);
            }
            finally
            {
                Console.WriteLine("Deallocation of resource here.");
            }
        }
        static void Main()
        {
            Console.WriteLine("Enter Main...");
            Tester t = new Tester();
            t.Run();
            Console.WriteLine("Exit Main...");
        }
    }
}
