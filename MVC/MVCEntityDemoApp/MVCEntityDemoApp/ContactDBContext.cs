using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVCEntityDemoApp.Models;

namespace MVCEntityDemoApp
{
    public class ContactDBContext  : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}