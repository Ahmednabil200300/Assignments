using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE02.Models
{
    [PrimaryKey(nameof(Inst_Id), nameof(Course_Id))]
    internal class Course_Inst
    {
        public int Inst_Id { get; set; }
        public int Course_Id { get; set; }
        public string? evaluate { get; set; }

        public Instructor Instructor { get; set; } = null!;
        public Course Course { get; set; } = null!;
    }
}
