using System;

namespace EmployeeApp
{
    class Manager : Employee
    {
        private float hra;
        private float da;
        private float ta;
        public Manager(float hra, float da, float ta, int id, string name, float salary, DateTime date,string emptype) : base(id, name, salary, date,emptype) {
            this.hra = hra;
            this.da = da;
            this.ta = ta;
        }

        public float TA {
            get { return ta; }
        }

        public float DA {
            get { return da; }
        }

        public float HRA {
            get { return hra; }
        }

        public float TotalSalaryOfManager() {
            float salary = Salary + ((Salary * (TA+DA+HRA)) / 100);
            return salary;
        }

    }
}
