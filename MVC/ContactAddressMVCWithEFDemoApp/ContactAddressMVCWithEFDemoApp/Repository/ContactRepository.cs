using ContactAddressMVCWithEFDemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactAddressMVCWithEFDemoApp.Repository
{
    class ContactRepository : IContactRepository
    {
        public ContactAddrDBContext db;

        public ContactRepository(ContactAddrDBContext db)
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
            db.Contacts.Remove(db.Contacts.Where(x => x.ID == id).SingleOrDefault());
            db.SaveChanges();
        }

        public void EditContact(Contact c)
        {
            Contact contact = db.Contacts.Where(x => x.ID == c.ID).SingleOrDefault();
            contact.Name = c.Name;
            contact.MobileNumber = c.MobileNumber;
            db.SaveChanges();
        }

        public Contact GetContactByID(int id)
        {
            return db.Contacts.Where(x => x.ID == id).SingleOrDefault();
        }

        public List<Contact> GetContacts()
        {
            return db.Contacts.ToList();
        }
    }
}
