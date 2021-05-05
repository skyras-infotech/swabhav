using ContactApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ContactApp.Data.Repository
{
    public interface IContactRepository<T> where T : BaseEntity
    {
        Task<T> GetById(Guid id);
        Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate);

        Task Add(T entity);
        Task Update(T entity);
        Task Remove(T entity);

        Task<List<T>> GetAll();
        Task<List<T>> GetAllWithPreload(string include);
        Task<List<T>> GetAllWithPreloadWhere(Expression<Func<T, bool>> predicate, string include);
        Task<List<T>> GetWhere(Expression<Func<T, bool>> predicate);

        Task<int> CountAll();
        Task<int> CountWhere(Expression<Func<T, bool>> predicate);
        /* void AddContact(Contact contact);
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
         public bool DoesContactExist(Guid id);*/

    }
}
