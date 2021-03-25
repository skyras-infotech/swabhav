using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactStoreConsoleApp.Model;

namespace ContactStoreConsoleApp.Repository
{
    interface IContactRepository
    {
        List<Contact> GetContacts();
        List<Contact> SearchContact(string name);
        void AddContact(Contact contact);
        void EditContact(int id,Contact c);
        void DeleteContact(int id);
        Contact GetContactByID(int id);
    }
}
