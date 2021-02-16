using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMovableApp.Model
{
    class Bike : IMovable
    {
        public void run()
        {
            Console.WriteLine("Bike is Running");
        }
    }
}
