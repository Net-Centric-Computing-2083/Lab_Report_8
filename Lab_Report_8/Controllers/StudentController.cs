using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Details()
        {
            Student student = new Student
            {
                Id = 1,
                Name = "Diwakar Lamichhane",
                Age = 23,
                Address = "Kathmandu, Nepal",
                Semester = 6
            };

            return View(student);
        }
    }
}
