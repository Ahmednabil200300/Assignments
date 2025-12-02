using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C44_G03_EFCore03.Models
{
    [Table("StudCourses", Schema = "dbo")]
    public class StudCourse
    {
        [Key]
        [Column(Order = 1)]
        public int StudentId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int CourseId { get; set; }

        [Range(0, 100)]
        [Required]
        public int CourseGrade { get; set; }

        [ForeignKey(nameof(StudentId))]
        public Student Student { get; set; }

        [ForeignKey(nameof(CourseId))]
        public Course Course { get; set; }
    }
}