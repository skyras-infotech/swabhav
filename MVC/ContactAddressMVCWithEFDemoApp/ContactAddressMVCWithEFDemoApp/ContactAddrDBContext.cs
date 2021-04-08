using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ContactAddressMVCWithEFDemoApp.Models;

namespace ContactAddressMVCWithEFDemoApp
{
    public class ContactAddrDBContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}