using Lab8.Models;
using Lab8.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabReport8.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Details()
        {
            Student student = new Student
            {
                Id = 1,
                Name = "Rusha Pokharel",
                Course = "CSIT"
            };

            return View(student);
        }
    }
}