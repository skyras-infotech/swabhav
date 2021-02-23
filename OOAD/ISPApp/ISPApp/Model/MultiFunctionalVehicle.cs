using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPApp.Model
{
    class MultiFunctionalVehicle : IFlyingVehicle, IDrivingVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a multi functional car");
        }

        public void Fly()
        {
            Console.WriteLine("Flying a multi functional car");
        }
    }
}
