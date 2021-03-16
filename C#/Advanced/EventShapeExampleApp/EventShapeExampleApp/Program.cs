using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventShapeExampleApp.Publisher;
using EventShapeExampleApp.Subscriber;

namespace EventShapeExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();

            new Square(shape);
            new Cuber(shape);

            shape.CalaculateShape(5);
        }
    }
}
