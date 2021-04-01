using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeMVCApp.Models;
using EmployeeMVCApp.Service;

namespace EmployeeMVCApp.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeService employeeService = new EmployeeService();
        public ActionResult Index()
        {
            List<Employee> employees;

            if (TempData["listOfEmployee"] == null)
            {
                employees = employeeService.GetEmployees();
                TempData["listOfEmployee"] = employees;
            }
            else 
            {
                employees = (List<Employee>) TempData["listOfEmployee"];
                TempData.Keep();
            }
            return View(employees);
        }

        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            List<Employee> employees;
            if (ModelState.IsValid) 
            {
                employees = (List<Employee>)TempData["listOfEmployee"];
                Employee emp = new Employee { ID = employee.ID, Name = employee.Name, Designation = employee.Designation, Salary = employee.Salary};
                employees.Add(emp);
                TempData.Keep();
                return RedirectToAction("Index");
            }
            TempData.Keep();
            return View();
        }
    }
}