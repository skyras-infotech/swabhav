using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCEntityDemoApp.Models;

namespace MVCEntityDemoApp.Repository
{
    interface IContactRepository
    {
        List<Contact> GetContacts();
       
        void AddContact(Contact contact);
    
        void AddContacts();
    }
}
