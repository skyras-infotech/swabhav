using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 5, width = 80;
            string color = "Blue";
            Rectangle r1 = new Rectangle(height,width,color);
            Console.WriteLine(r1.Details);
            Console.ReadLine();
        }
    }
}
