using FluentNHibernate.Mapping;
using NHibernateCustomerOrderLineItemApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHibernateCustomerOrderLineItemApp
{
    class LineItemMap : ClassMap<LineItem>
    {
        public LineItemMap() {
            Id(x => x.ID).GeneratedBy.Identity();
            Map(x => x.Quantity);
            References(x => x.Order)
                .Column("O_ID");
        }
    }
}
