using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CustomeActionFilterDemoApp.Log;

namespace CustomeActionFilterDemoApp.Controllers
{
    [TrackExecutionLog]
    public class HomeController : Controller
    {
        
        public string Index()
        {
            return "Execution Logged";
        }

        public string Welcome()
        {
            throw new Exception("Something went wrong");
        }
    }
}