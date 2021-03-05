using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventEmployeeResignApp.Publisher;

namespace EventEmployeeResignApp.Subscriber
{
    class IT
    {
        public IT(Employee employee)
        {
            employee.EmployeeResign += ITResign;
        }
        public static void ITResign()
        {
            Console.WriteLine("Employee resign process from the IT department");
        }
    }
}
