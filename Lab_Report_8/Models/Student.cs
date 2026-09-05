using System.ComponentModel.DataAnnotations;

namespace LabReport8.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Course { get; set; }

        public int Semester { get; set; }

        public string Email { get; set; }
    }
}