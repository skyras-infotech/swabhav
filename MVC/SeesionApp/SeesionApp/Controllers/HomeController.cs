using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeesionApp.ViewModels;

namespace SeesionApp.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            SessionStateModel sessionState;
            
            if (Session["CurrentSession"] != null)
            {
                sessionState = (SessionStateModel)Session["CurrentSession"];
            }
            else 
            {
                sessionState = new SessionStateModel();
            }

            sessionState.Counter++;
            Session["CurrentSession"] = sessionState;
            ViewBag.sessionID = Session.SessionID;
            return View(sessionState);
        }
    }
}