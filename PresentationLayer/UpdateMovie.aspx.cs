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
    public partial class UpdateMovie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!(IsPostBack))
            {
                string name = Session["playerName"].ToString();
                Session.Remove("playerName");
                Transfer transfer = new Transfer();
                Movie movie = transfer.SelectSingleMovie(name);
                hfID.Value = movie.ID.ToString();
                txtName.Text = movie.MovieName;
                txtDirector.Text = movie.MovieDirector;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Update();
            Response.Redirect("~/Display1.aspx");
        }

        protected void Update()
        {
            BLL.Transfer transfer = new BLL.Transfer();
            Model.Movie movie = new Model.Movie();

            movie.ID = int.Parse(hfID.Value);
            movie.MovieName = txtName.Text;
            movie.MovieDirector = txtDirector.Text;

            transfer.UpdateMovie(movie);
        }
    }
}