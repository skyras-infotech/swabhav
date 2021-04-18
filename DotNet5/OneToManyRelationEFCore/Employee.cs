using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyRelationEFCore
{
    [Table("tblEmployee")]
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ID { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
        public Department Department { get; set; }
        public Guid DepartmentID { get; set; }
    }
}
