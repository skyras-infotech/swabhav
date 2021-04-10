using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeCRUDUsingRouteRoutePrefixAndDTO.Models;
using EmployeeCRUDUsingRouteRoutePrefixAndDTO.Service;
using EmployeeCRUDUsingRouteRoutePrefixAndDTO.DTO;

namespace EmployeeCRUDUsingRouteRoutePrefixAndDTO.Controllers
{
    [RoutePrefix("api/home")]
    public class HomeController : ApiController
    {
        EmployeeService empService = EmployeeService.GetInstance;

        [Route("")]
        public List<EmployeeDetailsDTO> GetEmployees()
        {
            return empService.GetEmployees().Select(x => new EmployeeDetailsDTO() { EmpName = x.EmployeeName,Salary = x.Salary}).ToList();
        }

        [Route("{id:int}")]
        public Employee GetEmployee(int id)
        {
            return empService.GetEmployeeByID(id);
        }

        [Route("")]
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
            return Ok("Employee Added Sucessfully");
        }

        [Route("{id:int}")]
        public IHttpActionResult PutEmployee(int id, [FromBody] Employee employee)
        {
            empService.UpdateEmployee(id, employee);
            return Ok("Employee Updated Sucessfully");
        }

        [Route("{id:int}")]
        public IHttpActionResult DeleteEmployee(int id)
        {
            empService.DeleteEmployee(id);
            return Ok("Employee Deleted Sucessfully");
        }
    }
}