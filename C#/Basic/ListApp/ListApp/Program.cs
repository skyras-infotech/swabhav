using System;
using System.Collections;

namespace ListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string y = "y";
            int index;
            Console.WriteLine("--------- List Crud Opraration -----------");
            ArrayList list = new ArrayList();
            Console.WriteLine("1 - Add Data\n2 - Update Data\n3 - Delete Data\n4 - Display Data\n");
            while (y == "y" || y == "Y") {
            Console.Write("Enter your choice ==> ");
            int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice) {
                    case 1:
                        Console.Write("\nEnter data to add ==> ");
                        list.Add(Console.ReadLine());
                        Console.WriteLine("Data Added....");
                        break;
                    case 2:
                        Console.Write("\nEnter index to update data ==> ");
                        index= Convert.ToInt32(Console.ReadLine());
                        if (index < list.Count) {
                            Console.Write("\nEnter data to update ==> ");
                            list[index] = Console.ReadLine();
                            Console.WriteLine("Data Updated....");
                        }
                        else {
                            Console.WriteLine("index doesn't exists");
                        }
                        break;
                    case 3:
                        Console.Write("\nEnter index to delete data ==> ");
                        index = Convert.ToInt32(Console.ReadLine());
                        if (index < list.Count) {
                            list.RemoveAt(index);
                            Console.WriteLine("Data Deleted....");
                        } else {
                            Console.WriteLine("index doesn't exists");
                        }
                        break;
                    case 4:
                        Console.WriteLine("\n========== List Data ==========");
                        if (list.Count == 0) {
                            Console.WriteLine("Sorry you don't have any data please add the data");
                        } else {
                            foreach (var item in list) {
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
    }
}
