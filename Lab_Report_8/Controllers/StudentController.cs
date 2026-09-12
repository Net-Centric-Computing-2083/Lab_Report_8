using Microsoft.AspNetCore.Mvc;
using Lab_Report_8.Models;

namespace Lab_Report_8.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Details()
        {
            Student student = new Student
            {
                Id = 4,
                Name = "Alkesh Chaudhary",
                Department = "QA",
                Cgpa = 2.2
            };

            return View(student);
        }
    }
}