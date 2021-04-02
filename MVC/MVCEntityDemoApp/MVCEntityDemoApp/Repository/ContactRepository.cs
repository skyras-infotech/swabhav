using MVCEntityDemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCEntityDemoApp.Services;


namespace MVCEntityDemoApp.Repository
{
    class ContactRepository : IContactRepository
    {
        public ContactDBContext db = new ContactDBContext();
        public ContactService contactService = new ContactService();

        public void AddContact(Contact contact)
        {
            db.Contacts.Add(contact);
            db.SaveChanges();
        }

        public void AddContacts() 
        {
            foreach (var contact in contactService.GetContacts())
            {
                AddContact(contact);
            }
        }

        public List<Contact> GetContacts()
        {
            return db.Contacts.ToList();
        }
    }
}
