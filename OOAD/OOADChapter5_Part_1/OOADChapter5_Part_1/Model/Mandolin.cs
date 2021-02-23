using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADChapter5_Part_1.Model
{
    class Mandolin : Instrument
    {
        private String _serialNumber;
        private double _price;
        private MandolinSpec _spec;

        public Mandolin(string serialNumber, double price, MandolinSpec spec) : base(serialNumber, price, spec)
        {
        }
    }
}
