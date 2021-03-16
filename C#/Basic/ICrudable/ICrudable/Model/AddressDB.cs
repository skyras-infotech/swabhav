using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICrudable.Model
{
    class AddressDB : ICrudable
    {
        public void Add()
        {
            Console.WriteLine("AddressDB Added");
        }

        public void Delete()
        {
            Console.WriteLine("AddressDB Deleted");
        }

        public void Read()
        {
            Console.WriteLine("AddressDB Read");
        }

        public void Update()
        {
            Console.WriteLine("AddressDB Updated");
        }
    }
}
