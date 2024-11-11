using System;

namespace Animal
{


    public class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age) { }

        public override string MakeSound()
        {
            return "Woof";
        }
    }

    public class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age) { }

        public override string MakeSound()
        {
            return "Meow";
        }
    }

    public class Cow : Animal
    {
        public Cow(string name, int age) : base(name, age) { }

        public override string MakeSound()
        {
            return "Moo";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            Animal[] animals = new Animal[]
            {
                new Dog("Milo", 3),   
                new Cat("Lusi", 2), 
                new Cow("Chrela", 5)     
            };

            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.GetType().Name} says: {animal.MakeSound()}");
            }
        }
    }
}
