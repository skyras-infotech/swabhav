using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPApp.Model;

namespace OCPApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle {
                Height = 20,
                Width = 40,
            };
            Circle circle = new Circle { 
                Radius = 15.5
            };
            Shape[] shapes = { rectangle, circle };
            Console.WriteLine("Total area is "+CalculatingArea.TotalArea(shapes));
        }

    }
}
