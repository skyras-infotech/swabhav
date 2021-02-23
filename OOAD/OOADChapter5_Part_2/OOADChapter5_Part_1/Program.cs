using System;
using System.Collections;
using OOADChapter5_Part_2.Model;

namespace OOADChapter5_Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            initializeInventory(inventory);

            Hashtable properties = new Hashtable();
            properties.Add("builder", Builder.GIBSON);
            properties.Add("backWood", Wood.MAPLE);

            InstrumentSpec instrumentSpec = new InstrumentSpec(properties);

            ArrayList matchingInstruments = inventory.Search(instrumentSpec);
            
            if (matchingInstruments.Count != 0)
            {
                Console.WriteLine("Bryan, you might like these instruments: ");
                foreach (var item in matchingInstruments)
                {
                    Instrument instrument = (Instrument)item;
                    InstrumentSpec spec = instrument.Spec;

                    Console.WriteLine("We have a " + spec.GetProperty("instrumentType") + " with the following properties:");
                    foreach (var itemType in spec.GetProperties.Keys)
                    {
                        String propertyName = (String)itemType;
                        if (propertyName.Equals("instrumentType"))
                        {
                            continue;
                        }
                        Console.WriteLine("    " + propertyName + ": " + spec.GetProperty(propertyName));
                    }
                    Console.WriteLine("  You can have this " + spec.GetProperty("instrumentType") + " for $" + instrument.Price + "\n---");

                }
            }
            else {
                Console.WriteLine("Sorry, Bryan, we have nothing for you.");
            }
            
        }
        private static void initializeInventory(Inventory inventory)
        {
            Hashtable properties = new Hashtable();
            properties.Add("instrumentType", InstrumentType.GUITAR);
            properties.Add("builder", Builder.GIBSON);
            properties.Add("model", "CJ");
            properties.Add("type", Model.Type.ACOUSTIC);
            properties.Add("numStrings", 6);
            properties.Add("topWood", Wood.INDIAN_ROSEWOOD);
            properties.Add("backWood", Wood.MAPLE);
            inventory.AddInstrument("11277", 3999.95, new InstrumentSpec(properties));
            properties.Clear();

            properties.Add("builder", Builder.MARTIN);
            properties.Add("model", "D-18");
            properties.Add("topWood", Wood.MAHOGANY);
            properties.Add("backWood", Wood.ADIRONDACK);
            inventory.AddInstrument("122784", 5495.95, new InstrumentSpec(properties));
            properties.Clear();

            properties.Add("builder", Builder.FENDER);
            properties.Add("model", "Stratocastor");
            properties.Add("type", Model.Type.ELECTRIC);
            properties.Add("topWood", Wood.ALDER);
            properties.Add("backWood", Wood.ALDER);
            inventory.AddInstrument("V95693", 1499.95, new InstrumentSpec(properties));
            inventory.AddInstrument("V9512", 1549.95, new InstrumentSpec(properties));
            properties.Clear();

            properties.Add("builder", Builder.GIBSON);
            properties.Add("model", "Les Paul");
            properties.Add("topWood", Wood.MAPLE);
            properties.Add("backWood", Wood.MAPLE);
            inventory.AddInstrument("70108276", 2295.95, new InstrumentSpec(properties));
            properties.Clear();

        }
    }
}
