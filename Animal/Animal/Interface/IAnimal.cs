using Animal.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Interface
{
    public interface IAnimal
    {
        string MakeSound(string text);
    }
    public class ConsoleAnimal : IAnimal
    {

        public void Write(string text)
        {
            Console.WriteLine(text);
        }
        public string MakeSound(string text)
        {
            return text;
        }
    }

}