using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityFrameWorkPractice.Model
{
    public class Repository
    {
        private BreakAwayContext context = new BreakAwayContext();
        public IEnumerable<Employee> Employees
        {
            get
            {
                return context.Employees;
            }
        }
        public IEnumerable<Employee> GetEmployeesWithDept()
        {
            var employees = context.Employees.Include("Department");
            return employees;
        }
        public void InsertDestination()
        {
            var destination = new Destination 
            {
                Country = "Indonesia",
                Description="EcoTourism at its best in exquisite Bali",
                Name="Bali"
            };
            context.Destinations.Add(destination);
            context.SaveChanges();
        }
    }
}