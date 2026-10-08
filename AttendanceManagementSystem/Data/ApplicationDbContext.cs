using AttendanceManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace AttendanceManagementSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Attendance> Attendances { get; set; }
    }
}