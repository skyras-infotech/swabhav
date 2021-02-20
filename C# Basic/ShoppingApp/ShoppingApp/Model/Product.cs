using System;

namespace ShoppingApp.Model
{
    [Serializable]
    class Product
    {
        private Guid id;
        private string name;
        private double price;
        private float discount_price;

        public Product(Guid id, string name, double price, float discount_price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.discount_price = discount_price;
        }

        public double TotalCost() {
            double discount = price * (discount_price / 100);
            return price - discount;
        }

        public float DiscountPrice
        {
            get { return discount_price; }
        }

        public double Price
        {
            get { return price; }
        }

        public string ProductName
        {
            get { return name; }
        }

        public Guid PID
        {
            get { return id; }
        }

    }
}
