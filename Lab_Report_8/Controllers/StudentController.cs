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
                Name = "Aadarsha Khadka",
                Faculty = "BSc CSIT",
                Email = "aadarshakcsit23@oic.edu.np"
            };

            return View(student);
        }
    }
}
