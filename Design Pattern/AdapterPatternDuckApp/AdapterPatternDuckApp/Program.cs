using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPatternDuckApp.Model;

namespace AdapterPatternDuckApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck mallard = new MallardDuck();
            WildTurkey wild = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(wild);

            Console.WriteLine("The Turkey says...");
            wild.Gobble();
            wild.Fly();
            Console.WriteLine("\nThe Duck says...");
            TestDuck(mallard);

            Console.WriteLine("The TurkeyAdapter says...");
            TestDuck(turkeyAdapter);
        }

        private static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
            Console.WriteLine();
        }
    }
}
