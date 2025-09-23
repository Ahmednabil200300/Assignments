using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE02.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public double HourRate { get; set; }
        public string Address { get; set; } = null!;
        [ForeignKey(nameof(WorkForDepartment))]
        public int Dep_Id { get; set; }
        public Department ManageDepartment { get; set; } = null!;
        public Department WorkForDepartment { get; set; } = null!;
        public ICollection<Course_Inst> InstructorCourses { get; set; }= new HashSet<Course_Inst>();
    }
}
