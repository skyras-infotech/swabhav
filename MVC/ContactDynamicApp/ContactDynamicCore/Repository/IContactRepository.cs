using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactDynamicCore.Models;

namespace ContactDynamicCore.Repository
{
    public interface IContactRepository
    {
        List<Contact> GetContacts();
        void AddContact(Contact contact);
        void EditContact(Contact contact);
        void DeleteContact(int id);
        Contact GetContactByID(int id);
    }
}
