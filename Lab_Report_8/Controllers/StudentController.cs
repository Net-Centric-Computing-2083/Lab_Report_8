using LabReport8.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabReport8.Controllers
{
    public class StudentController : Controller
    {
        // GET: /Student/Details
        public IActionResult Details()
        {
            // In a real application this data would come from a database.
            Student student = new Student
            {
                Id = 101,
                Name = "Rojesh Niroula",
                Course = "Net-Centric Computing",
                Semester = 6,
                Email = "rojesh@example.com"
            };

            return View(student);
        }
    }
}