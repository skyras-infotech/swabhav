using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginDemoApp.Models;
using LoginDemoApp.Service;

namespace LoginDemoApp.Controllers
{
    public class HomeController : Controller
    {


        [HttpGet]
        public ActionResult Index()
        {
            if (Session["CurrentSession"] == null)
            {
                return View();
            }
            Employee employee = (Employee)Session["CurrentSession"];
            return RedirectToAction("HomePage",employee);
        }

        [HttpPost]
        public ActionResult Index(Employee employee)
        {
            if (ModelState.IsValid)
            {
                foreach (var emp in EmployeeService.GetEmployees())
                {
                    if (employee.Username == emp.Username && employee.Password == emp.Password)
                    {
                        Session["CurrentSession"] = employee;
                        return RedirectToAction("HomePage", new Employee { Username = employee.Username, Password = employee.Password });
                    }
                }
                Response.Write("username and password is incorrect");
            }
            return View(employee);
        }

        public ActionResult HomePage(Employee employee)
        {
            if (Session["CurrentSession"] == null) 
            {
                return RedirectToAction("Index");
            }
            return View(employee);
        }
    }
}