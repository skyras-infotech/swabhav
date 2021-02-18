using System;
using System.Collections.Generic;
using CollegeApp.Model;

namespace CollegeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>();
            students.Add(new Students(100, "John Dae", 25, 9646959125, "Navsari"));
            students.Add(new Students(102, "Sumit Gupta", 20, 8541269852, "Surat"));
            students.Add(new Students(103, "Yogesh Patel", 22, 9517538526, "Vapi"));
            students.Add(new Students(104, "Urvisha Patel", 28, 9632587415, "Valsad"));

            College college = new College("MGITER", "Aat Gam, Navsari", 9852367415, students);
            PrintInfo(college);
        }

        private static void PrintInfo(College college)
        {
            Console.WriteLine("------------- College Info --------------");
            Console.WriteLine("College Name             :   " + college.CollegeName);
            Console.WriteLine("College Mobile Number    :   " + college.CollegeMobileNo);
            Console.WriteLine("Address of College       :   " + college.CollegeAddress);
            Console.WriteLine("No of student            :   " + college.GetListOfStudents.Count);
            Console.WriteLine();
            Console.WriteLine("------------- Students List --------------");
            foreach (var student in college.GetListOfStudents)
            {
                Console.WriteLine("Roll No                  :   " + student.RollNo);
                Console.WriteLine("Student Name             :   " + student.Name);
                Console.WriteLine("Student Age              :   " + student.Age);
                Console.WriteLine("Student Mobile No        :   " + student.Mobile);
                Console.WriteLine("Student Address          :   " + student.Address);
                Console.WriteLine();
            }
        }
    }
}
