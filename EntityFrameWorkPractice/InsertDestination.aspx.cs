using EntityFrameWorkPractice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFrameWorkPractice
{
    public partial class InsertDestination : System.Web.UI.Page
    {
        Repository repository = new Repository();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            repository.InsertDestination();
        }

        public IEnumerable<EntityFrameWorkPractice.Model.Destination> GetDestinations()
        {
            return repository.GetDestinations();
        }
    }
}