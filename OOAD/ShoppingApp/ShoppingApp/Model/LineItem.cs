using System;

namespace ShoppingApp.Model
{
    class LineItem
    {
        private Guid _id;
        private int _quantity;
        private Product _product;

        public LineItem(Guid id, int quantity, Product product)
        {
            _id = id;
            _quantity = quantity;
            _product = product;
        }

        public double CalculateItemCost() {
            return _quantity * _product.TotalCost();
        }

        public Product GetProduct
        {
            get { return _product; }
        }


        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }


        public Guid LI_ID
        {
            get { return _id; }
        }

        public override string ToString()
        {
            return "\n\t\tLine item ID : " + LI_ID + ", Products : " + GetProduct + ", Quantity : " +
                "" + Quantity + ", Item Cost : " + CalculateItemCost();
        }
    }
}
