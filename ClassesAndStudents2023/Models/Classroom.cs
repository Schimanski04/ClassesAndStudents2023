using System.Text.Json.Serialization;

namespace ClassesAndStudents2023.Models
{
    public class Classroom
    {
        public int ClassroomId { get; set; }
        public string Name { get; set; } = string.Empty;
        [JsonIgnore]
        public ICollection<Student>? Students { get; set; }
    }
}
