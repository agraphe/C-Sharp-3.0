using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise_14_4
{
    abstract public class Animal : IComparable<Animal>
    {
        protected int weight;
        protected string name;
        public Animal(int weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }
        // ** new **
        public static AnimalComparer GetComparer()
        {
            return new Animal.AnimalComparer();
        }
        public int CompareTo(Animal rhs)
        {
            return this.weight.CompareTo(rhs.weight);
        }
        // ** new **
        public int CompareTo(Animal rhs, Animal.AnimalComparer.ComparisonType whichComparison)
        {
            switch (whichComparison)
            {
                case AnimalComparer.ComparisonType.Name:
                    return this.name.CompareTo(rhs.name);
                case AnimalComparer.ComparisonType.Size:
                    return this.weight.CompareTo(rhs.weight);
            }
            return -1;  // all paths must return a value
        }

        // nested class   ** new **
        public class AnimalComparer : IComparer<Animal>
        {
            // how do you want to compare?
            public enum ComparisonType
            {
                Size,
                Name
            };
            private Animal.AnimalComparer.ComparisonType whichComparison;
            public Animal.AnimalComparer.ComparisonType WhichComparison
            {
                get { return whichComparison; }
                set { whichComparison = value; }
            }

            // compare two Animals using the previously set
            // whichComparison value
            public int Compare(Animal lhs, Animal rhs)
            {
                return lhs.CompareTo(rhs, whichComparison);
            }
        }     // end nested class
    }        // end class Animal


    public class Dog : Animal
    {
        public Dog(int weight, string name, string breed) :
            base(weight, name)
        { }
        public override string ToString()
        {
            return "My name is " + this.name + ", and I weigh " + this.weight;
        }
    }

    public class Cat : Animal
    {
        public Cat(int weight, string name) :
            base(weight, name)
        { }
        public override string ToString()
        {
            return "My name is " + this.name + ", and I weigh " + this.weight;
        }
    }

    public class Tester
    {
        public void Run()
        {
            List<Animal> myAnimals = new List<Animal>();
            myAnimals.Add(new Dog(70, "Milo", "Golden"));
            myAnimals.Add(new Cat(10, "Shakespeare"));
            myAnimals.Add(new Cat(15, "Allegra"));
            myAnimals.Add(new Dog(50, "Dingo", "mixed breed"));
            myAnimals.Add(new Dog(20, "Brandy", "Beagle"));
            Console.WriteLine("Before sorting...");
            foreach (Animal a in myAnimals)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("\nAfter sorting by default (weight)...");
            myAnimals.Sort();
            foreach (Animal a in myAnimals)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("\nAfter sorting by name...");
            Animal.AnimalComparer animalComparer = Animal.GetComparer();
            animalComparer.WhichComparison = Animal.AnimalComparer.ComparisonType.Name;
            myAnimals.Sort(animalComparer);
            foreach (Animal a in myAnimals)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("\nAfter sorting explicitly by size...");
            animalComparer.WhichComparison = Animal.AnimalComparer.ComparisonType.Size;
            myAnimals.Sort(animalComparer);
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
