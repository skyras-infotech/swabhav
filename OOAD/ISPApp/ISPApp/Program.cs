using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISPApp.Model;

namespace ISPApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Drive();

            Airplane airplane = new Airplane();
            airplane.Fly();

            MultiFunctionalVehicle vehicle = new MultiFunctionalVehicle();
            vehicle.Drive();
            vehicle.Fly();
            Console.WriteLine(void);
        }
    }
}
