using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> names = args;
            Console.WriteLine("Name is ascending order:");
            var sortedNames = names.OrderBy(x => x);
            foreach (var item in sortedNames)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nTop 3 names in ascending order");
            var top3Names = names.OrderBy(x => x).Take(3);
            foreach (var item in top3Names)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nNames with more no of alphabets");
            var moreNoOfAlphabets = names.OrderByDescending(x => x.Length).First();
            Console.WriteLine(moreNoOfAlphabets);

            Console.WriteLine("\nNames with consist a");
            var namesWithConsistAVowel = names.Where(x => x.Contains('a'));
            foreach (var item in namesWithConsistAVowel)
            {
                Console.WriteLine(item);
            }

        }
    }
}
