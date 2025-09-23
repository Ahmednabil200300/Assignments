using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE02.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string FName { get; set; } = null!;
        public string LName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int age { get; set; }
        public int Dep_Id { get; set; }
        public Department StudentDepartment { get; set; } = null!;
        public ICollection<Stud_Course> StudentCourses { get; set; } = new HashSet<Stud_Course>();
  
    }
}
