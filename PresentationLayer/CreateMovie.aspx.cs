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
    public partial class CreateMovie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(IsPostBack))
            {
                Session.Abandon();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            AddMovie();
            Response.Redirect("~/Display1.aspx");
        }

        protected void AddMovie()
        {
            BLL.Transfer transfer = new BLL.Transfer();
            Model.Movie movie = new Model.Movie();

            movie.MovieName = txtName.Text;
            movie.MovieDirector = txtDirector.Text;

            transfer.AddMovie(movie);
        }
    }
}