using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternApp.Model
{
    public class Audi : IAutomobile
    {
        public void start()
        {
            Console.WriteLine("Audi start...");
        }

        public void stop()
        {
            Console.WriteLine("Audi stop...");
        }
    }
}
