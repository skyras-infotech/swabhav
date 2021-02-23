using System;
using System.Collections;

namespace OOADChapter5_Part_1.Model
{
    class Inventory
    {
        private ArrayList _inventory;
        public Inventory()
        {
            _inventory = new ArrayList();
        }
        public void AddInstrument(String serialNumber, double price, InstrumentSpec spec)
        {
            Instrument instrument = null;
            if (spec is GuitarSpec) {
                instrument = new Guitar(serialNumber, price, (GuitarSpec)spec);
            } else if (spec is MandolinSpec) {
                instrument = new Mandolin(serialNumber, price, (MandolinSpec)spec);
            }
            _inventory.Add(instrument);
        }

        public Instrument GetInstrument(String serialNumber)
        {
            foreach (var item in _inventory)
            {
                Instrument instrument = (Instrument)item;
                if (instrument.SerialNumber.Equals(serialNumber))
                {
                    return instrument;
                }
            }
            return null;
        }
        public ArrayList Search(GuitarSpec searchGuitar)
        {
            ArrayList matchingGuitar = new ArrayList();
            foreach (var instrument in _inventory)
            {
                Guitar guitar = (Guitar)instrument;
                if (guitar.Spec.Matches(searchGuitar))
                    matchingGuitar.Add(guitar);
            }
            return matchingGuitar;
        }

        public ArrayList Search(MandolinSpec searchGuitar)
        {
            ArrayList matchingMandolin = new ArrayList();
            foreach (var instrument in _inventory)
            {
                Mandolin mandolin = (Mandolin)instrument;
                if (mandolin.Spec.Matches(searchGuitar))
                    matchingMandolin.Add(mandolin);
            }
            return matchingMandolin;
        }
    }
}
