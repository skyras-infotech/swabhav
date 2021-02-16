using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitStringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://www.swabhav.com?developer=\"abc\"@course=.net";

            //get company name
            string[] separatorsForCompany = { "www.",".com"};
            string[] companyName = url.Split(separatorsForCompany, StringSplitOptions.None);
            Console.WriteLine("Company name is " + companyName[1]);

            //get developer name and course name
            char[] separatorsOfDeveloper = { '=','\"'};
            string[] developerAndCourseName = url.Split(separatorsOfDeveloper, StringSplitOptions.None);
            Console.WriteLine("Developer name is " + developerAndCourseName[2]);
            Console.WriteLine("Course name is " + developerAndCourseName[4]);
            Console.ReadLine();
        }
    }
}
