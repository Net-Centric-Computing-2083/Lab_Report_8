using Microsoft.AspNetCore.Mvc;
using MVCViewsDemo.Models;

namespace MVCViewsDemo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Details()
        {
            Student student = new Student
            {
                Id = 928,
                Name = "Gayatri Joshi",
                Course = "Bsc.CSIT",
                Age = 21,
                Semester = 6
            };

            return View(student);       
        }
    }
}