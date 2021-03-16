using System;
using System.Collections.Generic;
using System.Linq;

namespace SetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string y = "y";
            string content,updatedData;
            Console.WriteLine("--------- HashSet Crud Opraration -----------");
            HashSet<string> listOfHashSet = new HashSet<string>();
            Console.WriteLine("1 - Add Data\n2 - Update Data\n3 - Delete Data\n4 - Display Data\n");
            while (y == "y" || y == "Y")
            {
                Console.Write("Enter your choice ==> ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("\nEnter data to add ==> ");
                        listOfHashSet.Add(Console.ReadLine());
                        Console.WriteLine("Data Added....");
                        break;
                    case 2:
                        Console.Write("\nEnter data to be update ==> ");
                        content = Console.ReadLine();
                        if (!CheckDataIsExistOrNot(listOfHashSet, content)) {
                            Console.WriteLine("Sorry there is no data with this name");
                        } else {
                            Console.Write("\nEnter data to update ==> ");
                            updatedData = Console.ReadLine();
                            foreach (string item in listOfHashSet.ToList()) {
                                if (item.Equals(content)) {
                                    listOfHashSet.Remove(item);
                                    listOfHashSet.Add(updatedData);
                                    Console.WriteLine("Data Updated...");
                                }
                            }
                        }
                        break;
                    case 3:
                        Console.Write("\nEnter data to be delete ==> ");
                        content = Console.ReadLine();
                        if (!CheckDataIsExistOrNot(listOfHashSet, content)) {
                            Console.WriteLine("Sorry there is no data with this name");
                        } else {
                            foreach (string item in listOfHashSet.ToList()) {
                                if (item.Equals(content)) {
                                    listOfHashSet.Remove(item);
                                    Console.WriteLine("Data Deleted...");
                                }
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("\n========== HashSet Data ==========");
                        if (listOfHashSet.Count == 0) {
                            Console.WriteLine("Sorry you don't have any data please add the data");
                        } else {
                            foreach (var item in listOfHashSet) {
                                Console.WriteLine(item);
                            }
                        }
                        break;
                }
                Console.Write("\nEnter y to continue.. ");
                y = Console.ReadLine();
                Console.WriteLine();
            }
        }
        static bool CheckDataIsExistOrNot(HashSet<String> listOfHashSet, string data) {
            foreach (var item in listOfHashSet) {
                if (item.Equals(data)) {
                    return true;
                }
            }
            return false;
        }
    }
}
