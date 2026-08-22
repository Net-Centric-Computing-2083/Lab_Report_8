using Microsoft.AspNetCore.Mvc;
using StudentMVC.Models;
namespace StudentMVC.Controllers { 
    public class StudentController : Controller { 
        public IActionResult Details() { 
            Student student = new Student { 
                StudentId = 101, 
                Name = "Kushal Pahadi", 
                Email = "kushalpcsit23@oic.edu.np", 
                Course = "BSc. CSIT", 
                Marks = 85 
            }; 
            return View(student); 
        } 
    } 
}