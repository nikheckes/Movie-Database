using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationLayer
{
    public partial class RemoveMovie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Abandon();
        }
        protected void btnRemoveMovie_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.Transfer transfer = new BLL.Transfer();
                transfer.RemoveMovie(int.Parse(lbNames.SelectedValue));
                Response.Redirect("~/RemoveMovie.aspx");
            }
            catch
            { }
        }
    }
}