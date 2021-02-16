using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICrudable.Model;

namespace ICrudable
{
    class Program
    {
        static void Main(string[] args)
        {
            AddressDB address = new AddressDB();
            CustomerDB customer = new CustomerDB();
            InvoiceDB invoice = new InvoiceDB();
            PrintInfo(address);
            PrintInfo(customer);
            PrintInfo(invoice);
        }

        public static void PrintInfo(ICrudable crudable) {
            crudable.Add();
            crudable.Update();
            crudable.Delete();
            crudable.Read();
            Console.WriteLine();
        }
    }
}
