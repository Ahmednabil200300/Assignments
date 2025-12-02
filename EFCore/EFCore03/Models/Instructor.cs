using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C44_G03_EFCore03.Models
{
    [Table("Instructors", Schema = "dbo")]
    public class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InstructorId { get; set; }

        [Column("InstName", TypeName = "varchar")]
        [StringLength(100, MinimumLength = 2)]
        [Required]
        public string InstructorName { get; set; }

        [Required]
        [Column(TypeName = "money")]
        public decimal InstructorSalary { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        public Department Department { get; set; }

        public ICollection<Course_Inst> Course_Insts { get; set; }
    }
}