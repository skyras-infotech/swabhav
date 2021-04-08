using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContactAddressMVCWithEFDemoApp.Repository;
using ContactAddressMVCWithEFDemoApp.Models;

namespace ContactAddressMVCWithEFDemoApp.Services
{
    public class ContactService
    {
        private static ContactService _contactService;
        private ContactRepository repository = new ContactRepository(new ContactAddrDBContext());

        public static ContactService GetInstance
        {
            get
            {
                if (_contactService == null)
                {
                    _contactService = new ContactService();
                }
                return _contactService;
            }
        }

        public void AddContact(Contact contact)
        {
            repository.AddContact(contact);
        }

        public void DeleteContact(int id)
        {
            repository.DeleteContact(id);
        }

        public List<Contact> GetContacts()
        {
            return repository.GetContacts();
        }

        public Contact GetContactByID(int id)
        {
            return repository.GetContactByID(id);
        }

        public void UpdateContact(Contact contact)
        {
            repository.EditContact(contact);
        }
    }
}