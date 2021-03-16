using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineInputApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take input from the command line by the user
            if (args.Length > 0)
            {
                Console.WriteLine("Input added by the programmer using commad line");
                Console.Write("Input is ");
                foreach (String str in args)
                {
                    Console.Write(str+" ");
                }
                Console.WriteLine();
                int[] OddEvenArray = new int[args.Length];
                for (int i = 0;i < args.Length; i++) {
                    OddEvenArray[i] = int.Parse(args[i]);
                }
                for (int j = 0; j < OddEvenArray.Length; j++) {
                    if (OddEvenArray[j] % 2 == 0)
                    {
                        Console.WriteLine("Even number " + OddEvenArray[j]);
                    }
                    else {
                        Console.WriteLine("Odd number " + OddEvenArray[j]);
                    }
                }
            }
            else {
                Console.WriteLine("Please add the command line input");
            }
            Console.ReadLine();
        }
    }
}
