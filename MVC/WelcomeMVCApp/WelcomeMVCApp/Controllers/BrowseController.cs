using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WelcomeMVCApp.Controllers
{
    public class BrowseController : Controller
    {
        public ActionResult Greet() 
        {
            ViewBag.currentTime = DateTime.Now.Hour;
            return View();
        }
    }
}