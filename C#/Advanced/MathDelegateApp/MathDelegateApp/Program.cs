using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathDelegateApp
{
    class Program
    {
        public delegate void DMathOpration(int x, int y);
        public static void Add(int a, int b)
        {
            Console.WriteLine("Addition ==> "+(a+b));
        }

        public static void Subtract(int a, int b)
        {
            Console.WriteLine("Subtraction ==> " + (a - b));
        }

        public static void Multiplication(int a, int b)
        {
            Console.WriteLine("Multiplication ==> " + (a * b));
        }

        public static void Division(int a, int b)
        {
            Console.WriteLine("Division ==> " + (a / b));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("========= Case 1 ========");
            DMathOpration d = Add;
            d(30, 15);
            d = Subtract;
            d(30, 15);
            d = Multiplication;
            d(30, 15);
            d = Division;
            d(30, 15);

            Console.WriteLine("\n========= Case 2 ========");
            DMathOpration[] oprations = { Add, Subtract, Multiplication,Division};

            foreach (var item in oprations)
            {
                item(20,10);
            }
        }
    }
}
