using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NinjectWebAPIDemoApp.Models;

namespace NinjectWebAPIDemoApp.Service
{
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
        Employee GetEmployeeByID(int id);
       // void AddEmployee(Employee employee);
    }
}
