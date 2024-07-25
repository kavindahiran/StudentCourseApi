using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCourseApi.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string CourseName { get; set; }   
        public string ModulePricer { get; set; }
        public string LectureName { get; set; }

    }
}
