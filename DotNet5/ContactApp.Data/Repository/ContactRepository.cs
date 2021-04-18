using ContactApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp.Data.Repository
{
    public class ContactRepository : IContactRepository
    {
        private readonly ContactDBContext _dbContext;

        public ContactRepository(ContactDBContext contactDB)
        {
            _dbContext = contactDB;
        }

        public List<Contact> GetContacts()
        {
            return _dbContext.Contacts.ToList();
        }

        public List<Contact> GetContactsWithAddress()
        {
            List<Contact> contacts = _dbContext.Contacts.ToList();
            foreach (var contact in contacts)
            {
                contact.Addresses = _dbContext.Addresses.Where(x => x.ContactID == contact.ID).ToList();
            }
            return contacts;
        }
    }
}
