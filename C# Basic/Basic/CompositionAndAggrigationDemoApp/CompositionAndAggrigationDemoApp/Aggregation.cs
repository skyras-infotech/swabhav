using System;

namespace CompositionAndAggrigationDemoApp
{
    class Aggregation
    {
        static void Main(string[] args)
        {
            Address address = new Address("Navsari");
            Person p1 = new Person("John Dae",address);
            PrintInfo(p1);

        }
        public static void PrintInfo(Person p) {
            Console.WriteLine("Name is "+p.PersonName);
            Console.WriteLine("Address is "+p.Addr.GetAddress);
        }
    }

    class Address
    {
        private string addr;
        public Address(string addr)
        {
            this.addr = addr;
        }
        public string GetAddress
        {
            get { return addr; }
        }

    }

    class Person
    {
        private string personName;
        private Address addr;
        public Person(string personName, Address addr)
        {
            this.personName = personName;
            this.addr = addr;
        }
        public string PersonName
        {
            get { return personName; }
        }
        public Address Addr
        {
            get { return addr; }
        }
    }
}
