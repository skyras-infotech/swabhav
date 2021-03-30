using FluentNHibernate.Mapping;
using NHibernateCustomerOrderLineItemApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateCustomerOrderLineItemApp
{
    class OrderMap : ClassMap<Order>
    {
        public OrderMap() {
            Id(x => x.ID).GeneratedBy.Identity();
            Map(x => x.Date);
            References(x => x.Customer)
                .Column("C_ID");
            HasMany(x => x.LineItems)
               .KeyColumn("O_ID")
               .Cascade.AllDeleteOrphan()
               .Inverse();
        }
    }
}
