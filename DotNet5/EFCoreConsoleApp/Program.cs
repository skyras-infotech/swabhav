using System;

namespace EFCoreConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CollegeDBContext _collegeDBContext = new CollegeDBContext();
            AddStudent(_collegeDBContext);
            Console.WriteLine("After Adding Student...\n");
            GetStudents(_collegeDBContext);
            UpdateStudent(_collegeDBContext);
            Console.WriteLine("After Updating Student name Yoeshkumar and standard is 5...\n");
            GetStudents(_collegeDBContext);
            DeleteStudent(_collegeDBContext);
            Console.WriteLine("After Removing Student which id is 2\n");
            GetStudents(_collegeDBContext);
        }

        private static void DeleteStudent(CollegeDBContext collegeDBContext)
        {
            collegeDBContext.Students.Remove(collegeDBContext.Students.Find(2));
            collegeDBContext.SaveChanges();
        }

        private static void UpdateStudent(CollegeDBContext collegeDBContext)
        {
            Student student = collegeDBContext.Students.Find(2);
            student.Name = "Yogeshkumar";
            student.Standard = 5;
            student.MobileNumber = 9517538426;
            collegeDBContext.Update(student);
            collegeDBContext.SaveChanges();
        }

        private static void GetStudents(CollegeDBContext collegeDBContext)
        {
            Console.WriteLine("====== Student List =======");
            foreach (var student in collegeDBContext.Students)
            {
                Console.WriteLine("ID           :\t" + student.ID);
                Console.WriteLine("Name         :\t" + student.Name);
                Console.WriteLine("Standard     :\t" + student.Standard);
                Console.WriteLine("Mobile Number:\t" + student.MobileNumber);
                Console.WriteLine();
            }
        }

        private static void AddStudent(CollegeDBContext collegeDBContext)
        {
            collegeDBContext.Students.Add(new Student { Name = "Sumit", Standard = 10, MobileNumber = 7600965621 });
            collegeDBContext.Students.Add(new Student { Name = "Yogesh", Standard = 8, MobileNumber = 9517538426 });
            collegeDBContext.Students.Add(new Student { Name = "Ajay", Standard = 12, MobileNumber = 9874563215 });
            collegeDBContext.SaveChanges();
        }
    }
}
