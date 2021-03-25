using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactStoreConsoleApp.Model;

namespace ContactStoreConsoleApp.DBContext
{
    class ContactDBContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}
