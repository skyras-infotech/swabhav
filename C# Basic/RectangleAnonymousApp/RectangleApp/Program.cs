using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RectangleApp.Model;

namespace RectangleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(new Rectangle().GetHashCode());
            Console.WriteLine(new Rectangle().GetHashCode());

            new Rectangle().Height = 10;
            new Rectangle().Width = 20;

            Console.WriteLine($"Width : { new Rectangle().Width}");
            Console.WriteLine($"Height : { new Rectangle().Height}");
            Console.WriteLine($"Hash : { new Rectangle().GetHashCode()}");


            Console.ReadLine();
        }
    
    }
}
