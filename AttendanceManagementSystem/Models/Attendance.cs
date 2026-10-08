using System.ComponentModel.DataAnnotations.Schema;

namespace AttendanceManagementSystem.Models
{
    public class Attendance
    {
        public int Id { get; set; }

        public int StudentId { get; set; }

        public DateTime AttendanceDate { get; set; }

        public string Status { get; set; }

        [ForeignKey("StudentId")]
        public Student Student { get; set; }
    }
}