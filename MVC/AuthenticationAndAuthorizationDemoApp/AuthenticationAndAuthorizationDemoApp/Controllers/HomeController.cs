using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthenticationAndAuthorizationDemoApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult SecureMethod()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult NonSecureMethod()
        {
            return View();
        }
    }
}