namespace EqualsMethodOverridenApp
{
    class Employee
    {
        private string idNumber;
        private string name;

        public Employee(string idNumber, string name)
        {
            this.idNumber = idNumber;
            this.name = name;
        }

        public override bool Equals(object obj)
        {
            Employee personObj = obj as Employee;
            if (personObj == null)
            {
                return false;
            }
            return this.idNumber.Equals(personObj.idNumber);
        }

        public override int GetHashCode()
        {
            return this.idNumber.GetHashCode();
        }
    }
}
