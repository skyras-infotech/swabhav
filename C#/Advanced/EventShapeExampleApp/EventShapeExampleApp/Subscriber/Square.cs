using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventShapeExampleApp.Publisher;

namespace EventShapeExampleApp.Subscriber
{
    class Square
    {
        public Square(Shape shape)
        {
            shape.AreaCalculated += SquareArea;
        }
        public static void SquareArea(int x)
        {
            Console.WriteLine("Area of Square is "+x * x);
        }
    }
}
