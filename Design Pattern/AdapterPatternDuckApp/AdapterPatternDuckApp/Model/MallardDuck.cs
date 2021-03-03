using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternDuckApp.Model
{
    class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("I am flying!");
        }

        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
