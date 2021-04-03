using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeMVCApp.Models;
using EmployeeMVCApp.Service;
using EmployeeMVCApp.ViewModels;

namespace EmployeeMVCApp.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeService employeeService = EmployeeService.GetInstance;

        public ActionResult Index()
        {
            EmployeeVM employeeVM = new EmployeeVM();
            employeeVM.Employees = employeeService.GetEmployees();
            return View(employeeVM);
        }

        [HttpGet]
        public ActionResult AddEmployee()
        {
            AddEmployeeVM addEmployeeVM = new AddEmployeeVM();
            return View(addEmployeeVM);
        }

        [HttpPost]
        public ActionResult AddEmployee(AddEmployeeVM vm)
        {
            if (ModelState.IsValid)
            {
                Employee emp = new Employee { ID = vm.ID, Name = vm.Name, Designation = vm.Designation, Salary = vm.Salary };
                employeeService.AddEmployee(emp);
                return RedirectToAction("Index");
            }
            return View(vm);
        }

        [HttpGet]
        public ActionResult EditEmployee(int id)
        {
            EditEmployeeVM editEmployeeVM = new EditEmployeeVM();
            editEmployeeVM.Employee = employeeService.GetEmployees().Where(x => x.ID == id).SingleOrDefault();
            return View(editEmployeeVM);
        }

        [HttpPost]
        public ActionResult EditEmployee(EditEmployeeVM  editEmployeeVM)
        {
            if (ModelState.IsValid)
            {
                Employee emp = editEmployeeVM.Employee;
                employeeService.EditEmployee(emp);
                return RedirectToAction("Index");
            }
            return View(editEmployeeVM);
        }


        [HttpGet]
        public ActionResult DeleteEmployee(int id)
        {
            employeeService.GetEmployees().Remove(employeeService.GetEmployees().Where(x => x.ID == id).SingleOrDefault());
            return RedirectToAction("Index");
        }
    }
}