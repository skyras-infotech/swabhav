using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactAddressMVCWithEFDemoApp.Models;

namespace ContactAddressMVCWithEFDemoApp.Repository
{
    interface IContactRepository
    {
        List<Contact> GetContacts();
        void AddContact(Contact contact);
        void EditContact(Contact contact);
        void DeleteContact(int id);
        Contact GetContactByID(int id);
    }
}
