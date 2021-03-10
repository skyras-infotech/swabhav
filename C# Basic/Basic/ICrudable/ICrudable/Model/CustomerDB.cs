using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICrudable.Model
{
    class CustomerDB : ICrudable
    {
        public void Add()
        {
            Console.WriteLine("CustomerDB Added");
        }

        public void Delete()
        {
            Console.WriteLine("CustomerDB Deleted");
        }

        public void Read()
        {
            Console.WriteLine("CustomerDB Read");
        }

        public void Update()
        {
            Console.WriteLine("CustomerDB Updated");
        }
    }
}
