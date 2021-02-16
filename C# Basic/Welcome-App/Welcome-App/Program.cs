using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Welcome_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;

            String name = "";
            if (name.Equals("") || name.Equals(null))
            {
                name = "Not defined";
            }
            Console.WriteLine(name);
          /*  getEvenNumbersBetween0to40();
            Console.WriteLine("\n");
            findDuplicatesFromAnArray();
            Console.WriteLine("\n");
            findFirstAndSecondLargestNumber();
            Console.WriteLine("\n");
            getPalindromeNumber();*/
            
            Console.ReadLine();
        }

        static void findFirstAndSecondLargestNumber() {
            int[] arr = {10,20,85,41,52,65,72,84,32,90};
            int firstMax = 0, secondMax = 0;
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] > firstMax)
                {
                    secondMax = firstMax;
                    firstMax = arr[i];
                }
                else if(arr[i] > secondMax) {
                    secondMax = arr[i];
                }
            }
            Console.WriteLine("First and second largest numbers are "+firstMax+" "+secondMax);
        }

        static void findDuplicatesFromAnArray() {
            int[] arr = { 10, 20, 12, 12, 10, 85, 45, 12, 74, 63, 95, 96, 63, 85 };
            var dict = new Dictionary<int, int>();
            foreach (var num in arr) {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else {
                    dict[num] = 1;
                }
            }
            Console.Write("Duplicates values are ");
            foreach (var pair in dict)
            {
                if (pair.Value > 1) {
                    Console.Write(pair.Key+" ");
                }
            }
        }

        static void getPalindromeNumber() {
            Console.Write("Enter any number ==> ");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int remainder, sum = 0;
            while (num != 0) {
                remainder = num % 10;
                sum = (10 * sum) + remainder;
                num = num / 10;
            }
            if (sum == temp)
            {
                Console.WriteLine(temp + " is a palindrome number");
            }
            else {
                Console.WriteLine(temp + " is not a palindrome number");
            }
        }

        static void getEvenNumbersBetween0to40() {
            Console.WriteLine("Even Numbers between 0 to 40 is");
            for (int i = 0; i < 40; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
