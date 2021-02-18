using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountryApp.Model;

namespace CountryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Country country = new Country
            {
                CountryName = "India",
                GetCapital = new Capital {
                    CapitalName = "Delhi",
                    Populations = 500000
                }
            };

            PrintInfo(country);
        }

        private static void PrintInfo(Country country)
        {
            Console.WriteLine("============== Country Info ============\n");
            Console.WriteLine("Country Name       :   " + country.CountryName);
            Console.WriteLine("Capital Name       :   " + country.GetCapital.CapitalName);
            Console.WriteLine("Capital Population :   " + country.GetCapital.Populations+"\n");
        }
    }
}
