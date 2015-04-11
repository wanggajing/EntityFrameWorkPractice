using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFrameWorkPractice.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [MaxLength(50),MinLength(2),Required]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}