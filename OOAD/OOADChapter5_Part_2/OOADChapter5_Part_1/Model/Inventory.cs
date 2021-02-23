using System;
using System.Collections;

namespace OOADChapter5_Part_2.Model
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
            Instrument instrument = new Instrument(serialNumber,price,spec);
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
        public ArrayList Search(InstrumentSpec searchGuitar)
        {
            ArrayList matchingInstruments = new ArrayList();
            foreach (var item in _inventory)
            {
                Instrument instrument = (Instrument)item;
                if (instrument.Spec.Matches(searchGuitar))
                    matchingInstruments.Add(instrument);
            }
            return matchingInstruments;
        }
    }
}
