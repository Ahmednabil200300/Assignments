using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    enum Gender
    {
        M, F
    }
    [Flags]
    enum SecurityPrivileges : Byte
    {
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8,
           SecurityOfficer = 16,


    }
    class Employees
    {


        public int Id { get; set; }
        public string? Name { get; set; }
        public SecurityPrivileges SecurityPrivileges { get; set; }
        public decimal Salary { get; set; }
        public HireDate HireDate { get; set; }

        public Gender Gender { get; set; }

        public Employees()
        {

        }

        public Employees(int id, string? name, SecurityPrivileges securityPrivileges, decimal salary, HireDate hireDate, Gender gender)
        {
            Id = id;
            Name = name;
            SecurityPrivileges = securityPrivileges;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }
        public override string ToString()
        {
            return $"Id = {Id}\nName: {Name}\nSecurity Privileges: {SecurityPrivileges}\nSalary: {Salary}\nHire Date {HireDate} \nGender {Gender} ";
        }



       
    

 


    }
}
