using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginDemoApp.Models;

namespace LoginDemoApp.Controllers
{
    public class HomeController : Controller
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee { Username = "sumit",Password="sumit"},
            new Employee { Username = "yogesh",Password="yogesh"},
            new Employee { Username = "niyati",Password="niyati"},
            new Employee { Username = "admin",Password="admin"}
        };

        [HttpGet]
        public ActionResult Index(string err)
        {
            if (err != null)
            {
                Response.Write(err);
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(Employee employee)
        {
            if (ModelState.IsValid)
            {
                foreach (var emp in employees)
                {
                    if (employee.Username == emp.Username && employee.Password == emp.Password)
                    {
                        return RedirectToAction("HomePage", new Employee { Username = employee.Username, Password = employee.Password });
                    }
                }
                Response.Write("username and password is incorrect");
            }
            return View(employee);
        }

        public ActionResult HomePage(Employee employee)
        {
            return View(employee);
        }
    }
}