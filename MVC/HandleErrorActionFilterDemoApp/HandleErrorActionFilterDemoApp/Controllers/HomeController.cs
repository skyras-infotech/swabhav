using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandleErrorActionFilterDemoApp.Controllers
{
    public class HomeController : Controller
    {
        [HandleError]
        public string Index()
        {
            throw new Exception("Something went wrong");
        }
    }
}