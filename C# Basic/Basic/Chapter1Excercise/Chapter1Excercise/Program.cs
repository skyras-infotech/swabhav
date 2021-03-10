using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            while (x > 0) {
                if (x > 2) {
                    Console.Write("a");
                }
                x -= 1;
                Console.Write("-");
                if (x == 1) {
                    Console.Write("d");
                    x -= 1;
                }
                if (x == 2) {
                    Console.Write("b c");
                }
            }
            Console.ReadLine();
        }
    }
}
