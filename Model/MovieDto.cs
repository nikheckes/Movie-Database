using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class MovieDto
    {
        public MovieDto()
        { }
        #region Properties
        public int ID { get; set; }
        public string MovieName { get; set; }
        public string MovieDirector { get; set; }
        #endregion
        public MovieDto(int id, string movieName, string movieDirector)
        {
            ID = id;
            MovieName = movieName;
            MovieDirector = movieDirector;
        }
        
    }
}
