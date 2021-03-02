using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternApp.Model
{
    public class Tesla : IAutomobile
    {
        public void start()
        {
            Console.WriteLine("Tesla start...");
        }

        public void stop()
        {
            Console.WriteLine("Tesla stop...");
        }
    }
}
