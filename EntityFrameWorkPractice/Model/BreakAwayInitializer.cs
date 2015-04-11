using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFrameWorkPractice.Model
{
    public class BreakAwayInitializer: DropCreateDatabaseIfModelChanges<BreakAwayContext>
    {
        protected override void Seed(BreakAwayContext context)
        {
            GetEoployees().ForEach(c => context.Employees.Add(c));
            GetDepartments().ForEach(p => context.Departments.Add(p));
        }
        private static List<Employee> GetEoployees()
        {
            var employees = new List<Employee> {
                new Employee {
                    EmployeeId = 1,
                    Name = "Ajay",
                    Age = 30,
                    DepartmentId = 2
                },
                new Employee {
                    EmployeeId = 2,
                    Name = "Uday",
                    Age = 28,
                    DepartmentId = 2
                },
                new Employee {
                    EmployeeId = 3,
                    Name = "Ranarthk",
                    Age = 32,
                    DepartmentId = 1
                },
                new Employee {
                    EmployeeId = 4,
                    Name = "Sean",
                    Age = 22,
                    DepartmentId = 3
                },
                new Employee {
                    EmployeeId = 5,
                    Name = "Marven",
                    Age = 25,
                    DepartmentId = 1
                },
            };
            return employees;
        }
        private static List<Department> GetDepartments()
        {
            var departments = new List<Department> {
                new Department {
                    DepartmentId = 1,
                    Name = "Finance"
                },
                new Department {
                    DepartmentId = 2,
                    Name = "IT"
                },
                new Department {
                    DepartmentId = 3,
                    Name = "HR"
                },
                new Department {
                    DepartmentId = 4,
                    Name = "Accounting"
                }
            };
            return departments;
        }
    }
}