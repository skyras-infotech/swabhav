using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByValueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            Console.WriteLine("Number before " + num);
            PrintNumber(ref num);
            Console.WriteLine("Number after " + num);
            int[] arr = { 10, 20, 30, 40 };
            Console.Write("Array before ");
            //Console.WriteLine(arr.GetHashCode());
            for (int i = 0; i < arr.Length; i++) {
                Console.Write(arr[i] + " ");
            }
            PrintArrayNumber(arr);
            Console.WriteLine();
            Console.Write("Array after ");
            //Console.WriteLine(arr.GetHashCode());
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            string str = "abc";
            Console.WriteLine("String before " + str);
            
            PrintString(str);
            Console.WriteLine("String after " + str);
            Console.ReadLine();
        }
        static void PrintNumber(ref int num) {
            num = 15;
        }
        static void PrintArrayNumber(int[] ar) {
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = 0;
            }
        }
        static void PrintString(string str) {
            str = "pqr";
        }
    }
}
