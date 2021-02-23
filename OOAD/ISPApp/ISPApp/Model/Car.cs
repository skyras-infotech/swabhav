using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPApp.Model
{
    class Car : IDrivingVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a car");
        }
    }
}
