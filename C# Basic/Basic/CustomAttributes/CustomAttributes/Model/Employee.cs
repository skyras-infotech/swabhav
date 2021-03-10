namespace CustomAttributes.Model
{
    class Employee
    {
        int id;
        string name;

        public Employee(int i, string n)
        {
            id = i;
            name = n;
        }

        [CustomAttribute("Method","Display the information of the employee")]
        public void DisplayInfo() { 
            
        }

        [CustomAttribute("Accessor", "Gives value of Employee Id")]
        public int getId()
        {
            return id;
        }

     
        [CustomAttribute("Accessor", "Gives value of Employee Name")]
        public string getName()
        {
            return name;
        }
    }
}
