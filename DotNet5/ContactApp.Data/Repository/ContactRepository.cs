using ContactApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BC = BCrypt.Net.BCrypt;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ContactApp.Data.Repository
{
    public class ContactRepository<T> : IContactRepository<T> where T : BaseEntity
    {

        private readonly ContactDBContext _dbContext;

        public ContactRepository(ContactDBContext contactDB)
        {
            _dbContext = contactDB;
        }

        public async Task<T> GetById(Guid id) => await _dbContext.Set<T>().FindAsync(id);

        public Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate)
            => _dbContext.Set<T>().FirstOrDefaultAsync(predicate);

        public async Task Add(T entity)
        {
            // await _dbContext.AddAsync(entity);
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public Task Update(T entity)
        {
            // In case AsNoTracking is used
            _dbContext.Entry(entity).State = EntityState.Modified;
            return _dbContext.SaveChangesAsync();
        }

        public Task Remove(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            return _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate)
        {
            return await _dbContext.Set<T>().Where(predicate).ToListAsync();
        }

        public Task<int> CountAll() => _dbContext.Set<T>().CountAsync();

        public Task<int> CountWhere(Expression<Func<T, bool>> predicate)
            => _dbContext.Set<T>().CountAsync(predicate);

        /*// CRUD Contact
        public void AddContact(Contact contact)
        {
            _dbContext.Contacts.Add(contact);
            _dbContext.SaveChanges();
        }

        public void UpdateContact(Contact contact, Guid id)
        {
            Contact cont = _dbContext.Contacts.Where(x => x.ID == id).SingleOrDefault();
            cont.Name = contact.Name;
            cont.MobileNumber = contact.MobileNumber;
            _dbContext.Update(cont);
            _dbContext.SaveChanges();
        }

        public void DeleteContact(Guid id)
        {
            _dbContext.Contacts.Remove(_dbContext.Contacts.Where(x => x.ID == id).SingleOrDefault());
            _dbContext.SaveChanges();
        }

        public Contact GetContact(Guid id, Guid tenantID, Guid userID)
        {
            Contact contact = _dbContext.Contacts.Where(x => x.ID == id && x.UserID == userID && x.User.TenantID == tenantID).Include(x => x.Addresses).SingleOrDefault();
            if (contact != null)
            {
                return contact;
            }
            return null;
        }

        public IQueryable<Contact> GetContacts(Guid tenantID, Guid userID)
        {
            return _dbContext.Contacts.Where(x => x.UserID == userID && x.User.TenantID == tenantID).Include(x => x.Addresses).AsQueryable();
        }

        public Contact CheckMobileNoExist(long mobile) 
        {
            return _dbContext.Contacts.Where(x => x.MobileNumber == mobile).SingleOrDefault();    
        }

        // CRUD for Address
        public void AddAddress(Address address)
        {
            _dbContext.Addresses.Add(address);
            _dbContext.SaveChanges();
        }

        public void UpdateAddress(Address address, Guid id)
        {
            Address addr = _dbContext.Addresses.Where(x => x.ID == id).SingleOrDefault();
            addr.City = address.City;
            _dbContext.Update(addr);
            _dbContext.SaveChanges();
        }

        public void DeleteAddress(Guid id)
        {
            _dbContext.Addresses.Remove(_dbContext.Addresses.Where(x => x.ID == id).SingleOrDefault());
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

        public IQueryable<Address> GetAddresses(Guid tenantID, Guid userID, Guid contactID)
        {
            return _dbContext.Addresses.Where(x => x.ContactID == contactID && x.Contacts.UserID == userID && x.Contacts.User.TenantID == tenantID).AsQueryable();
        }

        // CRUD for Tenant
        public void AddTenent(Tenant tenant)
        {
            _dbContext.Tenants.Add(tenant);
            _dbContext.SaveChanges();
        }

        public void UpdateTenant(Tenant tenant, Guid id)
        {
            Tenant ten = _dbContext.Tenants.Where(x => x.ID == id).SingleOrDefault();
            ten.TenantName = tenant.TenantName;
            _dbContext.Update(ten);
            _dbContext.SaveChanges();
        }

        public void DeleteTenant(Guid id)
        {
            _dbContext.Tenants.Remove(_dbContext.Tenants.Where(x => x.ID == id).SingleOrDefault());
            _dbContext.SaveChanges();
        }

        public IQueryable<Tenant> GetTenants()
        {
            return _dbContext.Tenants.Include("Users.Contacts.Addresses").AsQueryable();
        }

        public Tenant GetTenant(Guid id)
        {
            return _dbContext.Tenants.Where(x => x.ID == id).Include("Users.Contacts.Addresses").SingleOrDefault();
        }

        public Tenant GetTenantByName(string tenantName)
        {
            return _dbContext.Tenants.Where(x => x.TenantName == tenantName).SingleOrDefault();
        }

        // CRUD for User
        public void AddUser(User user)
        {
            user.Password = BC.HashPassword(user.Password);
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        public void UpdateUser(User user, Guid id)
        {
            User usr = _dbContext.Users.Where(x => x.ID == id).SingleOrDefault();
            usr.Username = user.Username;
            usr.Password = user.Password;
            _dbContext.Update(usr);
            _dbContext.SaveChanges();
        }

        public void DeleteUser(Guid id)
        {
            _dbContext.Users.Remove(_dbContext.Users.Where(x => x.ID == id).SingleOrDefault());
            _dbContext.SaveChanges();
        }

        public User GetUser(Guid tenantID, Guid id)
        {
            User user = _dbContext.Users.Where(x => x.ID == id && x.TenantID == tenantID).Include("Contacts.Addresses").SingleOrDefault();
            if (user != null)
            {
                return user;
            }
            return null;
        }

        public IQueryable<User> GetUsers(Guid tenantID)
        {
            return _dbContext.Users.Where(x => x.TenantID == tenantID).Include("Contacts.Addresses").AsQueryable();
        }

        public int GetNoOfUsers(Guid tenantID) 
        {
            return _dbContext.Users.Where(x => x.TenantID == tenantID).Count();
        }

        public User CheckEmailExist(string email) 
        {
            return _dbContext.Users.Where(x => x.Email == email).SingleOrDefault();   
        }

        // Check for existance
        public bool DoesTenantExist(Guid id)
        {
            int count = _dbContext.Tenants.Where(x => x.ID == id).Count();
            if (count != 0)
                return true;
            return false;
        }

        public bool DoesUserExist(Guid id)
        {
            int count = _dbContext.Users.Where(x => x.ID == id).Count();
            if (count != 0)
                return true;
            return false;
        }

        public bool DoesContactExist(Guid id)
        {
            int count = _dbContext.Contacts.Where(x => x.ID == id).Count();
            if (count != 0)
                return true;
            return false;
        }

        public bool DoesAddressExist(Guid id)
        {
            int count = _dbContext.Addresses.Where(x => x.ID == id).Count();
            if (count != 0)
                return true;
            return false;
        }

        //Login User
        public User LoginUser(string email, string password, Guid tenantID)
        {
            User user = _dbContext.Users.Where(x => x.Email == email && x.TenantID == tenantID).SingleOrDefault();
            if (user != null)
            {
                if (BC.Verify(password, user.Password))
                {
                    return user;
                }
            }
            return null;
        }*/
    }
}
