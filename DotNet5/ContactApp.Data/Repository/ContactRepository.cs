using ContactApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ContactApp.Data.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly ContactDBContext _dbContext;

        public ContactRepository(ContactDBContext contactDB)
        {
            _dbContext = contactDB;
        }

        public void AddAddress(Address address)
        {
            _dbContext.Addresses.Add(address);
            _dbContext.SaveChanges();
        }

        public void AddContact(Contact contact)
        {
            _dbContext.Contacts.Add(contact);
            _dbContext.SaveChanges();
        }

        public void AddTenent(Tenant tenant)
        {
            _dbContext.Tenants.Add(tenant);
            _dbContext.SaveChanges();
        }

        public void AddUser(User user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        public Address GetAddress(Guid id, Guid tenantID, Guid userID, Guid contactID)
        {
            Address address = _dbContext.Addresses.Where(x => x.ID == id && x.ContactID == contactID && x.Contacts.UserID == userID && x.Contacts.User.TenantID == tenantID).SingleOrDefault();
            if (address != null)
            {
                return address;
            }
            return null;
        }

        public List<Address> GetAddresses(Guid tenantID, Guid userID, Guid contactID)
        {
           return _dbContext.Addresses.Where(x => x.ContactID == contactID && x.Contacts.UserID == userID && x.Contacts.User.TenantID == tenantID).ToList();
        }

        public Contact GetContact(Guid id,Guid tenantID,Guid userID)
        {
            Contact contact = _dbContext.Contacts.Where(x => x.ID == id && x.UserID == userID && x.User.TenantID == tenantID).Include(x => x.Addresses).SingleOrDefault();
            if (contact != null)
            {
                return contact;
            }
            return null;
        }

        public List<Contact> GetContacts(Guid tenantID,Guid userID)
        {
            return _dbContext.Contacts.Where(x => x.UserID == userID && x.User.TenantID == tenantID).Include(x => x.Addresses).ToList();
        }

        public Tenant GetTenant(Guid id)
        {
            return _dbContext.Tenants.Where(x => x.ID == id).Include("Users.Contacts.Addresses").SingleOrDefault();
        }

        public List<Tenant> GetTenants() 
        {
            return _dbContext.Tenants.Include("Users.Contacts.Addresses").ToList();
        }

        public User GetUser(Guid tenantID,Guid id)
        {
            User user = _dbContext.Users.Where(x => x.ID == id && x.TenantID == tenantID).Include("Contacts.Addresses").SingleOrDefault();
            if (user != null) 
            {
                return user;
            }
            return null;
        }

        public List<User> GetUsers(Guid tenantID)
        {
            return _dbContext.Users.Where(x => x.TenantID == tenantID).Include("Contacts.Addresses").ToList();
        }
    }   
}
