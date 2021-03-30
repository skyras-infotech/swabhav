using FluentNHibernate.Mapping;
using NHibernateCustomerOrderLineItemApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateCustomerOrderLineItemApp
{
    class CustomerMap : ClassMap<Customer>
    {
        public CustomerMap() {
            Id(x => x.ID).GeneratedBy.Identity();
            Map(x => x.Name);
            Map(x => x.MobileNo);
            HasMany(x => x.Orders)
                .KeyColumn("C_ID")
                .Cascade.AllDeleteOrphan()
                .Inverse();
        }
    }
}
