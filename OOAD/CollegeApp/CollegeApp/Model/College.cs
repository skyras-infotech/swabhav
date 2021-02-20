using System.Collections.Generic;

namespace CollegeApp.Model
{
    class College
    {
        
        private string name;
        private string address;
        private long mobile;
        private List<Students> students;

        public College(string name, string address, long mobile, List<Students> students)
        {
            this.name = name;
            this.address = address;
            this.mobile = mobile;
            this.students = students;
        }

        public List<Students> GetListOfStudents
        {
            get { return students; }
        }
        public long CollegeMobileNo
        {
            get { return mobile; }
        }


        public string CollegeAddress
        {
            get { return address; }
           
        }


        public string CollegeName
        {
            get { return name; }
          
        }

    }
}
