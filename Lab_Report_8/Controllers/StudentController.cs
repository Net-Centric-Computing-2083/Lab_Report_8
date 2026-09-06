using Microsoft.AspNetCore.Mvc;
using LabReport8.Models;

namespace LabReport8.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Details()
        {
            Student student = new Student
            {
                Id = 20,
                Name = "Samriddha Poudel",
                Email = "samriddha@gmail.com",
                Course = "BSc. CSIT",
                Age = 21
            };

            return View(student);
        }
    }
}