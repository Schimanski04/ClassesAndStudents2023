using System.ComponentModel.DataAnnotations;

namespace ClassesAndStudents2023.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Firstname { get; set; } = String.Empty;
        public string Lastname { get; set; } = String.Empty;
        public Classroom? Classroom { get; set; }
        [Required]
        public int ClassroomId { get; set; }
    }
}
