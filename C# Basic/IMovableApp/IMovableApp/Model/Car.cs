using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMovableApp.Model
{
    class Car : IMovable
    {
        public void run()
        {
            Console.WriteLine("Car is running");
        }
    }
}
