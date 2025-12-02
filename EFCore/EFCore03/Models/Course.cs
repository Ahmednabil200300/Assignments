using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C44_G03_EFCore03.Models
{
    [Table("Courses", Schema = "dbo")]
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }

        [Required]
        public int CourseDuration { get; set; }

        [Column("CourseName", TypeName = "varchar")]
        [StringLength(100, MinimumLength = 2)]
        [Required]
        public string CourseName { get; set; }

        [Column(TypeName = "varchar(500)")]
        [Required]
        public string CourseDescription { get; set; }

        [Required]
        public int TopicId { get; set; }

        [ForeignKey(nameof(TopicId))]
        public Topic Topic { get; set; }

        public ICollection<StudCourse> StudCourses { get; set; }
        public ICollection<Course_Inst> Course_Insts { get; set; }
    }
}