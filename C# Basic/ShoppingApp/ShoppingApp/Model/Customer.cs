using System.Collections.Generic;
using System;

namespace ShoppingApp.Model
{
    [Serializable]
    class Customer
    {
        private Guid id;
        private string name;
        private string address;
        private List<Order> orders = new List<Order>();

        public Customer(Guid id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public List<Order> GetOrders
        {
            get { return orders; }
            set { orders = value; }
        }


        public string Address
        {
            get { return address; }
        }


        public string CustomerName
        {
            get { return name; }
        }


        public Guid CID
        {
            get { return id; }
        }

    }
}
