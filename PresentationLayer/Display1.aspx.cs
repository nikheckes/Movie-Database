using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace PresentationLayer
{
    public partial class Display : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(IsPostBack))
            {
                Session.Abandon();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Session.Add("playerName", lbDisplay.SelectedValue);
            Response.Redirect("~/UpdateMovie.aspx");
        }
    }
}