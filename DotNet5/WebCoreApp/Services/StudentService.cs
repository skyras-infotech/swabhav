using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreApp.Services
{
    public class StudentService : IStudentService
    {
        private List<Student> _students = new List<Student>();

        public StudentService()
        {
            _students.Add(new Student { ID = 101, Name = "Sumit Gupta", MobileNumber = 9664695915 });
            _students.Add(new Student { ID = 102, Name = "Yogesh Patel", MobileNumber = 9874563215 });
            _students.Add(new Student { ID = 103, Name = "Sumit Gupta", MobileNumber = 9632587415 });
        }

        public void AddStudents(Student student)
        {
            _students.Add(student);
        }

        public List<Student> GetStudents()
        {
            return _students;
        }
    }
}
