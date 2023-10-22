using Microsoft.AspNetCore.Mvc;
using TutoringSystem.Controllers;
using TutoringSystem.Interfaces;
using TutoringSystem.Models;
using TutoringSystem.Services;

namespace TutoringSystem.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // GET: /Student
        public IActionResult Index()
        {
            var students = _studentService.GetAllStudents();
            return View(students);
        }

        // GET: /Student/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Student/Register
        [HttpPost]
        public IActionResult Register(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }

            _studentService.RegisterStudent(student);

            return RedirectToAction("Index");
        }

      
    }
}
