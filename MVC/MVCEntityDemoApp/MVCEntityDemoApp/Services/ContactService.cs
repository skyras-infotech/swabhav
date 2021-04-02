using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCEntityDemoApp.Models;

namespace MVCEntityDemoApp.Services
{
    public class ContactService
    {
        public List<Contact> GetContacts() 
        {
            List<Contact> contacts = new List<Contact>() 
            {
                new Contact(){ID = 101,FirstName="Sumit",LastName="Gupta",MobileNumber=9664695915,Address="Navsari"},
                new Contact(){ID = 102,FirstName="Yogesh",LastName="Patel",MobileNumber=9874563215,Address="Valsad"},
                new Contact(){ID = 103,FirstName="Karan",LastName="Patel",MobileNumber=9632587415,Address="Surat"}
            };
            return contacts;
        }
    }
}