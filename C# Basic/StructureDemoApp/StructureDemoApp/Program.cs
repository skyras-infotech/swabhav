using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 20);
            Modify(p1);
            Console.WriteLine("Value is " + p1.x + " " + p1.y);
        }
        public static void Modify(Point p1)
        {
            p1.x = 0;
            p1.y = 0;
        }
    }

   
}
