using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToCSVApp.Model
{
    class Department
    {
        public int DepartmentNo { get; set; }
        public string DepartmentName { get; set; }
        public string Location { get; set; }

        internal static Department ParseData(string row)
        {
            var columns = row.Split(',');
            return new Department()
            {
                DepartmentNo = int.Parse(columns[0]),
                DepartmentName = columns[1],
                Location = columns[2],
            };
        }
    }
}
