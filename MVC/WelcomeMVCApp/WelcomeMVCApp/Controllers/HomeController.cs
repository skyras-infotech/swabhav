using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WelcomeMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public HomeController() 
        { 
        }

        public string Index() 
        {
             return "Hello";
        }

        public ActionResult Hello() 
        {
            return View();
        }

        public ActionResult WelcomeURL(string name) 
        {
            ViewBag.msg = name;
            return View();
        }

        public ActionResult WelcomeURLPrint5Times(string name)
        {
            ViewBag.msg = name;
            return View();
        }

        public ActionResult PrintNameFromTextbox(string username)
        {
            ViewBag.username = username;
            return View();
        }

        public ActionResult PrintNameFromTextbox5Times(string username)
        {
            ViewBag.username = username;
            return View();
        }

        public ActionResult TwoTextBox(string id,string username)
        {
            ViewBag.username = username;
            ViewBag.id = id;
            return View();
        }
    }
}