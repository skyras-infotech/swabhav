using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeCRUDWebAPIDemoApp.Models;
using EmployeeCRUDWebAPIDemoApp.Service;

namespace EmployeeCRUDWebAPIDemoApp.Controllers
{
    public class HomeController : ApiController
    {
        EmployeeService empService = EmployeeService.GetInstance;

        [HttpGet]
        public List<Employee> GetEmployees() 
        {
            return empService.GetEmployees();
        }

        [HttpGet]
        public Employee GetEmployee(int id)
        {
            return empService.GetEmployeeByID(id);
        }

        [HttpPost]
        public IHttpActionResult AddEmployee([FromBody]Employee employee)
        {
            Employee emp = new Employee()
            {
                ID = employee.ID,
                EmployeeName = employee.EmployeeName,
                Department = employee.Department,
                Salary = employee.Salary
            };
            empService.AddEmployee(emp);
            return Ok("Employee Added Sucessfully");
        }

        [HttpPut]
        public IHttpActionResult UpdateEmployee(int id,[FromBody] Employee employee)
        {
            empService.UpdateEmployee(id,employee);
            return Ok("Employee Updated Sucessfully");
        }

        [HttpDelete]
        public IHttpActionResult DeleteEmployee(int id)
        {
            empService.DeleteEmployee(id);
            return Ok("Employee Deleted Sucessfully");
        }
    }
}
