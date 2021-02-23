using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOADChapter5_Part_1.Model;

namespace OOADChapter5_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            initializeInventory(inventory);

            GuitarSpec whatErinLikes = new GuitarSpec(Model.Type.ELECTRIC, Builder.FENDER, Wood.ALDER, Wood.ALDER, "Stratocastor", 16);
            ArrayList guitars = inventory.Search(whatErinLikes);
            if (guitars.Count != 0)
            {
                Console.WriteLine("Erin, you might like these guitars : \n");
                foreach (var item in guitars)
                {
                    Guitar guitar = (Guitar)item;
                    GuitarSpec guitarSpec = (GuitarSpec)guitar.Spec;
                    Console.WriteLine(guitarSpec.GetBuilder + " " + guitarSpec.Model + "" +
                    guitarSpec.GetInsType + " guitar:\n" +
                    guitarSpec.BackWood + " back and sides,\n" +
                    guitarSpec.NumStrings + " num strings are present" +
                    guitarSpec.TopWood + " top.\nYou can have it for only $" +
                    guitar.Price + "!");
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
            inventory.AddInstrument("101", 250, new GuitarSpec(Model.Type.ELECTRIC, Builder.FENDER, Wood.ALDER, Wood.ALDER, "Stratocastor",16));
            inventory.AddInstrument("102", 500, new GuitarSpec(Model.Type.ELECTRIC, Builder.FENDER, Wood.ALDER, Wood.ALDER, "Guitar 1",8));
            inventory.AddInstrument("103", 250, new GuitarSpec(Model.Type.ELECTRIC, Builder.FENDER, Wood.ALDER, Wood.ALDER, "Stratocastor",16));
        }
    }
}
