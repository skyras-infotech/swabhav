using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            arr = new int[args.Length - 1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(args[i]);
            }
            if (args[args.Length - 1].Equals("e"))
            {
                PrintEven(arr);
            }
            else if (args[args.Length - 1].Equals("o"))
            {
                PrintOdd(arr);
            }
            else if (args[args.Length - 1].Equals("p"))
            {
                PrintPrime(arr);
            }
            else
            {
                arr = new int[args.Length];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = int.Parse(args[i]);
                }
                PrintAllElements(arr);
            }
            Console.ReadLine();
        }

        static void PrintAllElements(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        static void PrintEven(int[] arr) {
            Console.WriteLine("Even Numbers");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
                
            }
           
        }
        static void PrintOdd(int[] arr)
        {
            Console.WriteLine("Odd Numbers");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    Console.WriteLine(arr[i]);
                }

            }

        }
        static void PrintPrime(int[] arr)
        {
            Console.WriteLine("Prime Numbers");
            int j;
            for (int i = 0; i < arr.Length; i++)
            {
                for (j = 2; j < arr[i]; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        break;
                    }
                }
                if (j == arr[i])
                {
                    Console.WriteLine(arr[i]);

                }

            }
        }
    }
}
