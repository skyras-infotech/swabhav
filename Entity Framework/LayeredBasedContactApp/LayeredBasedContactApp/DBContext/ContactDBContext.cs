using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredBasedContactApp.Model;

namespace LayeredBasedContactApp.DBContext
{
    class ContactDBContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
