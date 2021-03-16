using System;

namespace EmployeeApp
{
    class Analyst : Employee
    {
        private float ta;

        public Analyst(float ta,int id, string name, float salary, DateTime date,string emptype) : base(id, name, salary, date,emptype)
        {
            this.ta = ta;
        }

        public float TA
        {
            get { return ta; }
        }

        public float TotalSalaryOfAnalyst() {
            float salary = Salary + ((Salary * TA) / 100);
            return salary;
        }
    }
}
