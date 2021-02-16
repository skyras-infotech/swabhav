using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionApp

{
    abstract class Animal
    {
        public abstract void Eat();
        public void Sound()
        {
            Console.WriteLine("Dog can sound");
        }
    }
    class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog can eat");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog mydog = new Dog();
            Animal thePet = mydog;
            mydog.Eat();
            thePet.Sound();
        }
    }
}
