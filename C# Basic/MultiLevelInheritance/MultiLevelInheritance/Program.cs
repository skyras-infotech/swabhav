using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    class Car
    {
        public string Model;
        protected string Color;
        protected int Price;
        public void PrintCarInfo() {
            Console.WriteLine($"Model is {Model}");
            Console.WriteLine($"Color is {Color}");
            Console.WriteLine($"Price is {Price}");
        }
    }

    class Maruti : Car
    {
        public float Mileage;
        public void PrintMileage() {
            Console.WriteLine($"Mileage is {Mileage}");
        }
    }

    class Feferrari : Maruti
    {
        public float Speed;
        public void PrintSpeed() {
            Console.WriteLine($"Speed is {Speed}");
        }
        static void Main(string[] ar) {
            Feferrari f = new Feferrari();
            f.Model = "Alto";
            f.Price = 500000;
            f.Color = "White";
            f.Mileage = 30.5f;
            f.Speed = 70.0f;
            f.PrintCarInfo();
            f.PrintSpeed();
            f.PrintMileage();
        }
    }
}
