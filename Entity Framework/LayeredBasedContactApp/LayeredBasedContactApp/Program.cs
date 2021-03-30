using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LayeredBasedContactApp.DBContext;
using LayeredBasedContactApp.Model;
using LayeredBasedContactApp.Repository;

namespace LayeredBasedContactApp
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
                switch (choice)
                {
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
            if (contacts == null) {
                Console.WriteLine("there is no contact with this name");
                return;
            }
            PrintContacts(contacts);
        }

        private static void ViewContacts(ContactRepository repository)
        {
           List<Contact> contacts = repository.GetContacts();
           PrintContacts(contacts);
        }
        private static void PrintContacts(List<Contact> contacts) {
            foreach (var item in contacts)
            {
                Console.WriteLine("\nID        : " + item.ID);
                Console.WriteLine("Name      : " + item.Name);
                Console.WriteLine("Mobile No : " + item.MobileNumber);
                Console.Write("Address   : ");
                for (int i = 0; i < item.Addresses.Count; i++)
                {
                    if (i == item.Addresses.Count - 1)
                    {
                        Console.Write(item.Addresses[i].City);
                    }
                    else
                    {
                        Console.Write(item.Addresses[i].City + ", ");
                    }
                }
                Console.WriteLine();
            }
        }
        private static void DeleteContact(ContactRepository repository)
        {
            Console.Write("Enter the id which you want to delete ==> ");
            int id = int.Parse(Console.ReadLine());
            Contact contact = repository.GetContactByID(id);
            if (contact == null)
            {
                Console.WriteLine("Invalid ID!");
                return;
            }
            repository.DeleteContact(id);
            Console.WriteLine("Contact deleted sucessfully...");
        }

        private static void UpdateContact(ContactRepository repository)
        {
            int id;
            Console.Write("Enter the id which you want to update ==> ");
            id = int.Parse(Console.ReadLine());
            Contact contact = repository.GetContactByID(id);
            if (contact == null) {
                Console.WriteLine("Invalid ID!");
                return;
            }
            string name, addr, strmob;
            long mob;
            Console.Write("Enter First name ==> ");
            name = Console.ReadLine();
            Console.Write("Enter Mobile Number ==> ");
            strmob = Console.ReadLine();
            mob = strmob == "" ? 0 : long.Parse(strmob);
            Contact c = new Contact { Name = name, MobileNumber = mob };

            for (int i = 1; i <= contact.Addresses.Count; i++)
            {
                Console.Write("Enter Address " + i + " ==> ");
                addr = Console.ReadLine();
                c.Addresses.Add(new Address { City = addr });
            }
            repository.UpdateContact(id, c);
            Console.WriteLine("Contact updated successfully..");
        }



        private static void AddContact(ContactRepository repository)
        {
            string name,addr;
            long mob;
            Console.Write("Enter name ==> ");
            name = Console.ReadLine();
            Console.Write("Enter Mobile Number ==> ");
            mob = long.Parse(Console.ReadLine());

            Contact c = new Contact { Name = name, MobileNumber = mob };

            Console.Write("How many address you want to insert ==> ");
            int no = int.Parse(Console.ReadLine());
            for (int i = 1; i <= no; i++)
            {
                Console.Write("Enter Address "+i+" ==> ");
                addr = Console.ReadLine();
                c.Addresses.Add(new Address { City = addr });
            }

            repository.AddContact(c);
            Console.WriteLine("Contact added successfully...");
        }
    }
}
