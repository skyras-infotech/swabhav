using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingCSVFileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Book1.csv";
            StreamReader reader = null;
            if (File.Exists(path))
            {
                reader = new StreamReader(File.OpenRead(path));
                List<string> listOfData = new List<string>();
                while (!reader.EndOfStream) {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    foreach (var item in values)
                    {
                        if (item.Equals(null) || item.Equals(""))
                        {
                            listOfData.Add("Unspecified");
                        }
                        else {
                            listOfData.Add(item);
                        }
                        
                    }
                    foreach (var data in listOfData)
                    {
                        Console.Write(data+" ");
                    }
                    listOfData.Clear();
                    Console.WriteLine();
                }
            }
            else {
                Console.WriteLine("File doesn't exists");
            }
            
        }
    }
}
