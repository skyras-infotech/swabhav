using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToCSVApp.Model
{
    class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public int ManagerID { get; set; }
        public DateTime DOB { get; set; }
        public int Salary { get; set; }
        public int Commision { get; set; }
        public int DepartmentNo { get; set; }

        internal static Employee ParseData(string row)
        {
            var columns = row.Split(',');
            return new Employee()
            {
                EmpNo = int.Parse(columns[0]),
                Name = columns[1],
                Job = columns[2],
                //ManagerID = int.Parse(columns[3]).Equals(" ") ? 0 : int.Parse(columns[3]),
                DOB = DateTime.Parse(columns[4]),
                Salary = int.Parse(columns[5]),
                //Commision = int.Parse(columns[6]),
                DepartmentNo = int.Parse(columns[7])
                
            };
        }



    }
}
