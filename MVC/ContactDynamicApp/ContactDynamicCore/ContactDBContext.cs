using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ContactDynamicCore.Models;

namespace ContactDynamicCore
{
    public class ContactDBContext  : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}