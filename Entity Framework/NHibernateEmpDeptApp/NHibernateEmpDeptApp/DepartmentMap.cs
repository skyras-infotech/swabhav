using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using NHibernateEmpDeptApp.Model;

namespace NHibernateEmpDeptApp
{
    class DepartmentMap : ClassMap<Dept>
    {
        public DepartmentMap() {
            Table("tblDepartment");
            Id(x => x.ID).GeneratedBy.Identity();
            Map(x => x.DeptName);
            Map(x => x.Location);
            HasMany(x => x.DeptEmployees)
                .KeyColumn("Department_ID")
                .Cascade.AllDeleteOrphan()
                .Inverse();
        }
    }
}
