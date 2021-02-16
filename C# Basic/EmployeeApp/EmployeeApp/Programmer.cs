using System;

namespace EmployeeApp
{
    class Programmer : Employee
    {
        private float bonus;
        public Programmer(float bonus,int id,string name,float salary,DateTime date,string emptype) : base(id,name,salary,date,emptype)
        {
            this.bonus = bonus;
        }

        public float Bonus
        {
            get { return bonus; }
        }

        public float TotalSalaryOfProgrammer() {
           return Salary + Bonus;
        }
    }
}
