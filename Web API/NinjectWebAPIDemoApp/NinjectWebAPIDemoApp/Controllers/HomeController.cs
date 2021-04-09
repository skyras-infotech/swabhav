using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using NinjectWebAPIDemoApp.Models;

namespace NinjectWebAPIDemoApp.Controllers
{
    public class HomeController : ApiController
    {
        IEmployee employee = null;
        public HomeController(IEmployee emp) 
        {
            employee = emp;
        }

        [HttpGet]
        public IHttpActionResult Index() 
        {
            int n = employee.GetNoOfEmployee();
            return Ok("No of employee is "+n);
        }
    }
}
