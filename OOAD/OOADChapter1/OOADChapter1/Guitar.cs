using System;

namespace OOADChapter1
{
    class Guitar
    {
        private String serialNumber;
        private double price;
        private GuitarSpec spec;

        public Guitar(string serialNumber, double price, GuitarSpec spec)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.spec = spec;
        }

        public string SerialNumber
        {
            get { return serialNumber; }
        }

        public GuitarSpec Spec
        {
            get { return spec; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

 
    }
}
