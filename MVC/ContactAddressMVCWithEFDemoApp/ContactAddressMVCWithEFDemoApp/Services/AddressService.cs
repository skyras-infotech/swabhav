using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ContactAddressMVCWithEFDemoApp.Repository;
using ContactAddressMVCWithEFDemoApp.Models;

namespace ContactAddressMVCWithEFDemoApp.Services
{
    public class AddressService
    {
        private static AddressService _addressService;
        private AddressRepository repository = new AddressRepository(new ContactAddrDBContext());

        public static AddressService GetInstance
        {
            get
            {
                if (_addressService == null)
                {
                    _addressService = new AddressService();
                }
                return _addressService;
            }
        }

        public void AddAddress(Address address)
        {
            repository.AddAddress(address);
        }

        public void DeleteAddress(int id)
        {
            repository.DeleteAddress(id);
        }

        public List<Address> GetAddresses(int id)
        {
            return repository.GetAddresses(id);
        }

        public Address GetAddressByID(int id)
        {
            return repository.GetAddressByID(id);
        }

        public void UpdateAddress(Address address)
        {
            repository.EditAddress(address);
        }
    }
}