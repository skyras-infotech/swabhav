using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMovableApp.Model;

namespace IMovableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike();
            Car car = new Car();
            Truck truck = new Truck();
            IMovable[] arr = { bike, car, truck };
            PrintInfo(arr);
            IMovable[] arr1 = { truck, bike, car};
            PrintInfo(arr1);
        }
        public static void PrintInfo(IMovable[] arr) {
            foreach (var item in arr)
            {
                item.run();
            }
            Console.WriteLine();
        }
    }
}
