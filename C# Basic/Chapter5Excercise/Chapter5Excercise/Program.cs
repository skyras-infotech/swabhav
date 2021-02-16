using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x < 4; x++) {
                for (int y = 4; y > 2; y--) {
                    Console.WriteLine(x + " " + y);
                }
                if (x == 1) {
                    x++;
                }
            }
            Console.ReadLine();
        }
    }
}
