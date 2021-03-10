using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6Excercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //List example
            List<string> strList = new List<string>();
            strList.Add("Zero");
            strList.Add("One");
            strList.Add("Two");
            strList.Add("Three");
            PrintList(strList);
            if (strList.Contains("Three")) {
                strList.Add("Four");
            }
            strList.Remove("Two");
            PrintList(strList);
            if (strList.IndexOf("Four") != 4) {
                strList.Add("4.2");
            }
            PrintList(strList);
            Console.ReadLine();
        }

        static void PrintList(List<string> list) {
            foreach(string element in list) {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
