using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Movie
    {
        public Movie()
        { }
        #region Properties
        public int ID { get; set; }
        public string MovieName { get; set; }
        public string MovieDirector { get; set; }
        #endregion
        public Movie(int id, string movieName, string movieDirector)
        {
            ID = id;
            MovieName = movieName;
            MovieDirector = movieDirector;
        }
    }
}
