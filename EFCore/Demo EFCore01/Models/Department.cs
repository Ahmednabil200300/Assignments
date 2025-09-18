using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_EFCore01.Models
{
    internal class Department
    {
        [Key]
        public int DepId { get; set; }
        [Column("DepartmentName",TypeName ="varchar(50)")]
        public string? Name { get; set; }
        public DateTime HiringDate { get; set; }
        public int Ins_Id { get; set; }
    }
}
