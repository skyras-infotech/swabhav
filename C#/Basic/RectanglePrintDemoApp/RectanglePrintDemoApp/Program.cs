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
            int height = -5, width = 180;
            string color = "Blue";
            r1.setHeight(height);
            r1.setWidth(width);
            r1.setColor(color);

            PrintRectangleInfo(r1);

            Model.Rectangle r2;
            r2 = r1;
            r2.setHeight(r1.getHeight() + 1);
            PrintRectangleInfo(r2);

            Model.Rectangle r3 = new Model.Rectangle();
            r3.setHeight(10);
            r1.setWidth(52);
            r1.setColor("Green");
            r2 = r3;
            PrintRectangleInfo(r2);
            PrintRectangleInfo(r3);

            Console.ReadLine();
        }
        static void PrintRectangleInfo(Model.Rectangle r)
        {
            Console.WriteLine(r.GetHashCode());

            Console.WriteLine("Height is " + r.getHeight());
            Console.WriteLine("Width is " + r.getWidth());
            Console.WriteLine("Color is " + r.getColor());

        }
    }
}
