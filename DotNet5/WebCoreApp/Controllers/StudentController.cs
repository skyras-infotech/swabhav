using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCoreApp.Services;

namespace WebCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService studentService) 
        {
            _service = studentService;
        }

        [HttpGet]
        public List<Student> GetStudents() 
        {
            return _service.GetStudents();
        }

        [HttpPost]
        public IActionResult PostStudent([FromBody]Student student)
        {
            _service.AddStudents(new Student { Name = student.Name, ID = student.ID, MobileNumber = student.MobileNumber});
            return new ObjectResult("Employee added successfully");
        }
    }
}
