using System.ComponentModel.DataAnnotations;

namespace AttendanceManagementSystem.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Email { get; set; }

        public string Course { get; set; }

        public string Mobile { get; set; }
    }
}