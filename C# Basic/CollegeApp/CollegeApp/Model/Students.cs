namespace CollegeApp.Model
{
    class Students
    {
        private int rollNo;
        private string name;
        private int age;
        private long mob;
        private string address;

        public Students(int rollNo, string name, int age, long mob, string address)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.age = age;
            this.mob = mob;
            this.address = address;
        }

        public string Address
        {
            get { return address; }
        }

        public long Mobile
        {
            get { return mob; }
        }

        public int Age
        {
            get { return age; }
        }

        public string Name
        {
            get { return name; }
        }

        public int RollNo
        {
            get { return rollNo; }
        }

    }
}
