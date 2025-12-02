using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C44_G03_EFCore03.Models
{
    [Table("Course_Insts", Schema = "dbo")]
    public class Course_Inst
    {
        [Key]
        [Column(Order = 1)]
        public int InstructorId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int CourseId { get; set; }

        [Range(0, 10)]
        [Required]
        public int Evaluation { get; set; }

        [ForeignKey(nameof(InstructorId))]
        public Instructor Instructor { get; set; }

        [ForeignKey(nameof(CourseId))]
        public Course Course { get; set; }
    }
}