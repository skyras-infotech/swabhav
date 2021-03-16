using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMovableApp.Model
{
    class Truck : IMovable
    {
        public void run()
        {
            Console.WriteLine("Truck is running");
        }
    }
}
