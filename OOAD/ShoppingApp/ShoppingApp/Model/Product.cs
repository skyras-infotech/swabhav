using System;

namespace ShoppingApp.Model
{
    public class Product
    {
        private Guid _id;
        private string _name;
        private double _price;
        private float _discountPrice;

        public Product(Guid id, string name, double price, float discountPrice)
        {
            _id = id;
            _name = name;
            _price = price;
            _discountPrice = discountPrice;
        }

        public double TotalCost() {
            double discount = _price * (_discountPrice / 100);
            return _price - discount;
        }

        public float DiscountPrice
        {
            get { return _discountPrice; }
        }

        public double Price
        {
            get { return _price; }
        }

        public string ProductName
        {
            get { return _name; }
        }

        public Guid PID
        {
            get { return _id; }
        }

        public override string ToString()
        {
            return "\n\t\t\tProduct ID : " + PID+", Name : "+ProductName+", Base Price : " +
                ""+Price+", Discount Percentage : "+DiscountPrice+", Total Cost : "+TotalCost();
        }
    }
}
