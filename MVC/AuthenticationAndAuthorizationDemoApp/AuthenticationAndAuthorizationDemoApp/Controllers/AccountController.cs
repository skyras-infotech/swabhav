using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AuthenticationAndAuthorizationDemoApp.Models;
using System.Web.Security;

namespace AuthenticationAndAuthorizationDemoApp.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Employee employee)
        {
            if (ModelState.IsValid)
            {
                if (employee.Username == "admin" && employee.Password == "admin")
                {
                    FormsAuthentication.SetAuthCookie(employee.Username, false);
                    return RedirectToAction("SecureMethod", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Username and Password");
                }
            }
            return View(employee);
        }
    }
}