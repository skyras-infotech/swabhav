using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LoginDemoApp.Models;

namespace LoginDemoApp.Service
{
    public class EmployeeService
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Username = "sumit",Password="sumit"},
                new Employee { Username = "yogesh",Password="yogesh"},
                new Employee { Username = "niyati",Password="niyati"},
                new Employee { Username = "admin",Password="admin"}
            };
            return employees;
        }
    }

    
}