using System;
using System.Collections.Generic;

namespace ShoppingApp.Model
{
    [Serializable]
    class Order
    {
        private Guid id;
        private DateTime dateTime;
        private List<LineItem> items = new List<LineItem>();

        public Order(Guid id, DateTime dateTime)
        {
            this.id = id;
            this.dateTime = dateTime;
        }

        public void AddItem(LineItem item) {
            items.Add(item);
        }
        public double CheckoutCost() {
            double totalPrice = 0;
            foreach (var item in items)
            {
                totalPrice += item.CalculateItemCost();
            }
            return totalPrice;
        }

        public List<LineItem> GetLineItems
        {
            get { return items; }
        }


        public DateTime GetDateTime
        {
            get { return dateTime; }
        }


        public Guid OID
        {
            get { return id; }
        }

    }
}
