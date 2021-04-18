using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OneToManyRelationEFCore
{
    [Table("tblDepartments")]
    public class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }

        public Department() 
        {
            Employees = new List<Employee>();
        }
    }
}
