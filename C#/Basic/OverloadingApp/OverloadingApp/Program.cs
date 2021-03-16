using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr = { 'c', 's', 'h', 'a', 'p' };
            PrintInfo();
            PrintInfo(23);
            PrintInfo(23.45f);
            PrintInfo(18.6523);
            PrintInfo(true);
            PrintInfo(52.36m);
            PrintInfo(123456789);
            PrintInfo(arr);
            PrintInfo(85, 5);
            Console.ReadLine();
        }

        private static void PrintInfo() {
            Console.WriteLine("Helo! Hi I'm there");
        }
        private static void PrintInfo(int number)
        {
            Console.WriteLine("Int is " + number);
        }
        private static void PrintInfo(float number)
        {
            Console.WriteLine("float is " + number);
        }
        private static void PrintInfo(double number)
        {
            Console.WriteLine("double is " + number);
        }
        private static void PrintInfo(bool val)
        {
            Console.WriteLine("Boolean is " + val);
        }
        private static void PrintInfo(decimal number)
        {
            Console.WriteLine("Decimal is " + number);
        }
        private static void PrintInfo(char[] arr)
        {
            foreach(var cr in arr){
                 Console.WriteLine("Character is "+cr);
            }
        }
        private static void PrintInfo(int n1,int n2)
        {
            Console.WriteLine("Addition is {0}",n1+n2);
        }
    }
}
