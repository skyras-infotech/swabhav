using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateDuplicatesArrayayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] DuplicatesArray = new int[] { 1, 2, 3, 4, 2, 7, 8, 8, 3 };
            Console.WriteLine("Duplicate elements in given Array: ");
            FindDuplicatesNumbers(DuplicatesArray);
            
        }
        static void FindDuplicatesNumbers(int[] arr) {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
