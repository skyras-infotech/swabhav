using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContactDynamicCore.Models;
using ContactDynamicCore.Repository;

namespace ContactDynamicCore.Services
{
    public class ContactService
    {
        private ContactRepository repository;

        public ContactService(ContactRepository repository)
        {
            this.repository = repository;
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