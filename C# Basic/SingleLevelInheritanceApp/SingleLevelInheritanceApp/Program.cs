using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLevelInheritanceApp
{
    //Single Level Inheritance
    class Car
    {
        public string model;
        public string color;
        public int price;

        public void PrintCarInfo() {
            Console.WriteLine($"Model is {model}");
            Console.WriteLine($"Color is {color}");
            Console.WriteLine($"Price is {price}");
        }
    }

    class Maruti : Car {
        public float mileage;
        public void PrintMileage() {
            Console.WriteLine($"Mileage is {mileage}");
        }

        static void Main(string[] ar) {
            Maruti maruti = new Maruti();
            maruti.model = "Alto";
            maruti.price = 500000;
            maruti.color = "White";
            maruti.mileage = 30.5f;
            maruti.PrintCarInfo();
            maruti.PrintMileage();
        }
    }
}
