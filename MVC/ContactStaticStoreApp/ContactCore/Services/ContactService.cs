using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactCore.Models;

namespace ContactCore.Services
{
    public class ContactService
    {
        private List<Contact> _contactsList = null;

        public ContactService() 
        {
            _contactsList = new List<Contact>();
            _contactsList.Add(new Contact { ID = 101, Name = "Sumit Gupta", Address = "Navsari", MobileNumber = 9664695915 });
            _contactsList.Add(new Contact { ID = 102, Name = "Yogesh Patel", Address = "Selvaasa", MobileNumber = 9517532486 });
            _contactsList.Add(new Contact { ID = 103, Name = "Ramesh Gandhi", Address = "Surat", MobileNumber = 7600965621 });
            _contactsList.Add(new Contact { ID = 104, Name = "Raju Rathod", Address = "Valsad", MobileNumber = 9874123658 });
            _contactsList.Add(new Contact { ID = 105, Name = "Karan Patel", Address = "Ancheli", MobileNumber = 9632587415 });
        }

        public void AddContact(Contact contact)
        {
            _contactsList.Add(contact);
        }

        public void DeleteContact(int id)
        {
            _contactsList.Remove(_contactsList.Where(x => x.ID == id).SingleOrDefault());
        }

        public List<Contact> GetContacts()
        {
            return _contactsList;
        }

        public Contact GetContactByID(int id)
        {
            return _contactsList.Where(x => x.ID == id).SingleOrDefault();
        }

        public void UpdateContact(Contact contact)
        {
            Contact cnt = _contactsList.Where(x => x.ID == contact.ID).SingleOrDefault();
            cnt.Name = contact.Name;
            cnt.MobileNumber = contact.MobileNumber;
            cnt.Address = contact.Address;
        }
    }
}
