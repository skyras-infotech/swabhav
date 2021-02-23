using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADChapter5_Part_1.Model
{
    abstract class Instrument
    {
        private String _serialNumber;
        private double _price;
        private InstrumentSpec _spec;

        public Instrument(string serialNumber, double price, InstrumentSpec spec)
        {
            _serialNumber = serialNumber;
            _price = price;
            _spec = spec;
        }

        public string SerialNumber
        {
            get { return _serialNumber; }
        }

        public InstrumentSpec Spec
        {
            get { return _spec; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
