using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Model.Rectangle r1 = new Model.Rectangle();
            Model.Rectangle r2 = new Model.Rectangle();
            int height = 5, width = 18;
            string color = "YelloW";
            r1.Height = height;
            r1.Width = width;
            r1.Color = color;
            r2.Height = 5;
            r2.Width = 10;
            r2.Color = "Red";


            //r2 = r1;

            

            Console.WriteLine(r1 == r2);

            Console.WriteLine("Height is " + r1.Height);
            Console.WriteLine("Width is " + r1.Width);
            Console.WriteLine("Color is " + r1.Color);
/*
            Console.WriteLine("Before r1 "+r1.GetHashCode());

            Model.Rectangle r2;
            r2 = r1;
            r2.setHeight(r1.getHeight() + 1);
            Console.WriteLine("r2 is " + r1.GetHashCode());

            Model.Rectangle r3 = new Model.Rectangle();
            r3.setHeight(10);
            Console.WriteLine("before assign r3 is " + r3.GetHashCode());

            r2 = r3;
            Console.WriteLine("After assign r3 r2 is " + r2.GetHashCode());
            Console.WriteLine("After assign r3 is " + r3.GetHashCode());
            Console.WriteLine("After all assign r1 is " + r1.GetHashCode());

            Console.WriteLine("Height is " + r1.getHeight());
            Console.WriteLine("Width is " + r1.getWidth());
            Console.WriteLine("Color is " + r1.getColor());
            Console.ReadLine();*/
        }
        static void PrintRectangleInfo() { 
        
        }
    }
}
