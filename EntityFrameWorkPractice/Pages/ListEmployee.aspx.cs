using EntityFrameWorkPractice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFrameWorkPractice.Pages
{
    public partial class ListEmployee : System.Web.UI.Page
    {
        Repository repository = new Repository();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IEnumerable<Employee> GetEmployees()
        {
            return repository.Employees;
        }
    }
}