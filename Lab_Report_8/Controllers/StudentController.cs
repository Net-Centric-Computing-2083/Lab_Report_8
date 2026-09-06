using Microsoft.AspNetCore.Mvc;
using MVCWelcomeApp.Models;

namespace MVCWelcomeApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Details()
        {
            // Creating student object
            Student student = new Student
            {
                Id = 911,
                Name = "Aakriti",
                Faculty = "BSc. CSIT",
                Semester = 6,
                Address = "Kathmandu"
            };

            // Passing student data to the View
            return View(student);
        }
    }
}