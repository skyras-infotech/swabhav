using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventEmployeeResignApp.Publisher;

namespace EventEmployeeResignApp.Subscriber
{
    class Finance
    {
        public Finance(Employee employee) 
        {
            employee.EmployeeResign += FinanceResign;
        }
        public static void FinanceResign() 
        {
            Console.WriteLine("Employee resign process from the finance department");
        }
    }
}
