using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactApp.Domain;

namespace ContactApp.Data.Repository
{
    public interface IContactRepository
    {
        List<Contact> GetContacts();
        List<Contact> GetContactsWithAddress();
    }
}
