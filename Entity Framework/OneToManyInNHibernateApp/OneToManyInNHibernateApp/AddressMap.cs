using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneToManyInNHibernateApp.Model;

namespace OneToManyInNHibernateApp
{
    class AddressMap : ClassMap<Address>
    {
        public AddressMap() {
            Id(x => x.ID).GeneratedBy.Identity();
            Map(x => x.City);
            References(x => x.Employees)
                .Column("Employee_ID");
            Table("tblAddress");
        }
    }
}
