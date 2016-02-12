using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_14_2
{
    abstract public class Animal : IComparable
    {
        protected int weight;
        protected string name;
        public Animal(int weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }
        abstract public void Speak();
        abstract public void Move();
        abstract public override string ToString();

        public int CompareTo(Object rhs)
        {
            Animal otherAnimal = rhs as Animal;
            if (otherAnimal != null)
            {
                return this.weight.CompareTo(otherAnimal.weight);
            }
            else
            {
                throw new ApplicationException("Expected to compare animals");
            }
        }
    }

    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(int weight, string name, string breed) : base(weight, name)
        {
            this.Breed = breed;
        }
        public override void Speak()
        { 
            Console.WriteLine("Woof"); 
        }
        public override void Move()
        {
            Console.WriteLine("Run, run, run, drool."); 
        }
        public override string ToString()
        {
            return "My name is " + this.name + ", I weigh " + this.weight + ", and I am a " + this.Breed;
        }
    }

    public class Cat : Animal
    {
        public Cat(int weight, string name) : base(weight, name)
        { 
        }

        public override void Speak()
        {
            Console.WriteLine("Meow"); 
        }
        public override void Move()
        {
            Console.WriteLine("Run, tumble, nap."); 
        }
        public override string ToString()
        {
            return "My name is " + this.name + ", I weigh " + this.weight + ", and I know how to purr!";
        }
        public void Purr()
        {
            Console.WriteLine("Purrrrrrrrrrrrrrrrrrrrrrrrrr\n");
        }
    }

    public class Tester
    {
        public void Run()
        {
            List<Animal> myAnimals = new List<Animal>();
            myAnimals.Add(new Dog(72, "Milo", "Golden"));
            myAnimals.Add(new Cat(12, "Shakespeare"));
            myAnimals.Add(new Cat(10, "Allegra"));
            myAnimals.Add(new Dog(50, "Dingo", "mixed breed"));
            myAnimals.Add(new Dog(20, "Brandy", "Beagle"));
            foreach (Animal a in myAnimals)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("\nAfter sorting by size...");
            myAnimals.Sort();
            foreach (Animal a in myAnimals)
            {
                Console.WriteLine(a);
            }
        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }
    }
}
