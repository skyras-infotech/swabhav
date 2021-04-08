using ContactAddressMVCWithEFDemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ContactAddressMVCWithEFDemoApp.Repository
{
    class AddressRepository : IAddressRepository
    {
        public ContactAddrDBContext db;

        public AddressRepository(ContactAddrDBContext db)
        {
            this.db = db;
        }

        public void AddAddress(Address addr)
        {
            db.Addresses.Add(addr);
            db.SaveChanges();
        }

        public void DeleteAddress(int id)
        {
            db.Addresses.Remove(db.Addresses.Where(x => x.ID == id).SingleOrDefault());
            db.SaveChanges();
        }

        public void EditAddress(Address address)
        {
            Address addr  = db.Addresses.Where(x => x.ID == address.ID).SingleOrDefault();
            addr.City = address.City;
            db.SaveChanges();
        }

        public Address GetAddressByID(int id)
        {
            return db.Addresses.Where(x => x.ID == id).SingleOrDefault();
        }

        public List<Address> GetAddresses(int id)
        {
            return db.Addresses.Where(x => x.ContactID == id).ToList();
        }
    }
}
