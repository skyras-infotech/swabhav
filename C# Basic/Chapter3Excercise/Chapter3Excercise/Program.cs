using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter3Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            ArraysDemo();
            Console.ReadLine();
        }

        static void ArraysDemo()
        {
            int[] index = new int[4];
            index[0] = 1;
            index[1] = 3;
            index[2] = 0;
            index[3] = 2;
            String[] islands = new String[4];
            islands[0] = "Bermuda";
            islands[1] = "Fiji";
            islands[2] = "Azores";
            islands[3] = "Cozumel";
            int y = 0, refrence;
            while (y < 4)
            {
                refrence = index[y];
                Console.Write("island = ");
                Console.WriteLine(islands[refrence]);
                y = y + 1;
            }
        }
    }
}
