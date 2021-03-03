using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using ContactApp.Model;

namespace ContactApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname, lname, address, email;
            long mobileNo;
            string path = @"D:\contacts.txt";
            string y = "y";
            List<Contact> listOfContacts = new List<Contact>();
            int index;
            if (File.Exists(path)) { 
                listOfContacts = DeserializeListOfContacts(path);
            }
            Console.WriteLine("--------- Welcome to the Contact App ---------");
            try
            {
                while (y.Equals("y") || y.Equals("Y"))
                {
                    Console.WriteLine("\nEnter 1 : to Add contact");
                    Console.WriteLine("Enter 2 : to Update contact");
                    Console.WriteLine("Enter 3 : to Delete contact");
                    Console.WriteLine("Enter 4 : to Display contact list\n");
                    Console.Write("Enter your choice ==> ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("\nEnter first name ==> ");
                            fname = Console.ReadLine();
                            Console.Write("Enter last name  ==> ");
                            lname = Console.ReadLine();
                            Console.Write("Enter email id   ==> ");
                            email = Console.ReadLine();
                            Console.Write("Enter phone no   ==> ");
                            mobileNo = Convert.ToInt64(Console.ReadLine());
                            Console.Write("Enter address    ==> ");
                            address = Console.ReadLine();
                            if (!CheckUserIsExist(listOfContacts, mobileNo, out index))
                            {
                                listOfContacts.Add(new Contact(fname, lname, address, mobileNo, email));
                                SerializeListOfContacts(path, listOfContacts);
                            }
                            else {
                                Console.WriteLine("Sorry these name's contacts already exist");
                            }
                            break;
                        case 2:
                            Console.Write("\nEnter mobile number to update a contact ==> ");
                            mobileNo = Convert.ToInt64(Console.ReadLine());
                            if (CheckUserIsExist(listOfContacts, mobileNo,out index))
                            {
                                Console.Write("\nEnter new first name ==> ");
                                fname = Console.ReadLine();
                                Console.Write("Enter new last name  ==> ");
                                lname = Console.ReadLine();
                                Console.Write("Enter new email id   ==> ");
                                email = Console.ReadLine();
                                Console.Write("Enter new phone no   ==> ");
                                var mob = Console.ReadLine();
                                mobileNo = mob.Equals("") ? 0 : Convert.ToInt64(mob);
                                Console.Write("Enter new address    ==> ");
                                address = Console.ReadLine();
                                listOfContacts[index].FName = fname.Equals("") ? listOfContacts[index].FName : fname;
                                listOfContacts[index].LName = lname.Equals("") ? listOfContacts[index].LName : lname;
                                listOfContacts[index].MobileNo = mobileNo.Equals(0) ? listOfContacts[index].MobileNo : mobileNo;
                                listOfContacts[index].Email = email.Equals("") ? listOfContacts[index].Email : email;
                                listOfContacts[index].Address = address.Equals("") ? listOfContacts[index].Address : address;
                                Console.WriteLine("Contact Updated..");
                                SerializeListOfContacts(path, listOfContacts);
                            }
                            else
                            {
                                Console.WriteLine("Sorry there is no contact with this name");
                            }
                            break;
                        case 3:
                            Console.Write("\nEnter mobile number to delete a contact ==> ");
                            mobileNo = Convert.ToInt64(Console.ReadLine());
                            if (CheckUserIsExist(listOfContacts, mobileNo, out index))
                            {
                                listOfContacts.RemoveAt(index);
                                Console.WriteLine("Contact Deleted..");
                                SerializeListOfContacts(path, listOfContacts);
                            }
                            else
                            {
                                Console.WriteLine("Sorry there is no contact with this name");
                            }
                            break;
                        case 4:
                            Console.WriteLine("\n------- Your Contact List ------\n");
                            List<Contact> list = DeserializeListOfContacts(path);
                            list.Sort();
                            foreach (var item in list)
                            {
                                Console.WriteLine("Name      :  " + item.FName + " " + item.LName);
                                Console.WriteLine("Email     :  " + item.Email);
                                Console.WriteLine("Mobile No :  " + item.MobileNo);
                                Console.WriteLine("Address   :  " + item.Address);
                                Console.WriteLine();
                            }
                            break;
                    }
                    Console.Write("\nPress y for continue! -- ");
                    y = Console.ReadLine();
                }
            }
            catch (Exception e) {
                Console.WriteLine("Error : "+e.Message);
            }
        }
        static void SerializeListOfContacts(string path, List<Contact> listOfContacts)
        {
            FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, listOfContacts);
            stream.Close();
        }
        static List<Contact> DeserializeListOfContacts(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            List<Contact> list = (List<Contact>)formatter.Deserialize(fileStream);
            fileStream.Close();
            return list;
        }
        static bool CheckUserIsExist(List<Contact> listOfContacts, long mob, out int index) {
            foreach (var item in listOfContacts.ToList())
            {
                if (item.MobileNo == mob)
                {
                    index = listOfContacts.IndexOf(item); 
                    return true;
                }
            }
            index = 0;
            return false;
        }
    }
}
