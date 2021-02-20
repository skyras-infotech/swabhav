using System;
using System.Collections.Generic;

namespace OOADChapter1
{
    class Inventory
    {
        private List<Guitar> guitars;
        public Inventory()
        {
            guitars = new List<Guitar>();
        }
        public void AddGuitar(String serialNumber, double price, Builder builder, String model, Type type, Wood backWood, Wood topWood,int numStrings)
        {
            GuitarSpec guitarSpec = new GuitarSpec(type,builder, backWood, topWood,model,numStrings);
            Guitar guitar = new Guitar(serialNumber, price,guitarSpec);
            guitars.Add(guitar);
        }
        public Guitar GetGuitar(String serialNumber)
        {
            foreach(var item in guitars)
            {
                Guitar guitar = (Guitar)item;
                if (guitar.SerialNumber.Equals(serialNumber))
                {
                    return guitar;
                }
            }
            return null;
        }
        public List<Guitar> Search(GuitarSpec searchGuitar)
        {
            List<Guitar> matchingGuitar = new List<Guitar>();
            foreach (var guitar in guitars)
            {
                if(guitar.Spec.Matches(searchGuitar))
                    matchingGuitar.Add(guitar);
            }
            return matchingGuitar;
        }
    }
}
