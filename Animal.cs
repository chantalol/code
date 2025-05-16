using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    public abstract class Dieren
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }

        public Dieren(string name, string species, int age)
        {
            Name = name;
            Species = species;
            Age = age;
        }

        public abstract void Eat();

        public abstract void MakeSound();

        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }

    }

    public class Dog : Dieren
    {
        public Dog(string name, int age) : base(name, "dog", age)
        {

        }
        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating chicken");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Woof");
        }

    }
    public class Cat : Dieren
    {
        public Cat(string name, int age) : base(name, "Cat", age)
        {

        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating fish");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
    public class Chicken : Dieren
    {
        public Chicken(string name, int age) : base(name, "Chicken", age)
        {

        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating grains");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bock Bock");
        }
    }

    public class Monkey : Dieren
    {
        public Monkey(string name, int age) : base(name, "Monkey", age)
        {

        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating Banana");
        }

        public override void MakeSound()
        {
            Console.WriteLine("u u a a");
        }
    }

    public class Sheep : Dieren
    {
        public Sheep(string name, int age) : base(name, "Sheep", age)
        {

        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating grass");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Baa");
        }
    }
}


