using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginDemoApp.Models;
using LoginDemoApp.Service;
using System.Diagnostics;

namespace LoginDemoApp.Controllers
{
    
    public class HomeController : Controller
    {

        public HomeController() 
        {
            Debug.WriteLine("Controller is Running");
        }

        [HttpGet]
        public ActionResult Index()
        {
            /*  if (Session["CurrentSession"] == null)
             {
                 return View();
             }
            Employee employee = (Employee)Session["CurrentSession"];
            return RedirectToAction("HomePage",employee);*/
            return View();
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
                        return RedirectToAction("HomePage","Account", new Employee { Username = employee.Username, Password = employee.Password });
                    }
                }
            }
            return View(employee);
        }

       
    }
}