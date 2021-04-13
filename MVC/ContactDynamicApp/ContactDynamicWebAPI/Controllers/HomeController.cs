using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ContactDynamicCore.Models;
using ContactDynamicCore.Services;

namespace ContactDynamicWebAPI.Controllers
{
    public class HomeController : ApiController
    {
        private readonly ContactService contactService;
        public HomeController(ContactService contactService)
        {
            this.contactService = contactService;
        }

        [HttpGet]
        public List<Contact> GetContacts()
        {
            return contactService.GetContacts();
        }

        [HttpGet]
        public Contact GetContact(int id)
        {
            return contactService.GetContactByID(id);
        }

        [HttpPost]
        public IHttpActionResult AddContact([FromBody] Contact contact)
        {
            if (ModelState.IsValid)
            {
                Contact cnt = new Contact()
                {
                    Name = contact.Name,
                    MobileNumber = contact.MobileNumber,
                    Address = contact.Address
                };
                contactService.AddContact(cnt);
                return Ok("Contact Added Sucessfully");
            }
            else
            {
                List<string> str = new List<string>();
                foreach (var item in ModelState.Keys)
                {
                    if (!ModelState.IsValidField(item))
                    {
                        str.Add(item);
                    }
                }
                return BadRequest("Contact not added " + str[0]);
            }
        }

        [HttpPut]
        public IHttpActionResult UpdateContact([FromBody] Contact contact)
        {
            contactService.UpdateContact(contact);
            return Ok("Contact Updated Sucessfully");
        }

        [HttpDelete]
        public IHttpActionResult DeleteContact(int id)
        {
            contactService.DeleteContact(id);
            return Ok("Contact Deleted Sucessfully");
        }
    }
}
