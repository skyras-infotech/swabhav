using System;

namespace EmployeeApp
{
    class Employee
    {
        private int id;
        private string name;
        private float salary;
        private DateTime dob;
        private string empType;

        public Employee(int id, string name, float salary, DateTime dob,string empType)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.dob = dob;
            this.empType = empType;
        }

        public string EMPType {
            get { return empType; }
        }

        public DateTime DOB
        {
            get { return dob; }
        }

        public float Salary
        {
            get { return salary; }
        }

        public string Name
        {
            get { return name; }
        }

        public int ID
        {
            get { return id; }
        }

    }
}
