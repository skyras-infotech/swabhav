using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQToXML
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement element = XElement.Load(@"C:\swabhav\LINQ\Employee.xml");
            IEnumerable<XContainer> employees = element.Descendants("Employee").OrderBy(x => (string)x.Element("Name"));
            Console.WriteLine("====== Name Wise sorted Employees Summary ====\n");
            foreach (var item in employees.ToList())
            {
                Console.WriteLine("Employee Name        :  "+  (string)item.Element("Name"));
                Console.WriteLine("Employee Salary      :  " + (string)item.Element("Salary"));
                Console.WriteLine("Employee Designation :  " + (string)item.Element("Designation"));
                Console.WriteLine();
            }
        }
    }
}
