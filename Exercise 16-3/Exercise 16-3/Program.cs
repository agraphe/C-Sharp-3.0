using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_16_3
{
    class Cat
    {
        public int Age { get; set; }
        public Cat(int age)
        {
            this.Age = age;
        }
    }
    class Tester
    {
        private void CatManager(Cat kitty)
        {
            Console.WriteLine("Managing a cat who is " + kitty.Age + " years old");
        }
        public void Run()
        {
            try
            {
                Console.WriteLine("Allocate resource that must be deallocated here");
                List<Cat> cats = new List<Cat>();
                cats.Add(new Cat(5));
                cats.Add(new Cat(7));
                CatManager(cats[1]); // pass in the second cat
                CatManager(cats[2]); // pass in the nonexistent third cat
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
