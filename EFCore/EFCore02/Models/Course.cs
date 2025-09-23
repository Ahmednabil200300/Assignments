using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE02.Models
{
    internal class Course
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Duration { get; set; }
        public int Top_Id { get; set; }
        public Topic Topic { get; set; } = null!;

        public ICollection<Course_Inst> Coursesinstructors { get; set; } = new HashSet<Course_Inst>();
        public ICollection<Stud_Course> CourseStudents { get; set; } = new HashSet<Stud_Course>();
    }
}
