using System;
using System.Collections.Generic;

namespace OOADChapter1
{
    class FindGuitarTester
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            initializeInventory(inventory);

            GuitarSpec whatErinLikes = new GuitarSpec(Type.ELECTRIC,Builder.FENDER,  Wood.ALDER, Wood.ALDER, "Stratocastor",16);
            List<Guitar> guitars = inventory.Search(whatErinLikes);
            if (guitars.Count != 0)
            {
                Console.WriteLine("Erin, you might like these guitars : \n");
                foreach (var item in guitars)
                {
                    GuitarSpec guitarSpec = item.Spec;
                    Console.WriteLine(guitarSpec.GetBuilder + " " + guitarSpec.Model + "" +
                    guitarSpec.GetType + " guitar:\n" +
                    guitarSpec.BackWood + " back and sides,\n" +
                    guitarSpec.NumStrings + "num strings are present" +
                    guitarSpec.TopWood + " top.\nYou can have it for only $" +
                    item.Price + "!");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Sorry, Erin, we have nothing for you.");
            }
        }
        private static void initializeInventory(Inventory inventory)
        {
            inventory.AddGuitar("101", 250, Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER,16);
            inventory.AddGuitar("102", 250, Builder.MARTIN, "Guitar 1", Type.ACOUSTIC, Wood.COCOBOLO, Wood.ALDER,8);
            inventory.AddGuitar("103", 850, Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.ALDER,16);
        }
    }
 }

