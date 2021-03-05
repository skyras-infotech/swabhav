using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventEmployeeResignApp.Publisher;
using EventEmployeeResignApp.Subscriber;

namespace EventEmployeeResignApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            new Finance(employee);
            new IT(employee);
            employee.OnResign();
        }
    }
}
