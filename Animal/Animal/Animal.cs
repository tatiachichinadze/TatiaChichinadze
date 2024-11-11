using Animal.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        protected Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract string MakeSound();
    }
}
