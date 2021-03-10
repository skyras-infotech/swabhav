using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventEmployeeResignApp.Publisher
{
    public delegate void DEmployeeResignation();
    class Employee
    {
        public event DEmployeeResignation EmployeeResign;

        public void OnResign() {
            EmployeeResign?.Invoke();
        }
    }
}
