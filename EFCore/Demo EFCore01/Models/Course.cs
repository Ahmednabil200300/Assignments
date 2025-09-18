using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_EFCore01.Models
{
    internal class Course
    {
        public int Id { get; set; }
        [Required]
        [Column("CourseName", TypeName = "varchar(50)")]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public int topic_Id { get; set; }
    }
}
