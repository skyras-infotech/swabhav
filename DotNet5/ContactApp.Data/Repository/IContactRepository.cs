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
        List<Contact> GetContacts(Guid tenantID,Guid userID);

        void AddAddress(Address address);
        Address GetAddress(Guid id, Guid tenantID, Guid userID,Guid contactID);
        List<Address> GetAddresses(Guid tenantID, Guid userID,Guid contactID);

        void AddTenent(Tenant tenant);
        List<Tenant> GetTenants();
        Tenant GetTenant(Guid id);

        void AddUser(User user);
        List<User> GetUsers(Guid tenantID);
        User GetUser(Guid tenantID,Guid id);

    }
}
