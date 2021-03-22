using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToObjectApp.Model
{
    class Employee
    {
        private int _id;
        private string _name;
        private double _salary;
        private string designation;

        public Employee(int id, string name, double salary, string designation)
        {
            _id = id;
            _name = name;
            _salary = salary;
            this.designation = designation;
        }

        public string Designation
        {
            get { return designation; }
        }


        public double Salary
        {
            get { return _salary; }
        }


        public string Name
        {
            get { return _name; }
        }


        public int ID
        {
            get { return _id; }
        }

    }
}
