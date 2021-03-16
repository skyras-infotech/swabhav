using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredefineDelegatesDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======== Func Demo ========-");
            Func<int[], int[]> obj = SquareOfAllNumbers;
            int[] arr = { 10, 15, 20 };
            arr = obj.Invoke(arr);
            Console.WriteLine("Square of All numbers are");
            foreach (var item in arr)
            {
                Console.Write(item + "\t");
            }


            Console.WriteLine("\n\n======== Predicate Demo ========-");
            Predicate<int> even = IsEven;
            Console.WriteLine("10 is Even "+ even(10));

            Console.WriteLine("\n======== Action Demo ========-");
            Action<int, int> oddnumbers = PrintOddNumbersOnlyFromGivenRange;
            oddnumbers(20, 45);
        }

        private static void PrintOddNumbersOnlyFromGivenRange(int from, int to) {
            Console.WriteLine("Odd numbers from " + from + " to " + to + " are");
            for (int i = from; i < to; i++)
            {
                if (i % 2 != 0) {
                    Console.Write(i + "\t");
                }
            }
            Console.WriteLine(Environment.NewLine);
        }

        private static int[] SquareOfAllNumbers(int[] numbers) {

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= numbers[i];
            }
            return numbers;
        }
        private static bool IsEven(int num) 
        {
            if (num % 2 == 0) 
            {
                return true;
            }
            return false;
        }
    }
}
