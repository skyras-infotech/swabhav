using System;
using EmployeeEventApp.Publisher;

namespace EmployeeEventApp.Subscriber
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.OnProcessingCompleted += DataLoaded;
            employee.ProcessData("https://swabhav-tech.firebaseapp.com/emp.txt");
            Console.ReadKey();
        }

        private static void DataLoaded() {
            Console.WriteLine("\nData Processing is complete sucessfully...");
        }
       
    }
}
