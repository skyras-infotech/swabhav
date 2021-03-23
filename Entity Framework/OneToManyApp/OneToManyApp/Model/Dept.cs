using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyApp.Model
{
    [Table("Dept")]
    class Dept
    {
        [Key]
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public string Location { get; set; }

        public virtual List<Emp> DeptEmployees { get; }

        public Dept()
        {
            DeptEmployees = new List<Emp>();
        }
    }
}
