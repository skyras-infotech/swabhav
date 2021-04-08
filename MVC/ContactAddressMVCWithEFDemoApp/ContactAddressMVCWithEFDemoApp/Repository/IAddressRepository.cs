using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactAddressMVCWithEFDemoApp.Models;

namespace ContactAddressMVCWithEFDemoApp.Repository
{
    interface IAddressRepository
    {
        List<Address> GetAddresses(int id);
        void AddAddress(Address address);
        void EditAddress(Address address);
        void DeleteAddress(int id);
        Address GetAddressByID(int id);
    }
}
