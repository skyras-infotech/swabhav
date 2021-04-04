using SeesionApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeesionApp.Controllers
{
    public class Home1Controller : Controller
    {
        
        public ActionResult Index()
        {
            SessionStateModel sessionState;

            if (HttpContext.Application["CurrentSession"] != null)
            {
                sessionState = (SessionStateModel)HttpContext.Application["CurrentSession"];
            }
            else
            {
                sessionState = new SessionStateModel();
            }

            sessionState.Counter++;
            HttpContext.Application["CurrentSession"] = sessionState;
            ViewBag.sessionID = HttpContext.Application;
            return View(sessionState);
        }
    }
}