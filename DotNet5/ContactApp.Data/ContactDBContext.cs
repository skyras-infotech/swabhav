using ContactApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace ContactApp.Data
{
    public class ContactDBContext : DbContext
    {
        public ContactDBContext(DbContextOptions<ContactDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(x => x.Email).IsUnique();

            modelBuilder.Entity<Tenant>()
                .HasIndex(x => x.TenantName).IsUnique();

            modelBuilder.Entity<Contact>()
                .HasIndex(x => x.MobileNumber).IsUnique();
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<SuperUser> SuperUsers { get; set; }
    }
}
