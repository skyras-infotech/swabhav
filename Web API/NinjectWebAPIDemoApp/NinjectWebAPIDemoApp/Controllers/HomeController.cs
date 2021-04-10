using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NinjectWebAPIDemoApp.Service;
using NinjectWebAPIDemoApp.Models;

namespace NinjectWebAPIDemoApp.Controllers
{
    public class HomeController : ApiController
    {
        IEmployeeService empService = null;
        public HomeController(IEmployeeService service) 
        {
            empService = service;
        }

        [HttpGet]
        public IEnumerable<Employee> GetEmployees() 
        {
            return empService.GetEmployees();
        }

        /*[HttpPost]
        public IHttpActionResult PostEmployee([FromBody] Employee employee)
        {
            Employee emp = new Employee()
            {
                ID = employee.ID,
                EmployeeName = employee.EmployeeName,
                Department = employee.Department,
                Salary = employee.Salary
            };
            empService.AddEmployee(emp);
            return Ok("Employee Added Sucessfully " + employee.EmployeeName);
        }*/
    }
}
