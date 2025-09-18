using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_EFCore01.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [NotMapped]
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; } 
        public double HourRate { get; set; }
        public string Address { get; set; }
        public int Dep_Id { get; set; }
    }
}
