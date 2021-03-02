using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPatternApp.Model;

namespace FactoryPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AutomobileFactory factory = new AutomobileFactory();

            Console.WriteLine("case 1");
            IAutomobile audi = factory.make(AutomobileType.Audi);
            audi.start();
            audi.stop();

            IAutomobile bmw = factory.make(AutomobileType.BMW);
            bmw.start();
            bmw.stop();

            Console.WriteLine("\ncase 2");
            IAutomobile unspecified = factory.make(AutomobileType.Unspecified);
            //unspecified.start();
            //unspecified.stop();

            Console.WriteLine("\ncase 3");
            AutomobileFactory factory1 = new AutomobileFactory();
            IAutomobile tesla = factory1.make(AutomobileType.Tesla);
            tesla.start();
            tesla.stop();

        }
    }
}
