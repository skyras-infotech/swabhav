using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginDemoApp.Models;

namespace LoginDemoApp.Controllers
{
    [AuthUsers]
    public class AccountController : Controller
    {
        public AccountController() 
        {
        }
        public ActionResult HomePage(Employee employee)
        {
            /*if (Session["CurrentSession"] == null) 
            {
                return RedirectToAction("Index");
            }*/
            return View(employee);
        }

        public ActionResult HomePage1(Employee employee)
        {
            /*if (Session["CurrentSession"] == null) 
            {
                return RedirectToAction("Index");
            }*/
            return View(employee);
        }
    }
}