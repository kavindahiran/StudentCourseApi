using Microsoft.EntityFrameworkCore;

namespace StudentCourseApi.Models
{
    public class StudentDb : DbContext
    {
        public StudentDb(DbContextOptions<StudentDb> options) : base(options)
        {

        }
        public DbSet<Student> Employees { get; set; }
        public DbSet<Course> Course { get; set; }
    }
}
