using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeCRUDUsingRouteRoutePrefixAndDTO.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string EmployeeName { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }
}