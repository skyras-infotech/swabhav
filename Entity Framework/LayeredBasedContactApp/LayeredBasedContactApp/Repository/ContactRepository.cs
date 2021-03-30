using LayeredBasedContactApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredBasedContactApp.DBContext;

namespace LayeredBasedContactApp.Repository
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
            Contact c = db.Contacts.Where(x => x.ID == id).SingleOrDefault();
            db.Contacts.Remove(c);
            db.SaveChanges();
        }

        public void UpdateContact(int id, Contact c)
        {
            Contact contact = GetContactByID(id);
            
            contact.Name = c.Name == "" ? contact.Name : c.Name;
            contact.MobileNumber = c.MobileNumber == 0 ? contact.MobileNumber : c.MobileNumber;
            for (int i = 0; i < contact.Addresses.Count; i++)
            {
                contact.Addresses[i].City = c.Addresses[i].City == "" ? contact.Addresses[i].City : c.Addresses[i].City;
            }
            
            db.SaveChanges();
        }

        public Contact GetContactByID(int id)
        {
            var d = db.Contacts.GroupJoin(db.Addresses, c => c.ID, a => a.Contact.ID, (c, a) => new { Contacts = c, Addr = a }).Where(x => x.Contacts.ID == id).SingleOrDefault();
            if (d != null) { 
                Contact contact = new Contact();
                contact = d.Contacts;
                contact.Addresses = d.Addr.ToList();
                return contact;
            }
            return null;
        }

        public List<Contact> GetContacts()
        {
            List<Contact> contacts = new List<Contact>();
            var d = db.Contacts.GroupJoin(db.Addresses,c => c.ID,a => a.Contact.ID,(c,a) => new { Contacts = c, Addr = a }).ToList();
            Contact c1 = new Contact();
            foreach (var item in d)
            {
                c1 = item.Contacts;
                c1.Addresses = item.Addr.ToList();
                contacts.Add(c1);
            }
            return contacts;
        }

       
        public List<Contact> SearchContact(string name)
        {
            List<Contact> contacts = new List<Contact>();
            var d = db.Contacts.GroupJoin(db.Addresses, c => c.ID, a => a.Contact.ID, (c, a) => new { Contacts = c, Addr = a }).Where(x => x.Contacts.Name.ToLower().Equals(name.ToLower())).ToList();
            if (d != null) { 
                Contact c1 = new Contact();
                foreach (var item in d)
                {
                    c1 = item.Contacts;
                    c1.Addresses = item.Addr.ToList();
                    contacts.Add(c1);
                }
                return contacts;
            }
            return null;
        }
    }
}
