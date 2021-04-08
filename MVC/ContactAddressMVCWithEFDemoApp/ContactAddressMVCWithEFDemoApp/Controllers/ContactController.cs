using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactAddressMVCWithEFDemoApp.Services;
using ContactAddressMVCWithEFDemoApp.ViewModels;
using ContactAddressMVCWithEFDemoApp.Models;

namespace ContactAddressMVCWithEFDemoApp.Controllers
{
    public class ContactController : Controller
    {
        ContactService contactService = ContactService.GetInstance;
        AddressService addressService = AddressService.GetInstance;

        public ActionResult Index()
        {
            AllContactVM allContactVM = new AllContactVM();
            allContactVM.Contacts = contactService.GetContacts();

            foreach (var contact in allContactVM.Contacts)
            {
               allContactVM.Addresses.AddRange(addressService.GetAddresses(contact.ID));
            }
            return View(allContactVM);
        }

        public ActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddContact(ContactVM contactVM)
        {
            if (ModelState.IsValid)
            {
                string[] cities = contactVM.Address.City.Split(new char[] { ',' });
                List<Address> addresses = new List<Address>();
                foreach (var city in cities)
                {
                    addresses.Add(new Address { City = city });
                }
                contactService.AddContact(new Contact
                {
                    Name = contactVM.Contact.Name,
                    MobileNumber = contactVM.Contact.MobileNumber,
                    Addresses = addresses
                });
                return RedirectToAction("Index");
            }
            return View(contactVM);
        }

        public ActionResult UpdateContact(int id)
        {
            UpdateContactVM taskVM = new UpdateContactVM();
            taskVM.Contact = contactService.GetContactByID(id);
            taskVM.Contact.Addresses = addressService.GetAddresses(id);
            for (int i = 0; i < taskVM.Contact.Addresses.Count; i++)
            {
                if (i == taskVM.Contact.Addresses.Count - 1)
                {
                    taskVM.Cities += taskVM.Contact.Addresses[i].City;
                }
                else 
                {
                    taskVM.Cities += taskVM.Contact.Addresses[i].City + ",";
                }
            }
            return View(taskVM);
        }

        [HttpPost]
        public ActionResult UpdateContact(UpdateContactVM taskVM)
        {
            if (ModelState.IsValid)
            {
                contactService.UpdateContact(taskVM.Contact);
                return RedirectToAction("Index");
            }
            return View(taskVM);
        }

        public ActionResult DeleteContact(int id)
        {
            contactService.DeleteContact(id);
            return RedirectToAction("Index");
        }
    }
}