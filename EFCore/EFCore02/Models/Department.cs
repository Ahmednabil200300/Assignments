using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE02.Models
{
    internal class Department
    {
        [Key]
        public int DepId { get; set; }
      
        public string? Name { get; set; }
        public DateTime HiringDate { get; set; }
        public int Ins_Id { get; set; }
        public Instructor Manager { get; set; } = null!;
        public ICollection<Student> Students { get; set; } = new HashSet<Student>();
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
    }
}
