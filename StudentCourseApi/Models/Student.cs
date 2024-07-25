using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCourseApi.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        [ForeignKey("Course")]
        public int CourseId { get; set; }
        public  Course Course { get; set; }

    }
}
