using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventShapeExampleApp.Publisher;

namespace EventShapeExampleApp.Subscriber
{
    class Cuber
    {
        public Cuber(Shape shape) {
            shape.AreaCalculated += CubeArea;
        }
        public static void CubeArea(int x) 
        {
            Console.WriteLine("Area of cube is "+(x*x*x));
        }
    }
}
