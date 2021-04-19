using Microsoft.EntityFrameworkCore;
using System;
using ContactApp.Domain;

namespace ContactApp.Data
{
    public class ContactDBContext : DbContext
    {
        public ContactDBContext(DbContextOptions<ContactDBContext> options) :base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
    }
}
