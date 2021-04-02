using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCEntityDemoApp.ViewModels;
using MVCEntityDemoApp.Models;
using MVCEntityDemoApp.Repository;

namespace MVCEntityDemoApp.Controllers
{
    public class ContactController : Controller
    {
        public ActionResult Index()
        {
            ContactRepository repository = new ContactRepository();
            //repository.AddContacts();
            AllContactVM contactVM = new AllContactVM();
            contactVM.Contacts = repository.GetContacts();
            return View(contactVM);
        }
    }
}