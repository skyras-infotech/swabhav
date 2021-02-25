using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LSPSolution.Model;

namespace LSPSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape shape1 = new Rectangle(10,20);
            IShape shape2 = new Square(15);
            Console.WriteLine("Rectangle Area is "+shape1.CalculateArea());
            Console.WriteLine("Square Area is " + shape2.CalculateArea());
        }
    }
}
