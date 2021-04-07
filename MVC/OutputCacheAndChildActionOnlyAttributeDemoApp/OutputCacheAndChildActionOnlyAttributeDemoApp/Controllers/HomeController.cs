using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OutputCacheAndChildActionOnlyAttributeDemoApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(Duration = 10)]
        [ChildActionOnly]
        public ActionResult Countries(List<string> countries)
        {
            System.Threading.Thread.Sleep(5000);
            return View(countries);
        }
    }
}