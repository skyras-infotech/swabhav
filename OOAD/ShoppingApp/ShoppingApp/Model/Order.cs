using System;
using System.Collections.Generic;

namespace ShoppingApp.Model
{
    class Order
    {
        private Guid _id;
        private DateTime _dateTime;
        private List<LineItem> _items = new List<LineItem>();

        public Order(Guid id, DateTime dateTime)
        {
            _id = id;
            _dateTime = dateTime;
        }

        public void AddItem(LineItem item) {
            bool isAdded = false;
            if (_items.Equals(null))
            {
                _items.Add(item);
            }
            else {
                foreach (var lineItem in _items)
                {
                    if (lineItem.GetProduct.Equals(item.GetProduct)) {
                        lineItem.Quantity += item.Quantity;
                        isAdded = true;
                    }
                }
                if (!isAdded) {
                    _items.Add(item);
                }
            }
        }
        public double CheckoutCost() {
            double totalPrice = 0;
            foreach (var item in _items)
            {
                totalPrice += item.CalculateItemCost();
            }
            return totalPrice;
        }

        public List<LineItem> GetLineItems
        {
            get { return _items; }
        }


        public DateTime GetDateTime
        {
            get { return _dateTime; }
        }

        public Guid OID
        {
            get { return _id; }
        }

        public override string ToString()
        {
            return "\nOrder ID : " + OID + ", Booking Time : " + GetDateTime + ", Line Item List : " +
                "" + string.Join(",",GetLineItems);
        }
    }
}
