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
                Id = 1,
                Name = "Amrita Singh",
                Department = "Computer Engineering",
                Cgpa = 3.75
            };

            return View(student);
        }
    }
}