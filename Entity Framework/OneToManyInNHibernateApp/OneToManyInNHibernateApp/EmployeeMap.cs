using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneToManyInNHibernateApp.Model;

namespace OneToManyInNHibernateApp
{
    class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap() {
            Id(x => x.ID).GeneratedBy.Identity();
            Map(x => x.EmpName);
            Map(x => x.Job);
            Map(x => x.Salary);
            HasMany(x => x.Addresses)
                .KeyColumn("Employee_ID")
                .Cascade.AllDeleteOrphan()
                .Inverse();
            Table("tblEmployee");

        }
    }
}
