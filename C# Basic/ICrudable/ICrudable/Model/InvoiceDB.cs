using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICrudable.Model
{
    class InvoiceDB : ICrudable
    {
        public void Add()
        {
            Console.WriteLine("InvoiceDB Added");
        }

        public void Delete()
        {
            Console.WriteLine("InvoiceDB Deleted");
        }

        public void Read()
        {
            Console.WriteLine("InvoiceDB Read");
        }

        public void Update()
        {
            Console.WriteLine("InvoiceDB Updated");
        }
    }
}
