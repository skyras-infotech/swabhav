using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternApp.Model
{
    public class BMW : IAutomobile
    {
        public void start()
        {
            Console.WriteLine("BMW start...");
        }

        public void stop()
        {
            Console.WriteLine("BMW stop...");
        }
    }
}
