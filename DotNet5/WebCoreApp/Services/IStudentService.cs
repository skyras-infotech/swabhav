using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreApp.Services
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        void AddStudents(Student student);
    }
}
