using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_14_1
{
    abstract public class Animal
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
            return "My name is " + this.name + ", I weigh " + this.weight + ", and I am a " + this.Breed + "\n";
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
            return "My name is " + this.name + ", I weigh " + this.weight + ", and I know how to purr!\n";
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
            Animal[] myAnimals = new Animal[5];
            myAnimals[0] = new Dog(72, "Milo", "Golden");
            myAnimals[1] = new Cat(12, "Shakespeare");
            myAnimals[2] = new Cat(10, "Allegra");
            myAnimals[3] = new Dog(50, "Dingo", "mixed breed");
            myAnimals[4] = new Dog(20, "Brandy", "Beagle");
            foreach (Animal a in myAnimals)
            {
                a.Speak();
                a.Move();
                Console.WriteLine(a);
                Cat c = a as Cat;  // cast to cat
                if (c != null)     // if it is a cat
                {
                    c.Purr();      // only cats purr
                }
            }
        }
        static void Main()
        {
            Tester t = new Tester();
            t.Run();
        }

    }
}
