namespace GenericCollectionApp.Model
{
    class Product
    {
        private int id;
        private string name;
        private double unitPrice;
        private int quantity;
        private static double grandTotal = 0;

        public Product(int id, string name, double unitPrice, int quantity)
        {
            this.id = id;
            this.name = name;
            this.unitPrice = unitPrice;
            this.quantity = quantity;
        }

        public static double GrandTotal
        {
            get { return grandTotal; }
            set { grandTotal = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public double UnitPrice
        {
            get { return unitPrice; }
            set { unitPrice = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public double GetGrandTotal()
        {
            return this.UnitPrice * this.Quantity;
        }
    }
}
