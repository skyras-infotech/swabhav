using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitAndSubstringUsingFunction
{
    class Program
    {
        /*public const int num1 = 10;
        public readonly int num2 = 20;*/
        static void Main(string[] args)
        {
        //PrintDemo(num1, num2);
        String url = "http://www..com?developer=\"\"@course=C-Sharp";
            PrintDetailsUsingSubString(url);
            Console.WriteLine();
            PrintDetailsUsingSplit(url);
            Console.ReadLine();

        }

        static void PrintDemo(int num1, int num2)
        {
            num1 = 85;
            num2 = 90;
            Console.WriteLine(num1 + " " + num2);
         }
    static void PrintDetailsUsingSubString(string url) {
            Console.WriteLine("-----Using Substring-----");
            Console.WriteLine("company name :- " + url.Substring(11, 6));
            Console.WriteLine("developer name :- " + url.Substring(33, 3));
            //Console.WriteLine("Couser name :- " + url.Substring(45, 4));
        }
        static void PrintDetailsUsingSplit(string url)
        {
            Console.WriteLine("-----Using Substring-----");
            string[] separatorsForCompany = { "www.", ".com" };
            string[] companyName = url.Split(separatorsForCompany, StringSplitOptions.None);
            if (companyName[1].Equals(""))
            {
                companyName[1] = "Unspecified";
            }
            Console.WriteLine("Company name is " + companyName[1]);
            char[] separatorsOfDeveloper = { '=', '\"' };
            string[] developerAndCourseName = url.Split(separatorsOfDeveloper, StringSplitOptions.None);
            if(developerAndCourseName[2].Equals("")){
                developerAndCourseName[2] = "Unspecified";
            }
            if (developerAndCourseName[4].Equals(""))
            {
                developerAndCourseName[4] = "Unspecified";
            }
            Console.WriteLine("Developer name is " + developerAndCourseName[2]);
            Console.WriteLine("Course name is " + developerAndCourseName[4]);
            Console.ReadLine();
        }
    }

}
