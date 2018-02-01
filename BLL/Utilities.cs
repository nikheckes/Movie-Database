using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DataAccess;

namespace BLL
{
    public class Utilities
    {
        public Utilities()
        { }
        static public List<Movie> ConvertListMovieDtoToListMovie(List<MovieDto> movieDtos)
        {
            List<Movie> movies = new List<Movie>();
            foreach (MovieDto movieDto in movieDtos)
            {
                movies.Add(MovieMapper.ConvertMovieDtoToMovie(movieDto));
            }
            return movies;
        }
    }
}
