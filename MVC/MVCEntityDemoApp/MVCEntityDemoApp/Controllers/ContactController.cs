using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCEntityDemoApp.ViewModels;
using MVCEntityDemoApp.Models;
using MVCEntityDemoApp.Services;

namespace MVCEntityDemoApp.Controllers
{
    public class ContactController : Controller
    {
        ContactService contactService = ContactService.GetInstance;
        public ActionResult Index(string search)
        {
            AllContactVM contactVM = new AllContactVM();
            if (search == null)
            {
                contactVM.Contacts = contactService.GetContacts();
            }
            else 
            {
                contactVM.Contacts = contactService.SearchContact(search);
            }
            return View(contactVM);
        }

        public ActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddContact(AddContactVM contactVM)
        {
            if (ModelState.IsValid) 
            {
                contactService.AddContact(new Contact
                {
                    FirstName = contactVM.FirstName,
                    LastName = contactVM.LastName,
                    MobileNumber = contactVM.MobileNumber,
                    Address = contactVM.Address
                });
                return RedirectToAction("Index");
            }
            return View(contactVM);
        }

        public ActionResult UpdateContact(int id)
        {
            EditContactVM contactVM = new EditContactVM();
            contactVM.Contact = contactService.GetContactByID(id);
            return View(contactVM);
        }

        [HttpPost]
        public ActionResult UpdateContact(EditContactVM contactVM)
        {
            if (ModelState.IsValid)
            {
                contactService.UpdateContact(contactVM.Contact);
                return RedirectToAction("Index");
            }
            return View(contactVM);
        }

        public ActionResult DeleteContact(int id)
        {
            contactService.DeleteContact(id);
            return RedirectToAction("Index");
        }
    }
}