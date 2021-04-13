using ContactDynamicCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactDynamicCore.Services;


namespace ContactDynamicCore.Repository
{
    public class ContactRepository : IContactRepository
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
            db.Contacts.Remove(db.Contacts.Where(x => x.ID == id).SingleOrDefault());
            db.SaveChanges();
        }

        public void EditContact(Contact c)
        {
            Contact contact = db.Contacts.Where(x => x.ID == c.ID).SingleOrDefault();
            contact.Name = c.Name;
            contact.MobileNumber = c.MobileNumber;
            contact.Address = c.Address;
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
