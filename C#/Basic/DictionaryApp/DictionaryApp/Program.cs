using System;
using System.Collections.Generic;

namespace DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string y = "y";
            string key,data;
            Console.WriteLine("--------- Dictionary CRUD Opraration -----------");
            Dictionary<string, string> listOfDict = new Dictionary<string, string>();
            Console.WriteLine("1 - Add Data\n2 - Update Data\n3 - Delete Data\n4 - Display Data\n");
            while (y == "y" || y == "Y")
            {
                Console.Write("Enter your choice ==> ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("\nEnter key ==> ");
                        key = Console.ReadLine();
                        Console.Write("Enter value ==> ");
                        data = Console.ReadLine();
                        listOfDict.Add(key, data);
                        Console.WriteLine("Data Added...");
                        break;
                    case 2:
                        Console.Write("\nEnter key to update value ==> ");
                        key = Console.ReadLine();
                        if (!CheckKeyIsExistOrNot(listOfDict, key))
                        {
                            Console.WriteLine("this key is not present");
                        }
                        else {
                            Console.Write("Enter value ==> ");
                            data = Console.ReadLine();
                            listOfDict[key] = data;
                            Console.WriteLine("Data Updated...");
                        }
                        break;
                    case 3:
                        Console.Write("\nEnter key to delete data ==> ");
                        key = Console.ReadLine();
                        if (!CheckKeyIsExistOrNot(listOfDict, key)) {
                            Console.WriteLine("this key is not present");
                        } else {
                            listOfDict.Remove(key);
                            Console.WriteLine("Data Deleted...");
                        }
                        break;
                    case 4:
                        Console.WriteLine("\n========== Dictionary Data ==========");
                        if (listOfDict.Count == 0) {
                            Console.WriteLine("Sorry you don't have any dictionary please add");
                        } else {
                            Console.WriteLine("\n----Key----    --------Value------");
                            foreach (var item in listOfDict) {
                                Console.WriteLine("     "+item.Key+"                "+item.Value);
                            }
                        }
                        break;
                }
                Console.Write("\nEnter y to continue.. ");
                y = Console.ReadLine();
                Console.WriteLine();
            }
        }
        static bool CheckKeyIsExistOrNot(Dictionary<string,string> listOfDict, string key) {
            foreach (var item in listOfDict) {
                if (item.Key.Equals(key)) {
                    return true;
                }
            }
            return false;
        }
    }
}
