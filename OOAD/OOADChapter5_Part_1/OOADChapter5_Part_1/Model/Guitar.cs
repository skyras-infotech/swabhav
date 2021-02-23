using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADChapter5_Part_1.Model
{
    class Guitar : Instrument
    {
        private String serialNumber;
        private double price;
        private GuitarSpec spec;

        public Guitar(string serialNumber, double price, GuitarSpec spec) : base(serialNumber, price, spec)
        {
        }
    }
}
