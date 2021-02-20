using System;

namespace ShoppingApp.Model
{
    [Serializable]
    class LineItem
    {
        private Guid id;
        private int quantity;
        private Product product;

        public LineItem(Guid id, int quantity, Product product)
        {
            this.id = id;
            this.quantity = quantity;
            this.product = product;
        }

        public double CalculateItemCost() {
            return quantity * product.TotalCost();
        }

        public Product GetProduct
        {
            get { return product; }
        }


        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }


        public Guid LI_ID
        {
            get { return id; }
        }

    }
}
