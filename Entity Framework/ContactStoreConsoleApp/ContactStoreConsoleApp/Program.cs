using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactStoreConsoleApp.Model;
using ContactStoreConsoleApp.Repository;
using ContactStoreConsoleApp.DBContext;

namespace ContactStoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactRepository repository = new ContactRepository(new ContactDBContext());

            Console.WriteLine("======== Welcome to the Contact App ========");
            int choice;
      
            while (true) 
            { 
                Console.WriteLine("\n1 - Add Contact\n2 - Update Contact\n3 - Delete Contact\n4 - View Contacts\n5 - Search Contact\n");
                Console.Write("Enter your choice ==> ");
                choice = int.Parse(Console.ReadLine());
                switch (choice) {
                    case 1:
                        AddContact(repository);
                        break;
                    case 2:
                        UpdateContact(repository);
                        break;
                    case 3:
                        DeleteContact(repository);
                        break;
                    case 4:
                        ViewContacts(repository);
                        break;
                    case 5:
                        SearchContact(repository);
                        break;
                    default:
                        Console.WriteLine("Please select correct options ");
                        break;
                }
            }
        }

        private static void SearchContact(ContactRepository repository)
        {
            string name;
            Console.Write("Enter name to search contact ==> ");
            name = Console.ReadLine();
            List<Contact> contacts = repository.SearchContact(name);
            foreach (var contact in contacts)
            {
                Console.WriteLine("\nID        : " + contact.ID);
                Console.WriteLine("Name      : " + contact.FirstName + " " + contact.LastName);
                Console.WriteLine("Mobile No : " + contact.MobileNumber);
            }
        }

        private static void ViewContacts(ContactRepository repository)
        {
            List<Contact> contacts = repository.GetContacts();
            foreach (var contact in contacts)
            {
                Console.WriteLine("\nID        : "+contact.ID);
                Console.WriteLine("Name      : "+contact.FirstName+" "+contact.LastName);
                Console.WriteLine("Mobile No : "+contact.MobileNumber);
            }
        }

        private static void DeleteContact(ContactRepository repository)
        {
            int id;
            Console.Write("Enter the id which you want to delte ==> ");
            id = int.Parse(Console.ReadLine());
            repository.DeleteContact(id);
            Console.WriteLine("Contact deleted sucessfully...");
        }

        private static void UpdateContact(ContactRepository repository)
        {
            int id;
            Console.Write("Enter the id which you want to update ==> ");
            id = int.Parse(Console.ReadLine());
            string fname, lname;
            long mob;
            Console.Write("Enter First name ==> ");
            fname = Console.ReadLine();
            Console.Write("Enter Last name ==> ");
            lname = Console.ReadLine();
            Console.Write("Enter Mobile Number ==> ");
            mob = long.Parse(Console.ReadLine());
            Contact contact = new Contact { FirstName = fname, LastName = lname, MobileNumber = mob };
            repository.EditContact(id,contact);
        }



        private static void AddContact(ContactRepository repository)
        {
            string fname, lname;
            long mob;
            Console.Write("Enter First name ==> ");
            fname = Console.ReadLine();
            Console.Write("Enter Last name ==> ");
            lname = Console.ReadLine();
            Console.Write("Enter Mobile Number ==> ");
            mob = long.Parse(Console.ReadLine());
            repository.AddContact(new Contact { FirstName = fname, LastName = lname, MobileNumber = mob });
            Console.WriteLine("Contact added successfully...\n");
        }
    }
}
