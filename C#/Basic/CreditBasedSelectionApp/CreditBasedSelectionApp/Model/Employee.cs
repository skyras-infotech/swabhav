using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditBasedSelectionApp.Model
{
    public class Employee
    {
        private int id;
        private string name;
        private string credit_point;
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }


        public string CreditPoint
        {
            get { return credit_point; }
            set { credit_point = value; }
        }

        public Employee WhoIsElder(Employee e) {
            if (Age > e.Age)
            {
                return this;
            }
            else
            {
                return e;
            }
        }
        
        public Employee WhoIsBetter(Employee e) {
            // if current class instance grade is A then current class 
            //instance user is better then another class instance
            if (CreditPoint.Equals("A Grade"))
            {
                return this;
            }
            else {
                return e;
            }
        }
    }
}
