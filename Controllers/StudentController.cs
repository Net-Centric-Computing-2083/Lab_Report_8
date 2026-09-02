using LabReport8.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabReport8.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Details()
        {
            Student student = new Student
            {
                Id = 80010915,
                Name = "Ananta Dhakal",
                Faculty = "BSc. CSIT",
                Semester = 6,
                Address = "Kathmandu, Nepal"
            };

            return View(student);
        }
    }
}
