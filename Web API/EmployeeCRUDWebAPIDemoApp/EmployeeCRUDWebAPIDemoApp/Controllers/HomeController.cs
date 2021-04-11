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
            if (ModelState.IsValid)
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
            else 
            {
                List<string> str = new List<string>();
                foreach (var item in ModelState.Keys)
                {
                    if (!ModelState.IsValidField(item)) 
                    {
                        str.Add(item);
                    }
                }
                return BadRequest("Employee not added "+str[0]);
            }
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
