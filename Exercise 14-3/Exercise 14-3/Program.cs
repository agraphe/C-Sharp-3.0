using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_14_3
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

        public Dog(int weight, string name, string breed)
            : base(weight, name)
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
        public Cat(int weight, string name)
            : base(weight, name)
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
            Console.WriteLine("Adding in the order: Milo, Shakespeare, Allegra, Dingo, Brandy");
            Stack<Animal> myStackOfAnimals = new Stack<Animal>();
            myStackOfAnimals.Push(new Dog(72, "Milo", "Golden"));
            myStackOfAnimals.Push(new Cat(12, "Shakespeare"));
            myStackOfAnimals.Push(new Cat(10, "Allegra"));
            myStackOfAnimals.Push(new Dog(50, "Dingo", "mixed breed"));
            myStackOfAnimals.Push(new Dog(20, "Brandy", "Beagle"));

            Queue<Animal> myQueueOfAnimals = new Queue<Animal>();
            myQueueOfAnimals.Enqueue(new Dog(72, "Milo", "Golden"));
            myQueueOfAnimals.Enqueue(new Cat(12, "Shakespeare"));
            myQueueOfAnimals.Enqueue(new Cat(10, "Allegra"));
            myQueueOfAnimals.Enqueue(new Dog(50, "Dingo", "mixed breed"));
            myQueueOfAnimals.Enqueue(new Dog(20, "Brandy", "Beagle"));

            Console.WriteLine("The stack...");
            foreach (Animal a in myStackOfAnimals)
            {
                Console.WriteLine(a);
            }
            
            Console.WriteLine("The queue...");
            foreach (Animal a in myQueueOfAnimals)
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
