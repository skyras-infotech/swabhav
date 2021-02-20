using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryApp.Model;

namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library("Sayaji Library", "Junathana, Navsari",new List<Book>() { 
                new Book(101,"C++","Balaguru Swami"),
                new Book(102,"Clean Code","Robert C. Martin"),
                new Book(103,"Java","Steve McConnell"),
                new Book(104,"C#","Dennish Ritchie"),
                new Book(105,"GoLang","Erich Gamma"),
            });

            PrintInfo(library);
        }

        private static void PrintInfo(Library library)
        {
            Console.WriteLine("------------- Library Info ------------");
            Console.WriteLine("Name         :   " + library.LibraryName);
            Console.WriteLine("Address      :   " + library.Address);
            Console.WriteLine("No of Books  :   " + library.GetBooks.Count);
            Console.WriteLine("\n------------- Book Info ----------------\n");
            foreach (var book in library.GetBooks)
            {
                Console.WriteLine("ID           :   "+ book.BookID);
                Console.WriteLine("Name         :   " + book.BookName);
                Console.WriteLine("Author       :   " + book.AuthorName);
                Console.WriteLine();
            }
        }
    }
}
