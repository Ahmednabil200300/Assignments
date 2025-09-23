using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE02.Models
{
    [PrimaryKey(nameof(Stud_Id), nameof(Course_Id))]
    internal class Stud_Course
    {
        public int Stud_Id { get; set; }
        public int Course_Id { get; set; }
        public int Grade { get; set; }
    }
}
