using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace C44_G03_EFCore03.Models
{
    [Table("Departments", Schema = "dbo")]
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DeptId { get; set; }

        [Column("DeptName", TypeName = "varchar")]
        [StringLength(100, MinimumLength = 2)]
        [Required]
        public string DepartmentName { get; set; }

        public ICollection<Student> Students { get; set; }

        public Instructor HeadInstructor { get; set; }
    }
}