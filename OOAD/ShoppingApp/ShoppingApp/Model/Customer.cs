using System.Collections.Generic;
using System;

namespace ShoppingApp.Model
{
    class Customer
    {
        private Guid _id;
        private string _name;
        private string _address;
        private List<Order> _orders = new List<Order>();

        public Customer(Guid id, string name, string address)
        {
            _id = id;
            _name = name;
            _address = address;
        }

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public List<Order> GetOrders
        {
            get { return _orders; }
        }


        public string Address
        {
            get { return _address; }
        }


        public string CustomerName
        {
            get { return _name; }
        }


        public Guid CID
        {
            get { return _id; }
        }

    }
}
