using System;

namespace HierarchicalInheritance
{
    class Car
    {
        public string Model;
        public string Color;
        public int Price;
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

    class Feferrari : Car
    {
        public float Speed;
        public void PrintSpeed() {
            Console.WriteLine($"Speed is {Speed}");
        }
    }

    class Program {
        static void Main(string[] ar)
        {
            Feferrari f = new Feferrari();
            f.Model = "Eco";
            f.Price = 300000;
            f.Color = "Black";
            f.Speed = 70.0f;
            f.PrintCarInfo();
            f.PrintSpeed();
            Console.WriteLine();
            Maruti m = new Maruti();
            m.Model = "Alto";
            m.Price = 500000;
            m.Color = "White";
            m.Mileage= 45.0f;
            m.PrintCarInfo();
            m.PrintMileage();
        }
    }
}
