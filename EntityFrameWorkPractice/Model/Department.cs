using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace EntityFrameWorkPractice.Model
{
    public class Department
    {
        public int DepartmentId { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
