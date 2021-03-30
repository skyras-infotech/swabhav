using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernateEmpDeptApp.Model;

namespace NHibernateEmpDeptApp
{
    class EmployeeMap : ClassMap<Emp>
    {
        public EmployeeMap() {
            Table("tblEmployee");
            Id(x => x.ID).GeneratedBy.Identity();
            Map(x => x.EmpName);
            Map(x => x.Salary);
            Map(x => x.Job);
            References(x => x.Dept)
                .Column("Department_ID");

        }
    }
}
