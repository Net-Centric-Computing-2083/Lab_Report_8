namespace Lab_Report_8.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string RollNumber { get; set; } = string.Empty;
        public string Program { get; set; } = string.Empty;
        public int Semester { get; set; }
    }
}