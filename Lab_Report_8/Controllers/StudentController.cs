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
                Id = 80010950,
                Name = "Saurav Basnet",
                Faculty = "BSc CSIT",
                Email = "sauravcsit23@oic.edu.np"
            };

            return View(student);
        }
    }
}
