using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactApp.Domain;

namespace ContactApp.Data.Repository
{
    public interface IContactRepository
    {
        void AddContact(Contact contact);
        Contact GetContact(Guid id, Guid tenantID, Guid userID);
        IQueryable<Contact> GetContacts(Guid tenantID, Guid userID);
        void UpdateContact(Contact contact, Guid id);
        void DeleteContact(Guid id);
        Contact CheckMobileNoExist(long mobile);

        void AddAddress(Address address);
        Address GetAddress(Guid id, Guid tenantID, Guid userID, Guid contactID);
        IQueryable<Address> GetAddresses(Guid tenantID, Guid userID, Guid contactID);
        void UpdateAddress(Address address, Guid id);
        void DeleteAddress(Guid id);

        void AddTenent(Tenant tenant);
        Tenant GetTenant(Guid id);
        Tenant GetTenantByName(string tenantName);
        IQueryable<Tenant> GetTenants();
        void UpdateTenant(Tenant tenant, Guid id);
        void DeleteTenant(Guid id);

        void AddUser(User user);
        User GetUser(Guid tenantID, Guid id);
        IQueryable<User> GetUsers(Guid tenantID);
        void UpdateUser(User user, Guid id);
        void DeleteUser(Guid id);
        User LoginUser(string email, string password,Guid tenantID);
        int GetNoOfUsers(Guid tenantID);
        User CheckEmailExist(string email);

        public bool DoesTenantExist(Guid id);
        public bool DoesAddressExist(Guid id);
        public bool DoesUserExist(Guid id);
        public bool DoesContactExist(Guid id);

    }
}
