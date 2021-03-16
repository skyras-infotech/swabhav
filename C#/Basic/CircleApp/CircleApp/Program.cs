using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircleApp.Model;

namespace CircleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            c1.Color = "Red";
            c1.Radius = 11.2;
            PrintCircleInfo(c1);        

            Circle c2 = new Circle();
            c2.Color = "Yellow";
            c2.Radius = 9.4;
            PrintCircleInfo(c2);

            Circle c3 = new Circle();
            c3.Color = "Blue";
            c3.Radius = 22;
            PrintCircleInfo(c3);

            object[] circleObjArr = { c1, c2, c3 };
            PrintMaxCircleRadiusInfo(circleObjArr);
            PrintMaxArea(circleObjArr);
        }

        static void PrintCircleInfo(Circle c) {
            Console.WriteLine("---------Circle Info----------");
            Console.WriteLine("Radius is "+c.Radius);
            Console.WriteLine("Color of circle is " + c.Color);
            Console.WriteLine("Area of circle is " + c.CalculateArea()+"\n");
        }

        static void PrintMaxCircleRadiusInfo(object[] arr) {
            double max = 0;
            foreach (var item in arr)
            {
                var radius = ((Circle)item);
                if (radius.Radius > max) {
                    max = radius.Radius;
                } 
            }
            Console.WriteLine("Maximum Radius is "+max);
        }

        static void PrintMaxArea(object[] arr)
        {
            double maxArea = 0;
            foreach (var item in arr)
            {
                var radius = ((Circle)item);
                if (radius.CalculateArea() > maxArea)
                {
                    maxArea = radius.CalculateArea();
                }
            }
            Console.WriteLine("Maximum Area is " + maxArea);
        }
    }
}
