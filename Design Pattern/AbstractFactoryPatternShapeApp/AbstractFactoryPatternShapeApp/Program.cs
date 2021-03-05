using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryPatternShapeApp.Model;

namespace AbstractFactoryPatternShapeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory = FactoryProducer.GetFactory("shape");
            IShape shape = factory.GetShape("square");
            shape.Draw();
            shape = factory.GetShape("rectangle");
            shape.Draw();
            shape = factory.GetShape("circle");
            shape.Draw();
            Console.WriteLine();

            factory = FactoryProducer.GetFactory("color");
            IColor color = factory.GetColor("Red");
            color.FillColor();
            color = factory.GetColor("Green");
            color.FillColor();
            color = factory.GetColor("Blue");
            color.FillColor();
            Console.WriteLine();
        }
    }
}
