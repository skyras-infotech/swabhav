using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverridingApp
{
    class Animal
    {
        public virtual void Print()
        {
            Console.WriteLine("Animal is Eating");
        }
    }
    class Dog : Animal
    {
        public override void Print() {
            Console.WriteLine("Dog is Eating");
        }
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.Print();
        }
    }

    
}
