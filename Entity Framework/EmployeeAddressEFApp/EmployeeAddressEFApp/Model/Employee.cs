using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAddressEFApp.Model
{
    [Table("tblEmployee")]
    class Employee
    {
        public int ID { get; set; }
        public string EmpName { get; set; }
        public string Job { get; set; }
        public double Salary { get; set; }
        public virtual List<Address> Addresses { get; }

        public Employee() {
            Addresses = new List<Address>();
        }
    }
}
