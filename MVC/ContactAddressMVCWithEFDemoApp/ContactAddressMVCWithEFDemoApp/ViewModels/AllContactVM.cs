using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContactAddressMVCWithEFDemoApp.Models;

namespace ContactAddressMVCWithEFDemoApp.ViewModels
{
    public class AllContactVM
    {
        public List<Contact> Contacts { get; set; }
        public List<Address> Addresses { get; set; }

        public AllContactVM() 
        {
            Contacts = new List<Contact>();
            Addresses = new List<Address>();
        }
    }
}