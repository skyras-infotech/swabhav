using ContactStoreConsoleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactStoreConsoleApp.DBContext;

namespace ContactStoreConsoleApp.Repository
{
    class ContactRepository : IContactRepository
    {
        public ContactDBContext db;

        public ContactRepository(ContactDBContext db)
        {
            this.db = db;
        }

        public void AddContact(Contact contact)
        {
            db.Contacts.Add(contact);
            db.SaveChanges();
        }

        public void DeleteContact(int id)
        {
            foreach (var contact in db.Contacts)
            {
                if (contact.ID == id) 
                {
                    db.Contacts.Remove(contact);
                    break;
                }
            }
            db.SaveChanges();
        }

        public void EditContact(int id,Contact c)
        {
            foreach (var contact in db.Contacts)
            {
                if (contact.ID == id) {
                    contact.FirstName = c.FirstName;
                    contact.LastName = c.LastName;
                    contact.MobileNumber = c.MobileNumber;
                }
            }
            db.SaveChanges();
        }

        public Contact GetContactByID(int id)
        {
            foreach (var contact in db.Contacts)
            {
                if (contact.ID == id)
                {
                    return contact;
                }
            }
            return null;
        }

        public List<Contact> GetContacts()
        {
            return db.Contacts.ToList();
        }

        public List<Contact> SearchContact(string name)
        {
            List<Contact> serachContacts = new List<Contact>();
            foreach (var contact in db.Contacts)
            {
                if (contact.FirstName.ToLower().Equals(name.ToLower()) || contact.FirstName.ToLower().Equals(name.ToLower())) {
                    serachContacts.Add(contact);
                }
            }
            return serachContacts;
        }
    }
}
