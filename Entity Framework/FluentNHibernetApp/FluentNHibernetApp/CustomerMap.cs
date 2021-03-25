using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernetApp.Model;

namespace FluentNHibernetApp
{
    class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap() {
            Id(x => x.ID);
            Map(x => x.FirstName);
            Map(x => x.LastName);
            Table("tblCustomer");
        }
    }
}
